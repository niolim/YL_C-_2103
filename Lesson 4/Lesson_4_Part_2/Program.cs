using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Part_2
/*
 Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
 возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
 результат на экран
*/

    /*
     * Честно скажу, это какое то чудовище франкенштейна, собранное из всех уголков интернета, 
     * пытался сделать без сплитов, селектов и т.д, но не получается у меня по итогу выводить норм числа,
     * к примеру я вбиваю 45 он читает его не как 45, а как 4 и 5, и соответственно суммирует неправильно все.
     * несколько дней пытался понять как сделать это задание, но так и не понял. Надеюсь в будущем пойму.
     */



{
    internal class Program
    {
        // Сделано, но с использованием Linq
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите набор рандомных чисел через пробел, чтобы получить сумму этих чисел");
            int[] setOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // Данную строку нашел на просторах в инете, без нее вообще ничего бы не вышло
            int result = Sum(setOfNumbers);
            Console.Clear();
            Console.WriteLine($"Сумма введеных вами чисел = {result}");  
            Console.ReadKey();

        }

        static int Sum(int[] numbers, int i=0)
        {
            if (i>= numbers.Length)
                return 0;
            return numbers[i] + Sum(numbers, i +1);
        }

        /*  Вот тоже рабочая версия, без Linq, но есть проблема, данный код не распознает двузначные и более числа. Так и не понял как исправить это. 
         *  
         Console.WriteLine("Введите числа от 0 до 9 через пробел, чтобы получить сумму этих чисел");
            string numbers = Console.ReadLine();
            int result = 0;
            char [] symbol = new char[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                symbol[i] = numbers[i];

                if (symbol[i] != ' ')
                {
                    result += Convert.ToInt32(new String(symbol[i], 1));
                }
            }
            Console.WriteLine($"Сумма чисел {numbers}  = {result}");
            Console.ReadKey();
        */

            
        
    }
}
