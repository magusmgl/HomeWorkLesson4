using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson4
{
    public static class Cycle
    {

        public static void WriteNumberFrom5to1()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static int SumNumbersToUserNumber()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= num; i++)
            {
                result += i;
                Console.WriteLine(result);
            }
            return result;
        }


        public static void Print7()
        {
            int i = 0;
            while (i < 100)
            {
                i++;
                if (i % 7 == 0) Console.Write($"{i} ");
            }
        }

        public static void Print10NumbersFrom0()
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{res} ");
                res -= 5;
            }
        }

        public static void PrintPowNumbersFrom10To20()
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        
        }

    }
}
