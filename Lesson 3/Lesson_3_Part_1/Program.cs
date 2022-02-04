using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Part_1 // Написать программу, выводящую элементы двухмерного массива по диагонали.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[,]
            {
               {12, 32, 54, 21 },
               {56, 87, 76, 33 },
               {80, 67, 58, 09 },
               {38, 82, 91, 27 },
            };
            int height = MyArray.GetLength(0);
            int width = MyArray.GetLength(1);

            Console.WriteLine("Массив");
           
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(MyArray[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Данные по диагонали");

            for (int i=0,j=0; i<height && j<width; i++, j++)
            {
                Console.Write(MyArray [i,j] + "\t");
            }

        }
    }
}
