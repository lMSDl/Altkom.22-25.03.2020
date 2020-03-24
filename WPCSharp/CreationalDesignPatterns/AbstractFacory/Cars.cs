using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFacory
{
    public class SkodaCompactSedan : ICar, ISedan
    {
        public string Name()
        {
            return nameof(SkodaCompactSedan);
        }
    }

    public class SkodaFullSedan : ICar, ISedan
    {
        public string Name()
        {
            return nameof(SkodaFullSedan);
        }
    }

    public class SkodaFullSuv : ICar, ISuv
    {
        public string Name()
        {
            return nameof(SkodaFullSuv);
        }
    }

    public class SkodaCompactSuv : ICar, ISuv
    {
        public string Name()
        {
            return nameof(SkodaCompactSuv);
        }
    }

    public class HondaCompactSedan : ICar, ISedan
    {
        public string Name()
        {
            return nameof(HondaCompactSedan);
        }
    }

    public class HondaFullSedan : ICar, ISedan
    {
        public string Name()
        {
            return nameof(HondaFullSedan);
        }
    }

    public class HondaFullSuv : ICar, ISuv
    {
        public string Name()
        {
            return nameof(HondaFullSuv);
        }
    }

    public class HondaCompactSuv : ICar, ISuv
    {
        public string Name()
        {
            return nameof(HondaCompactSuv);
        }
    }
}
