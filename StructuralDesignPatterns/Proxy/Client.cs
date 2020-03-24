using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            var database = new Database();
            var proxy = new DatabaseProxy(database);

            for(int i = 1; i < 21; i++)
            {
                _ = proxy.RequestAsync(i);
            }
        }
    }
}
