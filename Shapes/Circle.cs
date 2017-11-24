using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
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
}
