using System;

namespace SOLID
{
    interface IExcelFormatter
    {
        void ToExcel();
    }

    interface IPdfFormatter
    {
        void ToPdf();
    }

    class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }
}
