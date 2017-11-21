using System;


namespace Shapes
{
    abstract class Shapes
    {
        string color;
        double square;
        double perimeter;
        string name;
        int id;

        protected string GSColor { set { color = value; } get { return color; } }           //Свойства для общих полей

        protected double Square { set { square = value; } get { return square; } }

        protected double Perimeter { set { perimeter = value; } get { return perimeter; } }

        protected string Name { set { name = value; } get { return name; } }

        protected int Id { get { return id; } set { id = value; } }

        public virtual void Show()                                                      //виртуальная функция, которую перегружаем в каждом из последующих классов
        {
            Console.WriteLine("Figure: " + Name + "\nId:" + Id + "\nColor: " + GSColor + "\nSquare: " + Square + "\nPerimeter: " + Perimeter);
        }

        public abstract void SetId();
    }
}
