using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
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
}
