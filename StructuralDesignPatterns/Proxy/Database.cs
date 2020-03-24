using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy
{
    public class Database
    {
        public const int MaxConnections = 5;
        private int _connectionsCounter = 0;

        public async Task RequestAsync(int @int)
        {
            if(_connectionsCounter >= 5)
            {
                Console.WriteLine($"Request {@int} dropped!");
                return;
            }

            _connectionsCounter++;
            Console.WriteLine($"Opening connectino {_connectionsCounter}");

            await Task.Delay(1000);
            Console.WriteLine($"Request {@int} completed ({_connectionsCounter})");
            _connectionsCounter--;
        }
    }
}
