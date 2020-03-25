using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public int Index { get => index; set { index = value; Notify(); } }


        public void Notify()
        {
            if (Index == -1)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException()));
            else
                _observers.ToList().ForEach(x => x.OnNext(Index));
        }

        public void Dispose()
        {
            var observers = _observers.ToList();
            _observers = null;
            observers.ForEach(x => x.OnCompleted());
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (_observers == null)
                return null;
            _observers.Add(observer);
            return new Unsubscribe<int>(_observers, observer);
        }
    }
}
