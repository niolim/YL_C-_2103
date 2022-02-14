using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Part_3

    /*
     * Написать метод по определению времени года. На вход подаётся число – порядковый номер
       месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
       Autumn. Написать метод, принимающий на вход значение из этого перечисления и
       возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
       ввести с клавиатуры номер месяца и вывести название времени года. Если введено
       некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
     */

{ // По факту единственное задание, которое не доставило особых проблем при его выполнении. 
    internal class Program
    {
        enum newType_Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            None
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца, время года которого вы хотите выяснить: ");
            int month = Int32.Parse(Console.ReadLine());
            newType_Seasons nameOfSeasonsInEnglish = timeOfYearInEnglish(month);
            string outputResult = typeTimeOfYearInRussian(nameOfSeasonsInEnglish);
            Console.WriteLine();
            
            Console.WriteLine($"Время года которое вы запросили - {outputResult}");
            Console.ReadKey();
        }
        static newType_Seasons timeOfYearInEnglish(int Month)
        {

            switch (Month)
            {
                case 1:
                case 2:
                case 12:
                    return newType_Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return newType_Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return newType_Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return newType_Seasons.Autumn;
                    default:
                    Console.WriteLine();
                    Console.WriteLine("Ошибка # 743: введите число в диапазоне чисел от 1 до 12");
                    break;
            }
            return newType_Seasons.None;
        }
        static string typeTimeOfYearInRussian(newType_Seasons nameOfSeasonsInEnglish)
        {
            switch (nameOfSeasonsInEnglish)
            {
                case newType_Seasons.Winter:
                    {
                        return "Зима.";
                    }
                case newType_Seasons.Spring:
                    {
                        return "Весна.";
                    }
                case newType_Seasons.Summer:
                    {
                        return "Лето.";
                    }
                case newType_Seasons.Autumn:
                    {
                        return "Осень.";
                    }
                default:
                    {
                        return "не найдено. Обратите внимание на Ошибку # 743.";
                    }
            }
        }
       
    }
}
