using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command
{
    public class Garden
    {
        public int Size { get; }
        private ICollection<string> Plants { get; } = new List<string>();

        public Garden(int size)
        {
            Size = size;
        }

        public bool Plant(string name)
        {
            if(Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"{name} has been planted");
                return true;
            }
            else
            {
                Console.WriteLine("Not enough space in garden");
                return false;
            }
        }

        public bool Remove(string name)
        {
            if(Plants.Any(x => x == name))
            {
                Plants.Remove(name);
                Console.WriteLine($"{name} has been removed");
                return true;
            }
            else
            {
                Console.WriteLine($"There is no {name} in garden");
                return false;
            }
        }

        public override string ToString()
        {
            return $"There is {Plants.Count} plants in the garden";
        }
    }
}
