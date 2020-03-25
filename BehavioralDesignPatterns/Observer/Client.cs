using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class Client
    {
        public static void Execute()
        {
            var emiter = new Subject();

            var receiver = new ObserverA();
            var receiver2 = new ObserverB();

            receiver.Subscribe(emiter);
            receiver2.Subscribe(emiter);

            emiter.Index = new Random().Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            receiver2.Unsubscribe();
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = new Random(emiter.Index).Next(-1, 10);
            emiter.Index = -1;

        }
    }
}
