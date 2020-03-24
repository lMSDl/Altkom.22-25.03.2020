using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFacory
{
    public interface ICarFactory
    {
        ICar CreateSedan(Segments segment);
        ICar CreateSuv(Segments segment);
    }
}
