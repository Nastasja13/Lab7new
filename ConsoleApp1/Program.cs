using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

            Console.WriteLine("Введите длину ребра куба");
            Console.Write("Длина ребра куба: ");
            int ribLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            double S, V;

            GetParam(ribLength, out S, out V);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }

        static void GetParam(int ribLength, out double S, out double V)
        {
            //Найти площадь S = 6 ⋅ a^2
            S = 6 * Math.Pow(ribLength, 2);
            Console.Write("Площадь: {0}", S);
            Console.WriteLine();
            //Определить объем
            V = Math.Pow(ribLength, 3);
            Console.Write("Объем: {0}", V);
            Console.WriteLine();
        }
    }
}
