using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Triangle:Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(string name):base(name){ }
        public Triangle(double side1, double side2, double side3, string name) : base(name)
        {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
        }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }

        public override double Area()
        {
            double P = side1 + side2 + side3;
            double p = P / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
        public override double Perimeter()
        {
           return side1 + side2 + side3;
        }
        public override void Print()
        {
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2))
            {
                base.Print();
                Console.WriteLine($"Стороны={side1}\t{side2}\t{side3}");
                Console.WriteLine($"Периметр={Perimeter()}");
                Console.WriteLine($"Площадь={Area()}");
            }
            else
            {
                Console.WriteLine("Ваш треугольник не существует");
            }
        }
    }
}
