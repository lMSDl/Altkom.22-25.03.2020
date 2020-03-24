using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Prototype
{
    public class Person : ICloneable
    {
        public Person()
        {

        }

        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }
        public Person Mother { get; set; }

        public ICollection<Person> Kids { get; set; } = new List<Person>();


        public object Clone()
        {
            var person = (Person)ShallowClone();
            person.IdInfo = (IdInfo)IdInfo?.Clone();
            person.Mother = (Person)Mother?.Clone();
            person.Kids = Kids.Select(x => x.Clone()).Cast<Person>().ToList();
            return person;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }

    public class IdInfo : ICloneable
    {
        public int IdNumber { get; }
        public string Metadata { set; get; }

        public IdInfo()
        {
            IdNumber = new Random().Next(1000, 100000);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
