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
}
