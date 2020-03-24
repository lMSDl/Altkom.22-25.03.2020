using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StructuralDesignPatterns.Facade
{
    public class Client
    {
        public static void Execute()
        {
            var settings = new JsonSerializerSettingsFacade();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            Serialize(new object, settings);
        }

        public static void Serialize(object x, JsonSerializerSettingsFacade settings)
        {
            //...
        }
    }
}
