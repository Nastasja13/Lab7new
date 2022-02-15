using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Два треугольника заданы длинами своих сторон. 
            Определить, площадь какого из них больше
            (создать метод для вычисления  площади  треугольника по длинам его сторон).
            Для решения задачи можно использовать формулу Герона*/

            Console.WriteLine("Введите стороны первого треугольника");
            Console.Write("Катет 1: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Катет 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = Convert.ToInt32(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            Console.Write("Гипотинуза: {0}", z);
            Console.WriteLine();
            double p, S;

            GetParam(x, y, z, out p, out S);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Введите стороны второго треугольника");
            Console.Write("Катет 1: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Катет 2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int z2 = Convert.ToInt32(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));
            Console.Write("Гипотинуза: {0}", z2);
            Console.WriteLine();
            double p2, S2;

            GetParam2(x2, y2, z2, out p2, out S2);
            Console.WriteLine();
            Console.WriteLine();

            //Сравнение площадей
            if (S2 == S)
                Console.WriteLine("Площадь первого треугольника {0:f2} равна площади второго {1:f2}", S, S2);
            else if (S2 > S)
                Console.WriteLine("Площадь второго треугольника больше первого и равна {0:f2}", S2);
            else 
                Console.WriteLine("Площадь первого треугольника больше второго и равна {0:f2}", S);


            Console.ReadKey();
        }
        //Метод, рассчитывающий данные по треугольникам
        static void GetParam(int x, int y, int z, out double p, out double S)
        {
            //Найти полупериметр p = (a + b + c) : 2
            p = (x + y + z) / 2;
            Console.Write("Полупериметр первого треугольника: {0}", p);
            Console.WriteLine();
            //Определить площадь по формуле Герона
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            Console.Write("Площадь первого треугольника: {0:f2}", S);
            Console.WriteLine();
        }


        static void GetParam2(int x2, int y2, int z2, out double p2, out double S2)
        {
            //Найти полупериметр p = (a + b + c) : 2
            p2 = (x2 + y2 + z2) / 2;
            Console.Write("Полупериметр второго треугольника: {0}", p2);
            Console.WriteLine();
            //Определить площадь по формуле Герона
            S2 = Math.Sqrt(p2 * (p2 - x2) * (p2 - y2) * (p2 - z2));
            Console.Write("Площадь второго треугольника: {0:f2}", S2);
        }


    }

}

