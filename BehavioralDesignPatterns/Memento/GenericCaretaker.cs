using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Memento
{
    public class GenericCaretaker<T> where T : ICloneable, IRestorable<T>
    {
        private List<IMemento<T>> Mementos { get; set; } = new List<IMemento<T>>();

        private T _originator;

       /* public string Serialize()
        {
            return JsonConvert.SerializeObject(Mementos);
        }

        public void Deserialize(string json)
        {
            Mementos = JsonConvert.DeserializeObject<List<Memento<T>>>(json);
        }*/

        public GenericCaretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            Console.WriteLine("Caretaker: Saving state");
            Mementos.Add(new Memento<T>((T)_originator.Clone()));
        }

        public void Undo()
        {
            Undo(DateTime.Now);
        }

        public void Undo(DateTime dateTime)
        {
            if (!Mementos.Any())
                return;

            var memento = Mementos.OrderByDescending(x => x.DateTime).FirstOrDefault(x => x.DateTime <= dateTime);
            if (memento == null)
                memento = Mementos.First();

            Mementos.RemoveAll(x => x.DateTime > dateTime);

            Console.WriteLine($"Caretaker: Restoring state to: {memento.DateTime}");
            _originator.Restore(memento.State);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: ");
            foreach (var item in Mementos)
            {
                Console.WriteLine(item.DateTime);
            }
        }
    }
}
