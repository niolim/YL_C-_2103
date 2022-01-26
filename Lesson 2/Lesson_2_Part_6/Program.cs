using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Part_6
    /*
     * Для полного закрепления битовых масок, попытайтесь создать универсальную структуру
       расписания недели, к примеру, чтобы описать работу какого либо офиса. Явный пример -
       офис номер 1 работает со вторника до пятницы, офис номер 2 работает с понедельника до
       воскресенья и выведите его на экран консоли.
    */

{
    internal class Program
    {
        [Flags]
        public enum Days
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }

        static void Main(string[] args)
        {
            Days Office1 = (Days)0b_00111100;
            Days Office2 = (Days)0b_1111111;
            Days Office3 = (Days)0b_0011111;
            Days Office4 = (Days)0b_1111100;
            Days Office5 = (Days)0b_1010101;

            Console.WriteLine("Здравствуйте в каком из 5 офисов вы работаете? Укажите пожалуйста порядковый номер офиса.");
            int OfficeNumber = Convert.ToInt32(Console.ReadLine());

            if (OfficeNumber == 1)
            {
                Console.Clear();
                Console.WriteLine($"Расписание рабочих дней для сотрудников первого офиса следующее: {Office1}.");
                Console.WriteLine();
            }
            else if (OfficeNumber == 2)
            {
                Console.Clear();
                Console.WriteLine($"Расписание рабочих дней для сотрудников второго офиса следующее: {Office2}.");
                Console.WriteLine();
            }
            else if (OfficeNumber == 3)
            {
                Console.Clear();
                Console.WriteLine($"Расписание рабочих дней для сотрудников третьего офиса следующее: {Office3}.");
                Console.WriteLine();
            }
            else if (OfficeNumber == 4)
            {
                Console.Clear();
                Console.WriteLine($"Расписание рабочих дней для сотрудников четвертого офиса следующее: {Office4}.");
                Console.WriteLine();
            }
            else if (OfficeNumber == 5)
            {
                Console.Clear();
                Console.WriteLine($"Расписание рабочих дней для сотрудников пятого офиса следующее: {Office5}.");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Простите, но в нашем здании нет такого офиса.");
                Console.WriteLine();
            }
        }
    }
}
