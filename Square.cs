using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Square:Figure
    {
        private double side1;

        public Square(string name):base(name) { }
        public Square(double side1, string name) : base(name)
        {
            this.side1 = side1;
        }
        public double Side1 { get => side1; set => side1 = value; }
        public override double Area()
        {
            return side1 * side1;
        }
        public override double Perimeter()
        {
            return side1* 4;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона квадрата={side1}");
            Console.WriteLine($"Периметр={Perimeter()}");
            Console.WriteLine($"Площадь={Area()}");
        }
    }
}
