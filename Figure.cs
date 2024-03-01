using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print() 
        {
            Console.WriteLine($"Название фигуры: {name}");
            //Area();
            //Perimeter();
        }
    }
}
