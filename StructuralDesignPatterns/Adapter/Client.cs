using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StructuralDesignPatterns.Adapter
{
    public class Client
    {
        public static void Execute()
        {
            var dbPerson = new PersonDb()
            {
                FirstName = "Adam",
                LastName = "Adamski",
                BirthDate = new DateTime(1967, 2, 4)
            };

            Console.WriteLine(JsonConvert.SerializeObject(dbPerson));

            new PersonToStringAdapter(new ToString()).ToJson(dbPerson);
        }
    }

    public class ToString
    {
        public void ToJson(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
