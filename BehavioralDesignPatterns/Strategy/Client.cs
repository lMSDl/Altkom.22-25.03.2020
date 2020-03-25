using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calculator  = new Calculator();

            while(true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetCalcStrategy(split[1]);

                if(float.TryParse(split[0], out float val1) && float.TryParse(split[2], out float val2))
                {
                    //var result = calculator.Operate(val1, val2);
                    var result = GetCalcFunc(split[1]).Invoke(val1, val2);
                    Console.WriteLine(result);
                }
            }

        }

        private static ICalcStrategy GetCalcStrategy(string v)
        {
            switch(v)
            {
                case "*":
                    return new MultiplyCalcStragegy();
                case "/":
                    return new DivideCalcStragegy();
                case "+":
                    return new PlusCalcStragegy();
                case "-":
                    return new MinusCalcStragegy();
            }
            return null;
        }

        public static Func<float, float, float> GetCalcFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (val1, val2) => val1 * val2;
                case "/":
                    return (val1, val2) => val1 / val2;
                case "+":
                    return (val1, val2) => val1 + val2;
                case "-":
                    return (val1, val2) => val1 - val2;
                default:
                    return null;
            }
        }
    }
}
