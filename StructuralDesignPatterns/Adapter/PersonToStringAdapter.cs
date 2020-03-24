using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class PersonToStringAdapter
    {
        private MapperConfiguration _mapperConfiguration;
        private ToString _service;

        public PersonToStringAdapter(ToString service)
        {
            _service = service;
            _mapperConfiguration = new MapperConfiguration(cfg =>
            cfg.CreateMap<PersonDb, Person>()
            .ForMember(x => x.Age, x => x.MapFrom(y => new DateTime((DateTime.Now - y.BirthDate).Ticks).Year))
            );
        }

        public void ToJson(PersonDb person)
        {
            //var servicePerson = new Person()
            //{
            //    FirstName = person.FirstName,
            //    LastName = person.LastName,
            //    Age = new DateTime((DateTime.Now - person.BirthDate).Ticks).Year
            //};

            var mapper = new Mapper(_mapperConfiguration);

            _service.ToJson(mapper.Map<Person>(person));
        }
    }
}
