using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату центра окружности Х0:\t");
            Circle.x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату центра окружности Y0:\t");
            Circle.y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату производльной точки Х:\t");
            Circle.x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату производльной точки Y:\t");
            Circle.y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности r:\t");
            Circle.R = Convert.ToDouble(Console.ReadLine());
            Circle.Lenght();
            Circle.Area();
            Circle.CheckPoint();
            Console.ReadKey(); 
        }

    }
    static class Circle
    {
        static double r;
        static public double x0;
        static public double y0;
        static public double x;
        static public double y;

        static public double R
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус не может быть отрицательным или равным нолю");
                }
                else
                {
                    r = value;
                }
            }
            get
            {
                return r;
            }
        }
        static public void Lenght()
        {
            double l = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности с указанным радиусом = {0}", l);  
        }
        static public void Area()
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга с указанным радиусом = {0}", s); 
        }
        static public void CheckPoint()
        {
            if (x<=(x0+r)&&x>=(x0-r)&&y<=(y0+r)&&y>=(y0-r))
            {
                Console.WriteLine("Точка с указанными координатами Х и У ПРИНАДЛЕЖИТ окружности с ранее введенными координатами центра Х0 и У0 и радиусом r");
            }
            else
            {
                Console.WriteLine("Точка с указанными координатами Х и У НЕ ПРИНАДЛЕЖИТ окружности с ранее введенными координатами центра Х0 и У0 и радиусом r");
            }
        }
    }
}
