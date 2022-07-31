using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime;
using System.Runtime.Loader;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;

namespace Ellabit.DynamicCode
{
    public class SimpleUnloadableAssemblyLoadContext : AssemblyLoadContext
    {
        HttpClient client;
        public SimpleUnloadableAssemblyLoadContext(HttpClient httpClient)
           : base(isCollectible: true)
        {
            client = httpClient;
        }

        public async Task<Assembly?> GetAssembly(string cacheAssemblyName)
        {
            Assembly? assembly = null;
            try
            {
                assembly = this.Assemblies.FirstOrDefault(asm => asm.FullName == cacheAssemblyName + ", Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");

            }
            catch { }
            if (assembly != null)
            {
                return assembly;
            }

            SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(@"
                using System;

                namespace RoslynCompileSample
                {
                    public class LocalTemp
                    {
                        public int NextTemp()
                        {
                            return System.Random.Shared.Next(-20, 55);
                        }
                    }
                }");


            

            string assemblyName = Path.GetFileName(cacheAssemblyName);
            Console.WriteLine($"GetAssembly assemblyName: {assemblyName}");
            Console.WriteLine($"GetAssembly typeof(object).Assembly.Location: {typeof(object).Assembly.Location}");
            Console.WriteLine($"GetAssembly typeof(Enumerable).Assembly.Location: {typeof(Enumerable).Assembly.Location}");
            //MetadataReference[] references = new MetadataReference[]
            //{
            //    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            //    MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location)
            //};
            Assembly[] referenceAssemblyRoots = new[]
            {
                typeof(AssemblyTargetedPatchBandAttribute).Assembly, // System.Private.CoreLib
                typeof(Uri).Assembly, // System.Private.Uri
                typeof(Console).Assembly, // System.Console
                typeof(IQueryable).Assembly, // System.Linq.Expressions
                typeof(HttpClient).Assembly, // System.Net.Http
                typeof(RequiredAttribute).Assembly, // System.ComponentModel.Annotations
                typeof(Regex).Assembly, // System.Text.RegularExpressions
                typeof(NavLink).Assembly, // Microsoft.AspNetCore.Components.Web
                typeof(WebAssemblyHostBuilder).Assembly, // Microsoft.AspNetCore.Components.WebAssembly
            };
           
            HashSet<string?> referenceAssemblyNames = referenceAssemblyRoots
                .SelectMany(a => a.GetReferencedAssemblies().Concat(new[] { a.GetName() }))
                .Select(an => an.Name)
                .ToHashSet();

            if (referenceAssemblyNames == null)
            {
                return null;
            }
            var referenceAssembliesStreams = await this.GetReferenceAssembliesStreamsAsync(referenceAssemblyNames);

            var references = referenceAssembliesStreams
                .Select(s => MetadataReference.CreateFromStream(s, MetadataReferenceProperties.Assembly))
                .ToList();


            CSharpCompilation compilation = CSharpCompilation.Create(
                assemblyName,
                syntaxTrees: new[] { syntaxTree },
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                );

            using (var ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);

                if (!result.Success)
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError ||
                        diagnostic.Severity == DiagnosticSeverity.Error);
                    string error = string.Empty;
                    foreach (Diagnostic diagnostic in failures)
                    {
                        error += $"{diagnostic.Id} {diagnostic.GetMessage()}" + System.Environment.NewLine;
                    }
                    throw new Exception(error);
                }
                else
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    assembly = this.LoadFromStream(ms);
                }
            }
            return assembly;
        }


        private async Task<IEnumerable<Stream>> GetReferenceAssembliesStreamsAsync(IEnumerable<string?> referenceAssemblyNames)
        {
            var streams = new ConcurrentBag<Stream>();
            if (referenceAssemblyNames == null)
            {
                return streams;
            }

            await Task.WhenAll(
                referenceAssemblyNames.Select(async assemblyName =>
                {
                    var result = await client.GetAsync($"/_framework/{assemblyName}.dll");

                    result.EnsureSuccessStatusCode();

                    streams.Add(await result.Content.ReadAsStreamAsync());
                }));

            return streams;
        }

    }

}
