﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Original_Code
    /*
      1. Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
      декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать
      приложение.
      2. (*) выполнить задание 1, используя вместо dotPeek инструменты ildasm/ilasm.
    */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, avarage;

            Console.Write("Enter 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            avarage = (number1 + number2 + number3) / 3;

            Console.Write("Avarage of three numbers is {0}", avarage);

            Console.ReadKey();
        }
    }
}
