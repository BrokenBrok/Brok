using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_по_программированию__1__2_и_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1 (A. Поход в кино)

            int N = int.Parse(Console.ReadLine()); // Кол-во ребят
            int F = 0;

            // Мне не удалось реализовать ввод чисел в одной строке
            for (int i = 0; i < N; i++)
            {
                int y = int.Parse(Console.ReadLine());  // Кол-во денег у 1 ребенка
                F += y;
            }

            int P = int.Parse(Console.ReadLine()); // Цена 1-го билета

            int sum = N * P;
            Console.WriteLine(F - sum);



            Console.ReadKey();

        }
    }
}
