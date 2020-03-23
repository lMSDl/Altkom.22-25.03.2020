using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var a = Context.Instance.Get("Address");

            Console.WriteLine(a);

            Console.WriteLine();
        }
    }
}
