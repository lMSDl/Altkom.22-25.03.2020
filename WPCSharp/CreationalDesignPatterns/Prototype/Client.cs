using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CreationalDesignPatterns.Prototype
{
    public class Client
    {
        public static Dictionary<string, JsonSerializerSettings> JsonSettings = new Dictionary<string, JsonSerializerSettings>();

        public static void Execute()
        {
            var mother = new Person()
            {
                Name = "Anna Annowska",
            };

            var person = new Person()
            {
                Name = "Daniel Danielski",
                BirthDate = new DateTime(1978, 2, 12),
                IdInfo = new IdInfo()
            };

            person.Mother = mother;
            //mother.Kids.Add(person);


            var personCopy = (Person)person.Clone();

            person.IdInfo.Metadata = "abc";
            person.Name = "Daniel Danielek";

            person = personCopy;



            var jsonSettings = new JsonSerializerSettingsClonable();
            jsonSettings.DateParseHandling = DateParseHandling.DateTimeOffset;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.NullValueHandling = NullValueHandling.Include;

            JsonSettings["FormattingIntendedDateTimeOffset"] = jsonSettings;
            jsonSettings = (JsonSerializerSettingsClonable)jsonSettings.Clone();
            jsonSettings.Formatting = Formatting.None;
            JsonSettings["FormattingNoneDateTimeOffset"] = jsonSettings;


        }

        public class JsonSerializerSettingsClonable : JsonSerializerSettings, ICloneable
        {
            public object Clone()
            {
                return MemberwiseClone();
            }
        }
    }
}
