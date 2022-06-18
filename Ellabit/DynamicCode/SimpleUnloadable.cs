using System;
namespace Ellabit.DynamicCode
{
    public class SimpleUnloadable
    {
        
        HttpClient client;
        public SimpleUnloadable(HttpClient client)
        {
            this.client = client;
            Context = new SimpleUnloadableAssemblyLoadContext(client);
        }
        public SimpleUnloadableAssemblyLoadContext Context { get; set; }


        public void ClearCache()
        {
            if (Context.Assemblies.Any())
            {
                Context.Dispose();
                Context.Unload();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
                        
            Context = new SimpleUnloadableAssemblyLoadContext(client);
        }
    }
}
