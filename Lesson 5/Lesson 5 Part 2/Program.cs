using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_Part_2 //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В каком городе вы сейчас находитесь?");
            string City = Console.ReadLine();
            File.AppendAllText("startup.txt", "Текущее время в городе " + City + " " + DateTime.Now.ToLongTimeString() + Environment.NewLine);
        }
    }
}
