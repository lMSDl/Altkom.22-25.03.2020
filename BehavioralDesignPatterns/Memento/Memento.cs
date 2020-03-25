using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Memento
{
    public class Memento<T> : IMemento<T>
    {
        public Memento(T state)
        {
            State = state;
            DateTime = DateTime.Now;
        }

        public T State { get; set; }

        public DateTime DateTime { get; set; }
    }
}
