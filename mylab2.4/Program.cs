using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylab2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравнение чисел по количествву цифр");
            Console.WriteLine("Введите первое число");
            // введем первое число
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"{num1} больше");
            else
            {
                Console.WriteLine($"{num2} больше");
            }
            Console.ReadKey();
        }
    }
}
