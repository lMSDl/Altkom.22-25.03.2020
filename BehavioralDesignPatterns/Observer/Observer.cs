using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        private IDisposable _subscription;

        public void Subscribe(IObservable<T> stream)
        {
            if (_subscription == null)
                _subscription = stream.Subscribe(this);
        }

        public void Unsubscribe()
        {
            _subscription?.Dispose();
            _subscription = null;
        }

        public void OnCompleted()
        {
            Console.WriteLine("Observer: Transmission completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Observer: " + error.Message);
        }

        public abstract void OnNext(T value);
    }
}
