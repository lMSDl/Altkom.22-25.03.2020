using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFacory
{
    public class FactorySkoda : ICarFactory
    {
        public ICar CreateSedan(Segments segment)
        {
            switch (segment)
            {
                case Segments.Compact:
                    return new SkodaCompactSedan();
                case Segments.Full:
                    return new SkodaFullSedan();
            }
            return null;
        }

        public ICar CreateSuv(Segments segment)
        {
            switch (segment)
            {
                case Segments.Compact:
                    return new SkodaCompactSuv();
                case Segments.Full:
                    return new SkodaFullSuv();
            }
            return null;
        }
    }

    public class FactoryHonda : ICarFactory
    {
        public ICar CreateSedan(Segments segment)
        {
            switch (segment)
            {
                case Segments.Compact:
                    return new HondaCompactSedan();
                case Segments.Full:
                    return new HondaFullSedan();
            }
            return null;
        }

        public ICar CreateSuv(Segments segment)
        {
            switch (segment)
            {
                case Segments.Compact:
                    return new HondaCompactSuv();
                case Segments.Full:
                    return new HondaFullSuv();
            }
            return null;
        }
    }
}
