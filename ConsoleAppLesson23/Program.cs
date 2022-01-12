using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppLesson23
{
    internal class Program
    {
        static void Factorial(int x) // ulong
        {
            ulong count = (ulong)x;
            ulong factorial = 1;
            while (count > 0)
            {
                Console.WriteLine("{0} __ {1}", count, factorial);
                factorial = factorial * count;
                Thread.Sleep(50);
                count--;
            }
            Console.WriteLine("ОТВЕЕЕТ : {0}! = {1}", x, factorial);
        }
        static async void FactorialAsync(int x)
        {
            Console.WriteLine("FactorialAsync с аргументом {0} НАЧАЛ РАБОТУ", x);
            await Task.Run(() => Factorial(x));
            Thread.Sleep(1000);
            Console.WriteLine("FactorialAsync с аргументом {0} РАБОТУ ЗАВЕРШИЛ", x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое исходное большее 0 целое число : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            if (x1 <= 0) 
            {
                Console.WriteLine(" Недопустимое хначение !");
                Thread.Sleep(1500);
                return; 
            }
            Console.WriteLine("Введите второе исходное большее 0 целое число : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            if (x2 <= 0) 
            {
                Console.WriteLine(" Недопустимое хначение !");
                Thread.Sleep(1500);
                return; 
            }

            FactorialAsync(x1);
            FactorialAsync(x2);

            // Factorial(6);
            Console.WriteLine("MAIN РАБОТУ ЗАВЕРШИЛ");
            Console.ReadKey();
        }
    }
}
