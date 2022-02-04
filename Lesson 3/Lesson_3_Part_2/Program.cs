using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Part_2 
/* Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
список телефонных контактов: первый элемент хранит имя контакта, второй — номер
телефона/e-mail
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] PhoneBook = new string[5, 2];

            Console.WriteLine("Введите пожалуйста Имя 1го абонента");
            string name1 = Console.ReadLine();
            PhoneBook[0, 0] = name1;
            Console.WriteLine($"Введите номер телефона для абонента {name1}");
            string number1 = Console.ReadLine();
            PhoneBook[0, 1] = number1;


            Console.Clear();

            Console.WriteLine("Введите пожалуйста Имя 2го абонента");
            string name2 = Console.ReadLine();
            PhoneBook[1, 0] = name2;
            Console.WriteLine($"Введите номер телефона для абонента {name2}");
            string number2 = Console.ReadLine();
            PhoneBook[1, 1] = number2;


            Console.Clear();

            Console.WriteLine("Введите пожалуйста Имя 3го абонента");
            string name3 = Console.ReadLine();
            PhoneBook[2, 0] = name3;
            Console.WriteLine($"Введите номер телефона для абонента {name3}");
            string number3 = Console.ReadLine();
            PhoneBook[2, 1] = number3;


            Console.Clear();

            Console.WriteLine("Введите пожалуйста Имя 4го абонента");
            string name4 = Console.ReadLine();
            PhoneBook[3, 0] = name4;
            Console.WriteLine($"Введите номер телефона для абонента {name4}");
            string number4 = Console.ReadLine();
            PhoneBook[3, 1] = number4;


            Console.Clear();

            Console.WriteLine("Введите пожалуйста Имя 5го абонента");
            string name5 = Console.ReadLine();
            PhoneBook[4, 0] = name5;
            Console.WriteLine($"Введите номер телефона для абонента {name5}");
            string number5 = Console.ReadLine();
            PhoneBook[4, 1] = number5;


            Console.Clear();



            Console.WriteLine("Телефонный справчоник");
            Console.WriteLine();
            for (int y = 0; y < PhoneBook.GetLength(0); y++)
            {
                for (int x = 0; x < PhoneBook.GetLength(1); x++)
                {
                    Console.WriteLine(PhoneBook[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    } // По правде сказать, вообще не понял, как иначе можно было выполнить данное задание, поэтому получилось так топорно на мой взгляд. 
}
