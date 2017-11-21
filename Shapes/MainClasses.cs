using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shapes                                                                                //класс "Квадрат"
    {
        double side_length;                                                                                 //размер стороны
        static int quality_of_squares = 0;                                                               //переменная для подсчета кол-ва фигур данного типа

        public Square(int _side_length, string _color)
        {
            SetId();
            Name = "Square";
            side_length = _side_length;
            Square = side_length * side_length;
            Perimeter = side_length * 4;
            GSColor = _color;
        }

        public double Side_length { set { side_length = value; } get { return side_length; } }
        public double GetDiagonal { get { return Math.Sqrt(Math.Pow(side_length, 2) * 1.0 * 2); } }   //возвращает диагональ квадрата


        public override void Show()                                                              //вывод информации о фигуре данного типа
        {
            base.Show();
            Console.WriteLine("Side Length: " + Side_length + "\nDiagonal: " + GetDiagonal + '\n' + new string('_', 25));
        }

        public override void SetId()
        {
            Id = ++quality_of_squares;
        }
    }


    class Triangle : Shapes                                                                           //класс "Триугольник"
    {
        double first_s_length;                                                                      //размер первого катэта
        double second_s_length;                                                                     //размер второго катэта
        double hypotenuse;                                                                          //размер гипотен.
        static int quality_of_triangles = 0;                                                        //переменная для подсчета кол-ва фигур данного типа

        public Triangle(double _first_s_length, double _second_s_length, string _color)
        {
            SetId();
            first_s_length = _first_s_length;
            second_s_length = _second_s_length;
            hypotenuse = Math.Sqrt(Math.Pow(first_s_length, 2) + Math.Pow(second_s_length, 2));         //ищем гипотенузу
            Name = "Triangle";
            Square = 0.5 * first_s_length * second_s_length;                                            //ищем площадь
            Perimeter = first_s_length + second_s_length + hypotenuse;                                  //ищем периметр
            GSColor = _color;
        }

        public override void Show()                                                              //вывод информации о фигуре данного типа
        {
            base.Show();
            Console.WriteLine("1 side length: " + First_s_length + "\n2 side length: " + Second_s_length + "\nHypotenuse length: " + GetHypotenuse() + "\nBisector: " + GetBisector() + '\n' + new string('_', 25));
        }

        public double First_s_length { get { return first_s_length; } set { first_s_length = value; } }     //свойства для доступа к полям класса

        public double Second_s_length { get { return second_s_length; } set { second_s_length = value; } }

        public double GetHypotenuse()                                                                   //метод возвращающий гипотенузу
        {
            return hypotenuse;
        }

        public override void SetId()
        {
            Id = ++quality_of_triangles;
        }

        public double GetBisector()                                                                     //метод возвращает биссектрису прямого угла
        {
            return Math.Sqrt(2) * (First_s_length * Second_s_length) / (First_s_length + Second_s_length);
        }
    }


    class Circle : Shapes
    {
        double radius;
        static int quality_of_circles = 0;                                                          //кол-во созданных кругов

        public Circle(double _radius, string _color)
        {
            SetId();
            radius = _radius;
            Name = "Circle";
            Square = Math.PI * Math.Pow(radius, 2);                                            //ищем площадь
            Perimeter = Math.PI * this.GetDiametr();                                        //ищем периметр
            GSColor = _color;
        }

        public double GetDiametr()                                                          //метод, который возвращает диаметр
        {
            return radius * 2;
        }

        public double Radius { get { return radius; } set { radius = value; } }

        public override void SetId()
        {
            Id = ++quality_of_circles;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Radius: " + Radius + "\nDiametr: " + GetDiametr() + '\n' + new string('_', 25));
        }
    }

    class Trapeze : Shapes
    {
        static int quality_of_trapezes = 0;
        double height;                                                                           //высота трапеции
        double top_side;
        double bottom_side;                                                                      //верхняя и нижняя основы трапеции

        public Trapeze(double _height, double _top_side, double _bottom_side, string _color)
        {
            SetId();
            height = _height;                                                                           //высоту
            top_side = _top_side;
            bottom_side = _bottom_side;
            Name = "Trapeze";
            Square = height * GetMidLine();                                                      //ищем площадь
            Perimeter = top_side + bottom_side + GetSideLine() * 2;                                  //ищем периметр
            GSColor = _color;
        }

        public double GetMidLine()                                                             //метод,который возвращает среднюю линию трапеции
        {
            return (top_side + bottom_side) / 2;
        }

        public double GetSideLine()                                         //метод возвращает боковую линию, а так как трапеция у нас равнобедренная, то левая боковая линия == правой боковой линии
        {
            double cathete = (bottom_side - top_side) / 2;
            return Math.Sqrt(Math.Pow(cathete, 2) + Math.Pow(height, 2));
        }

        public double Height { get { return height; } set { height = value; } }     //свойства для доступу к полям класса

        public double TopSide { get { return top_side; } set { top_side = value; } }

        public double BottomSide { get { return bottom_side; } set { bottom_side = value; } }

        public override void SetId()
        {
            Id = ++quality_of_trapezes;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Top line: " + TopSide + "\nBottom line: " + BottomSide + "\nSide line: " + GetSideLine() + "\nHeight: " + Height + "\nMiddle line: " + GetMidLine() + '\n' + new string('_', 25));//вывод информации о фигуре данного типа
        }
    }
}
