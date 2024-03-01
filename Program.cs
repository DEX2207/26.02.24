using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            double side3;
            bool a=true;
            List<Square> list = new List<Square>();
            List<Triangle> b = new List<Triangle>();
            List<Rectangle> c = new List<Rectangle>();
            List<Circle> d = new List<Circle>();
            while (a==true) 
            {
                Console.WriteLine("1. Ввод фигур\n2. Вывод данных о фигурах\n3. Добавить новые объекты классов\n4. Вывод списка объектов классов\n5. Удаление объекта класса\n6. Редактирование свойств объектов\n7. Выход");
                string number=Convert.ToString(Console.ReadLine());
                switch (number)
                {
                    case "1":
                        Console.Write("Введите название фигуры: ");
                        string name = Console.ReadLine();
                        switch (name)
                        {
                            case "Квадрат":
                                Console.Write("Введите сторону квадрата: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                Square square = new Square(side1, name);
                                list.Add(square);
                                square.Print();
                                break;
                            case "Треугольник":
                                Console.Write("Введите стороны треугольника: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                side2 = Convert.ToDouble(Console.ReadLine());
                                side3 = Convert.ToDouble(Console.ReadLine());
                                Triangle triangle = new Triangle(side1, side2, side3, name);
                                b.Add(triangle);
                                triangle.Print();
                                break;

                            case "Прямоугольник":
                                Console.Write("Введите стороны прямоугольника: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                side2 = Convert.ToDouble(Console.ReadLine());
                                Rectangle rectangle = new Rectangle(side1, side2, name);
                                c.Add(rectangle);
                                rectangle.Print();
                                break;
                            case "Круг":
                                Console.Write("Введите радиус: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                Circle circle = new Circle(side1, name);
                                d.Add(circle);
                                circle.Print();
                                break;
                            default:
                                Console.WriteLine("Неизвестная фигура");
                                break;
                        }
                    break;
                    case "2":
                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i].Print();
                        }
                        for (int i = 0; i < b.Count; i++)
                        {
                            b[i].Print();
                        }
                        for (int i = 0; i < c.Count; i++)
                        {
                            c[i].Print();
                        }
                        for (int i = 0; i < d.Count; i++)
                        {
                            d[i].Print();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите класс объекта: ");
                        string clas=Console.ReadLine();
                        switch (clas)
                        {
                            case "Квадрат":
                                list.Add(new Square("Квадрат"));
                                break;
                            case "Треугольник":
                                b.Add(new Triangle("Треугольник"));
                                break;

                            case "Прямоугольник":
                                c.Add(new Rectangle("Прямоугольник"));
                                break;
                            case "Круг":
                                d.Add(new Circle("Круг"));
                                break;
                        }
                        break;
                    case "4":
                        for(int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine($"list[{i}]");
                        }
                        for (int i = 0; i < b.Count; i++)
                        {
                            Console.WriteLine($"b[{i}]");
                        }
                        for (int i = 0; i < c.Count; i++)
                        {
                            Console.WriteLine($"c[{i}]");
                        }
                        for (int i = 0; i < d.Count; i++)
                        {
                            Console.WriteLine($"d[{i}]");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Введите класс объекта: ");
                        clas = Console.ReadLine();
                        switch (clas)
                        {
                            case "Квадрат":
                                Console.WriteLine("Введите номер объекта: ");
                                int index = Convert.ToInt32(Console.ReadLine());
                                list.RemoveAt(index);
                                break;
                            case "Треугольник":
                                Console.WriteLine("Введите номер объекта: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                b.RemoveAt(index);
                                break;

                            case "Прямоугольник":
                                Console.WriteLine("Введите номер объекта: ");
                                 index = Convert.ToInt32(Console.ReadLine());
                                c.RemoveAt(index);
                                break;
                            case "Круг":
                                Console.WriteLine("Введите номер объекта: ");
                                 index = Convert.ToInt32(Console.ReadLine());
                                d.RemoveAt(index);
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Введите класс объекта: ");
                        clas = Console.ReadLine();
                        switch (clas)
                        {
                            case "Квадрат":
                                Console.WriteLine("Введите номер объекта: ");
                                int index = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите сторону квадрата: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                list[index] = new Square(side1,"Квадрат");
                                break;
                            case "Треугольник":
                                Console.WriteLine("Введите номер объекта: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите стороны треугольника: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                side2 = Convert.ToDouble(Console.ReadLine());
                                side3 = Convert.ToDouble(Console.ReadLine());
                                b[index]=new Triangle(side1,side2,side3,"Треугольник");
                                break;
                            case "Прямоугольник":
                                Console.WriteLine("Введите номер объекта: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите стороны прямоугольника: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                side2 = Convert.ToDouble(Console.ReadLine());
                                c[index] = new Rectangle(side1, side2, "Прямоугольник");
                                break;
                            case "Круг":
                                Console.WriteLine("Введите номер объекта: ");
                                index = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите радиус: ");
                                side1 = Convert.ToDouble(Console.ReadLine());
                                d[index] = new Circle(side1,"Круг");
                                break;
                        }
                        break;
                    case "7":
                        a = false;
                    break;
                    default:
                        break;
                }
                
            }
         
        }
    }
}
