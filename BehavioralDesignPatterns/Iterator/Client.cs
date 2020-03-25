using BehavioralDesignPatterns.ChainOfResponsibility;
using BehavioralDesignPatterns.Command;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var strings = new List<string> { "a", "b", "c", "d", "e" };

            var buffer = strings[0];
            for (int i = 1; i < strings.Count; i++)
            {
                Console.WriteLine(buffer + strings[i]);
                buffer = strings[i];
            }

            var bufferCollection = new Buffer<string>(strings);
            foreach (var item in bufferCollection)
            {
                Console.WriteLine(item[0] + item[1]);
            }


        }
    }
}
