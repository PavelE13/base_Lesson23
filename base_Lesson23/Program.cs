using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_Lesson23
{
    class Program
    {
        static void factorial(int n)
        {
            int fact = 1;
            //while (n > 1)
            for (int i=1; i<=n; i++)
            {
                
                fact *= i;
                Console.WriteLine("Факториал числа {0} равен {1}", i, fact);
            }
            //return fact;
        }
        static void summ(int n)
        {
            int calc = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Выполняется метод calc n*i*i!");
                calc += n*i*i;
                Console.WriteLine("Расчкт переменной от 1 до {0} равен {1}", i, calc);
            }
            Console.WriteLine("Метод calc n*i*i закончил работу!");
            //return summ;
        }
        static async void factorialAsync(int n)
        {
            Console.WriteLine("Выполняется метод factorialAsync!   ");
            await Task.Run(() => factorial(n));
            Console.WriteLine("Метод factorialAsync закончил работу!   ");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число для вычисления факториала > 0: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine(" Число не должно быть отрицательным!");
            }
            else
            {
                
                factorialAsync(n);
                summ(n);


            }
            Console.ReadKey();
        }
    }
}
