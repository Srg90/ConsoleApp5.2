using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список из 15 случайных чисел от 0 до 50");
            Console.WriteLine();
            const int N = 15;
            int[] number = new int[N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {

               number[i] = random.Next(0, 50);
               Console.Write("{0} ", number[i]);
               
            }
            int max = number[0];
            foreach (int a in number)
            {
                if (a > max)
                    max = a;
            }
            int min = number[0];
            foreach (int b in number)
            {
             if (b < min)
                min = b;
            }

            int sum = max + min;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Наибольшее значение {0}", max);
            Console.WriteLine();
            Console.WriteLine("Наименьшее значение {0}", min);
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального значения {0}", sum);
            Console.ReadKey();
        }
        
    }
    
}
