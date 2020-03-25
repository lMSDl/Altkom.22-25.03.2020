using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person();
            person.Name = "Jan Janowski";
            person.BirthDate = new DateTime(1967, 2, 3);

            var caretaker = new GenericCaretaker<Person>(person);

            Console.WriteLine(person);
            caretaker.SaveState();
            Console.ReadLine();

            person.Name = "ala";
            Console.WriteLine(person);
            caretaker.SaveState();
            Console.ReadLine();

            person.Name = "Ala Alowska";
            Console.WriteLine(person);
            caretaker.SaveState();
            Console.ReadLine();

            /*var json = caretaker.Serialize();
            caretaker.ShowHistory();
            caretaker.Deserialize(json);*/

            caretaker.ShowHistory();



            caretaker.Undo(DateTime.Now);
            Console.WriteLine(person);


            caretaker.Undo();
            Console.WriteLine(person);
        }
    }
}
