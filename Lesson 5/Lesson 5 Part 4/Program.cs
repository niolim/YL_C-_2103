using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_Part_4 //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Просто вставить рандомный путь в mainDir и готово, файл с описанием пути будет лежать в последней указанной папке

            string randomName = @"E:\Games\Riot Games"; // было бы удобнее чтобы пользователь сам вводил путь через консоль, но у меня не вышло

            if (Directory.Exists(randomName))
            {
                Proccess(randomName, "randomName.txt");
            }
            else
            {
                Console.WriteLine("Такой директории не существует");
            }
        }

        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="PathName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
         static string Proccess (string PathName, string fileName)
        {
            string mainDir = PathName; 
            string notePath = Path.Combine(mainDir, fileName);
            string[] entries = Directory.GetFileSystemEntries(mainDir, "*"); //если добавить SearchOption.AllDirectories он вообще все файлы во всех директориях распишет, рекурсия? 
            for (int i = 0; i < entries.Length; i++)
            {
                string path = entries[i];
                File.WriteAllLines(notePath, entries);

                Console.WriteLine(path);

            }
            Console.ReadKey();

            return Proccess (PathName,fileName);

         }

        /*
             * Здесь просто проверял как работают команды
             * 
            string mainDir = @"E:\Repos\torment\Homework\Task"; 
            Console.WriteLine(Directory.Exists(mainDir));
            string firstFolder = Path.Combine(mainDir, "firstFolder");
            Directory.CreateDirectory(firstFolder);
            string secondFolder = Path.Combine(firstFolder, "secondFolder");
            string thirdFolder = Path.Combine(secondFolder, "thirdFolder");
            Directory.CreateDirectory(Path.Combine(secondFolder, thirdFolder));
            string notePath = Path.Combine(thirdFolder, "Path.txt");
            string[] entries = Directory.GetFileSystemEntries(mainDir, "*", SearchOption.AllDirectories); 
            for (int i = 0; i < entries.Length; i++)
            {
               string path = entries[i];
               File.WriteAllText(notePath, path);

            }
            */


    }
}
