using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Part_3  // Определить, является ли введённое пользователем число чётным
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num;

            System.Console.WriteLine("Привет! Если напишешь число и оно окажется четным - ты выиграл, нечетным - проиграл. Погнали!!!");
            Num = Convert.ToInt32(System.Console.ReadLine());

            if (Num % 2 == 0)
            
            {
                Console.WriteLine($"Поздравляю, ты выиграл! Число {Num} является четным числом");
                Console.WriteLine("Надеюсь еще увидимся, везунчик!");
            }

            else
            
            {
                Console.WriteLine($"Прости, но ты проиграл... Число {Num} является нечетным числом");
                Console.WriteLine("Прощай, неудачник!");

            }
          
           
           
        }
    }
}
