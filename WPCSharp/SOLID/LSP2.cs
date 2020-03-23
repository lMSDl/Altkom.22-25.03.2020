using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Square : Rectangle
    {
        public override int A { set
            {
                base.A = base.B = value;
            }
        }
        public override int B
        {
            set
            {
                base.A = base.B = value;
            }
        }
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int Area()
        {
            return A * B;
        }
    }

    public class LSP
    {
        public static void Test(int a, int b)
        {
            Rectangle rectangle = new Square();
            rectangle.A = a;
            rectangle.B = b;

            Console.WriteLine($"{a} * {b} = {rectangle.Area()}");
        }
    }

}
