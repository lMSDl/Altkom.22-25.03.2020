using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade
{
    public class JsonSerializerSettingsFacade
    {
        private JsonSerializerSettings _jsonSerializerSettings;

        public JsonSerializerSettingsFacade()
        {
            _jsonSerializerSettings = new JsonSerializerSettings();
            _jsonSerializerSettings.DateFormatString = "yyy.MM.dd";
            _jsonSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;

        }

        public NullValueHandling NullValueHandling { get => _jsonSerializerSettings.NullValueHandling; set => _jsonSerializerSettings.NullValueHandling = value; }
        public ReferenceLoopHandling ReferenceLoopHandling { get => _jsonSerializerSettings.ReferenceLoopHandling; set => _jsonSerializerSettings.ReferenceLoopHandling = value; }
    }
}
