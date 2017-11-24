using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
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
