using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton
{
    class Context
    {

        private Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Initializing singleton object");

            var elements = File.ReadAllLines($"Singleton{Path.DirectorySeparatorChar}settings.txt");
            for (int i = 0; i < elements.Length; i+=2)
            {
                _settings.Add(elements[i], elements[i + 1]);
            }
        }

        public string Get(string property)
        {
            return _settings[property];
        }

        public static Context Instance { get; } = new Context();

        //private static Context _instance;
        //private static object locker = new object();
        //public static Context Instance
        //{
        //    get
        //    {
        //        lock (locker)
        //        {
        //            if (_instance == null)
        //                _instance = new Context();
        //        }
        //        return _instance;
        //    }
        //}
    }
}
