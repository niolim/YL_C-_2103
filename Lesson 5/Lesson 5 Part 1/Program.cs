using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_5_Part_1 //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введи пожалуйста текст, который вы хотите сохранить в файл:");
            string text = Console.ReadLine();
            File.WriteAllText("HomeWorkText.txt", text);
            Console.WriteLine("Ваш текст сохранен.");
            Console.ReadKey(); 
          
        }
    }
}
