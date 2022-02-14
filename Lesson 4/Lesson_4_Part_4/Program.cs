using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Part_4
    // (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

{ // Сделано на основе данных из интернета.
    internal class Program
    {
        static void Main(string[] args)             
        {
            Console.WriteLine("Введите интересующее вас значение для вычисления числа Фибоначчи: ");
            Console.WriteLine("\tP.S.Учтите, что для вычисления числа значение которого больше 35 может потребоваться некоторое времяю.");
            int someValue = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int fib = Fibonachi(someValue);
            
            Console.WriteLine($"Число Фибоначчи для значения {someValue} = {fib}");
            Console.ReadKey();
           

        }

        static int Fibonachi(int i)
        {
            if (i == 0 || i == 1) return i;

            return Fibonachi(i - 1) + Fibonachi(i - 2);
        }

       
     

    
    }
}
