using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
/*
 *  (*) Список задач (ToDo-list):
● написать приложение для ввода списка задач;
● задачу описать классом ToDo с полями Title и IsDone;
● на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить
из него массив имеющихся задач и вывести их на экран;
● если задача выполнена, вывести перед её названием строку «[x]»;
● вывести порядковый номер для каждой задачи;
● при вводе пользователем порядкового номера задачи отметить задачу с этим
порядковым номером как выполненную;
● записать актуальный массив задач в файл tasks.json/xml/bin.
*/



namespace Practice
{

    internal class Program
    {
        static void Body(int count, string fileName)
        {

            string[] list;
            list = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите задачу под номером {i + 1} ");
                list[i] = Console.ReadLine();
                File.AppendAllText(fileName, DateTime.Now + ":" + " - " + list[i] + Environment.NewLine);

            }
            Console.Clear();
            Console.WriteLine("Задачи успешно добавлены");
            Console.WriteLine();
            Console.WriteLine("Для возврата в меню, нажмите любую клавишу");

        }

        static void Main()
        {

            while (true)  

            {
                Console.WriteLine("Здравствуйте. Добро пожаловать в ToDoList. Выберите опцию:");
                Console.WriteLine("1 - Создать/Добавить новую задачу" + Environment.NewLine + "2 - Открыть список всех задач в заданном файле" + Environment.NewLine
                                  + "3 - Убрать выполненную задачу" + Environment.NewLine 
                                  + Environment.NewLine + "Совет : Для выхода из приложения, просто нажмите крестик в правом верхнем углу вашей консоли.");

                int a;

                try 
                {
                    a = int.Parse(Console.ReadLine());

                }
                catch (Exception) 
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка. Такой опции нет!!!");
                    Console.WriteLine();
                    Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                    Console.ReadLine(); 
                    Console.Clear();
                    continue; 
                }


                switch (a)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.WriteLine("Сколько задач вы хотите ввести?");
                            try
                            {
                                int count = int.Parse(Console.ReadLine());
                                string path = Directory.GetCurrentDirectory();
                                string[] entries = Directory.GetFileSystemEntries(path, "*.txt");
                                for (int i = 0; i < entries.Length; i++)
                                {
                                    string files = entries[i];

                                    Console.WriteLine(files);

                                }
                                Console.WriteLine("Введите имя для вашего файла");
                                string name = Console.ReadLine();
                                Body(count, name + ".txt");
                            }
                            catch (Exception) 
                            {
                                Console.WriteLine("Ошибка. Используйте числа");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                        }
                        break;


                    case 2:
                        {
                            Console.Clear();
                            string path = Directory.GetCurrentDirectory();
                            string[] entries = Directory.GetFileSystemEntries(path, "*.txt");
                            for (int i = 0; i < entries.Length; i++)
                            {
                                string files = entries[i];

                                Console.WriteLine(files);

                            }
                            Console.WriteLine("Введите имя файла в котором хранятся ваши задачи");
                            try
                            {
                                string name = Console.ReadLine();
                                string load = File.ReadAllText($"{name}.txt");
                                Console.WriteLine(load);
                            }
                            catch (Exception) 
                            {
                                Console.WriteLine("Файл с таким именем не существует");
                                Console.WriteLine();
                                Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }

                            Console.WriteLine("Для возврата в меню, нажмите любую клавишу");

                        }

                        break;
                    case 3:
                        {
                            Console.Clear();
                            string path = Directory.GetCurrentDirectory();
                            string[] entries = Directory.GetFileSystemEntries(path, "*.txt");
                            for (int i = 0; i < entries.Length; i++)
                            {
                                string files = entries[i];

                                Console.WriteLine(files);

                            }
                            Console.WriteLine("Введите имя файла задачи которого хотите изменить");
                            try
                            {
                                string name = Console.ReadLine();
                                string[] load = File.ReadAllLines($"{name}.txt");
                                for (int j = 0; j < load.Length; j++)
                                {
                                    Console.WriteLine(j + 1 + " " + "//" + " " + load[j]);
                                }
                                Console.WriteLine("Введите порядковый номер выполненной задачи");
                                int i = int.Parse(Console.ReadLine());
                                load[i - 1] = DateTime.Now + ":" + " -" + " Task is Done";
                                File.WriteAllLines(name + ".txt", load);

                            }
                            catch (Exception) 
                            {
                                Console.WriteLine("Файл с таким именем не существует");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Поздравляю, задача выполнена!");
                            Console.WriteLine();
                            Console.WriteLine("Для возврата в меню, нажмите любую клавишу");



                        }

                        break;

                    default:
                       
                        break;

                }
                Console.ReadLine();
                Console.Clear();

            }


        }

    }
}
