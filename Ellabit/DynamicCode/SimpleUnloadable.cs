using System;
namespace Ellabit.DynamicCode
{
    public class SimpleUnloadable
    {
        HttpClient client;
        public SimpleUnloadable(HttpClient httpClient)
        {
            client = httpClient;
            Context = new SimpleUnloadableAssemblyLoadContext(client);
        }
        public SimpleUnloadableAssemblyLoadContext Context { get; set; } 
    }
}
