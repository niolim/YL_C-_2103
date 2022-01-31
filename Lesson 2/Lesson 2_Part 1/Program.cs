using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Part_1                   //  Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Здравствуйте, пожалуйста представьтесь"); 
            System.String Name = Console.ReadLine();
            System.Console.Clear();
                        
            System.Console.WriteLine($"{Name}, пожалуйста введите минимальную температуру на улице за сегодняшний день");
            System.String minTemp = Console.ReadLine();
            int a = Convert.ToInt32(minTemp); 
            System.Console.Clear();

            System.Console.WriteLine($"{Name}, а теперь, пожалуйста, введите максимальную температуру на улице за сегодняшний день");
            System.String maxTemp = Console.ReadLine();
            int b = Convert.ToInt32(maxTemp);
            System.Console.Clear();

            int averageTemp = (a + b) / 2;

            System.Console.WriteLine($"{Name}, средний показатель температуры на улице за сегодняшний день равен {averageTemp}");
            System.Console.WriteLine();


            /*
             * Еще один вариант задания, более чистый код
            int minTemp;
            int maxTemp;
            
            System.Console.WriteLine("Здравствуйте, пожалуйста представьтесь");
            System.String Name = Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine($"{Name}, пожалуйста введите минимальную температуру на улице за сегодняшний день");
            minTemp = Convert.ToInt32(Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine($"{Name}, а теперь, пожалуйста, введите максимальную температуру на улице за сегодняшний день");
            maxTemp = Convert.ToInt32(Console.ReadLine());
            System.Console.Clear();

            int averageTemp = (minTemp + maxTemp) / 2;

            System.Console.WriteLine($"{Name}, средний показатель температуры на улице за сегодняшний день равен {averageTemp}");
            System.Console.WriteLine();

            */    


        }
    }
}
