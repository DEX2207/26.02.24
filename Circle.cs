using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Circle:Figure
    {
        private double side1;

        public Circle(string name) : base(name) { }
        public Circle(double side1, string name) : base(name)
        {
            this.side1 = side1;
        }
        public double Side1 { get => side1; set => side1 = value; }
        public override double Area()
        {
            return Math.PI * Math.Pow(side1, 2) ;
        }
        public override double Perimeter()
        {
            return side1* 2*Math.PI;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус={side1}");
            Console.WriteLine($"Периметр={Perimeter()}");
            Console.WriteLine($"Площадь={Area()}");
        }
    }
}
