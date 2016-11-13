using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, i2=0, i3 = 0, i4 =0, i5 =0;
            Console.WriteLine("Сколько чисел в Массиве?");
            i = Convert.ToInt32(Console.ReadLine());
            while (i > 0) { i2++; Console.WriteLine("Введите элемент под номером : " + i2); i3 = Convert.ToInt32(Console.ReadLine()); if (i3 > 0) {Console.WriteLine("Число положительное"); i4 = i4+ i3; i5 ++;
            Console.WriteLine("Колличество положительных чисел : " + i5);
            }
            else { Console.WriteLine("Число отрицательное"); }
            i--;
            };
            Console.WriteLine("Среднее арефметическое всех положительных чисел : " + (i4/i5));
            Console.ReadLine();


        }
    }
}
