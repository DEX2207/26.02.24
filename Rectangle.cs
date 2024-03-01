using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Rectangle:Figure
    {
        private double side1;
        private double side2;

        public Rectangle(string name) : base(name) { }
        public Rectangle(double side1,double side2,string name): base (name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public override double Area()
        {
            return side1 * side2;
        }
        public override double Perimeter()
        {
            return side1*2 +side2*2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{side1}\t{side2}");
            Console.WriteLine($"Периметр={Perimeter()}");
            Console.WriteLine($"Площадь={Area()}");
        }
    }
}
