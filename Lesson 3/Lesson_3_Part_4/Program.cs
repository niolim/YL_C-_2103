using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Part_4
    /*
 «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х —
элементы кораблей, а О — свободные клетки.
    */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] MyArray = new string[,]
            {
             {"X", "X", "X", "O", "O", "O", "O", "O", "O", "X"  },
             {"O", "O", "X", "O", "O", "O", "O", "O", "O", "O"  },
             {"O", "O", "O", "O", "O", "O", "O", "X", "X", "X"  },
             {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"  },
             {"O", "O", "O", "O", "X", "O", "O", "O", "O", "O"  },
             {"O", "O", "X", "O", "X", "O", "O", "O", "O", "O"  },
             {"X", "O", "X", "O", "X", "O", "O", "O", "O", "O"  },
             {"X", "O", "O", "O", "X", "O", "O", "O", "O", "O"  },
             {"X", "O", "O", "O", "O", "O", "O", "O", "O", "X"  },
             {"X", "X", "O", "O", "O", "O", "X", "O", "X", "X"  },


            };
            int height = MyArray.GetLength(0);
            int width = MyArray.GetLength(1);

            Console.WriteLine("Массив");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(MyArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        } /* Опять же не понял, как иначе сделать и опять топорно вышло, плюс еще не понимаю как таблицу,
           * которая появляется сделать плотнее, чтобы она выглядела более читабельной
           */
        

    }
}
