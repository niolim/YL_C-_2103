using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Lesson_5_Part_3 // Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

{[Serializable]
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольные числа через пробел от 0 до 255");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), numbers);
            Console.WriteLine("Введеные вами данные успешно сохранены");
            Console.ReadKey();
            
            // Если честно, не знаю, правильно ли я сделал это задание, так как не смог проверить бинарный код из файла 
            // Значения в файле вроде бы меняются. но что они значат, вообще без понятия. 
            
            

            
        }
    }
}
