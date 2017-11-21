using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static Random rand = new Random();                                                      //обьект который будет отвечать за рандомную генерацию чисел,в случае выбора цвета или кол-ва созданных фигур
        static List<Shapes> main_array=new List<Shapes>();                                      //главный массив обьектов дочерних классов класса "Shapes"

        static void CreateArray()                                             //Метод в котором будет рандомно заполняться массив обьектов класса "Shapes"
        {
            List<string> Colors = new List<string>(2) { "Black", "White", "Red", "Yellow", "Gray", "Green" };                  //массив цветов, для того чтобы рандомно давать фигурам цвета.
            string this_color;                                                                                             //переменная,которая указывает на то, какой цвет будет сгенерирован для следующей добавленой фигуры

            for (int i=0;i<4;i++)                                               //делаем 4 круга внешнего цикла, чтобы пробежаться по всех дочерних классах класса "Shapes"  
            {
                for(int j=0;j<rand.Next(1,8);j++)                               //и от 1 до 7 кругов внутреннего цикла. Для того чтобы создать от 1 до 7 элементов и добавить их в главный массив 
                {
                    this_color = Colors[rand.Next(0, Colors.Count)];

                    switch (i)                                                  //в зависимости от того, на какой итерации находится внешний цикл, решается то, какого класса обьект(ы) будут создаваться
                    {
                        case 0:                                                 //создается экземпляр класса "Квадрат" и добавляется в главный массив
                            {
                                main_array.Add(new Square(rand.Next(1,10),this_color));
                                break;
                            }
                        case 1:                                                 //экз. класса "Треугольник"
                            {
                                main_array.Add(new Triangle(rand.Next(1,9),rand.Next(1,9),this_color));
                                break;
                            }
                        case 2:                                                     //экз. класса "Круг"
                            {
                                main_array.Add(new Circle(rand.Next(1,9)+rand.NextDouble(),this_color));
                                break;
                            }
                        case 3:                                                         //экз. класса "Трапеция"
                            {
                                main_array.Add(new Trapeze(rand.Next(1, 9), rand.Next(1, 5), rand.Next(5, 9), this_color));
                                break;
                            }
                    }
                }
            }
        }

        static void Draw()                              //метод, который показывает информацию о всех элементах массива main_array
        {
            foreach(var shape in main_array)
            {
                shape.Show();
            }
        }

        static void Main(string[] args)
        {
            CreateArray();                              //Заполняем главный массив обьектами
            Draw();                                     //показывает информацию о всех элементах массива main_array
        }
    }
}
