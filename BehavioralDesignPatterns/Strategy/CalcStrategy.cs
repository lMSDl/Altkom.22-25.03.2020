using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy
{
    public interface ICalcStrategy
    {
        float Calculate(float value1, float value2);
    }

    public class PlusCalcStragegy : ICalcStrategy
    {
        public float Calculate(float value1, float value2)
        {
            return value1 + value2;
        }
    }

    public class MinusCalcStragegy : ICalcStrategy
    {
        public float Calculate(float value1, float value2)
        {
            return value1 - value2;
        }
    }

    public class MultiplyCalcStragegy : ICalcStrategy
    {
        public float Calculate(float value1, float value2)
        {
            return value1 * value2;
        }
    }

    public class DivideCalcStragegy : ICalcStrategy
    {
        public float Calculate(float value1, float value2)
        {
            return value1 / value2;
        }
    }
}
