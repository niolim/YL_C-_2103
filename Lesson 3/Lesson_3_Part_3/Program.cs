using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Part_3 //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Word;
            Word = Console.ReadLine();
            char[] WordReverse = Word.ToCharArray();
            Array.Reverse(WordReverse);
            Word = new string(WordReverse);
            Console.Clear();
            Console.WriteLine(Word);
            Console.WriteLine();
        }
    }
}
