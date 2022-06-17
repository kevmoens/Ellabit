using System;
namespace Ellabit.DynamicCode
{
    public class SimpleUnloadable
    {
        
        IServiceProvider serviceProvider;
        public SimpleUnloadable(IServiceProvider serviceProvider, SimpleUnloadableAssemblyLoadContext context)
        {
            this.serviceProvider = serviceProvider;
            Context = context;
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
                        
            Context = serviceProvider.GetRequiredService<SimpleUnloadableAssemblyLoadContext>();
        }
    }
}
