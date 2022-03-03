/*
Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
утилиты Windows tasklist и taskkill.
*/

using System.Diagnostics;


Process[] process = Process.GetProcesses();


while (true)
{
    int a;
    Console.WriteLine($"\t\t TASK MANAGER {Environment.NewLine}");
    Console.WriteLine($" 1 - Посмотреть все запущенные процессы {Environment.NewLine} 2 - Завершить процесс по порядковому номеру {Environment.NewLine} " +
        $"3 - Завершить процесс по ID {Environment.NewLine} 4 - Завершить процесс по имени (BETA) {Environment.NewLine} 5 - Выйти из программы" );
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
                Console.WriteLine($"Process #\tProcess ID\tProcess Name{Environment.NewLine}");
                for (int i = 0; i < process.Length; i++)
                {
                    Process current = process[i];

                    
                    Console.WriteLine($"{i+1}\t\t{current.Id}\t\t{current.ProcessName} {Environment.NewLine}");
   
                }

                Console.WriteLine("Для возврата в меню, нажмите любую клавишу");

            }
            break;
        case 2:
            {
                Console.Clear();
                Console.WriteLine("Введите порядковый номер процесса");

                try
                {
                    int procIndex = int.Parse(Console.ReadLine()) - 1;
                    if (procIndex >= 0)
                    {
                        Process ordinalNumber = process[procIndex];
                        Console.WriteLine($"{Environment.NewLine}Процесс {ordinalNumber.ProcessName} завершен");
                        ordinalNumber.Kill();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Ошибка!!! Вы ввели число {procIndex+1} это Недопустимое значение");
                        Console.WriteLine();
                        Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!!!");
                    Console.WriteLine();
                    Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                }
            }
            break;

        case 3:
            {
                Console.Clear();
                Console.WriteLine("Введите ID процесса");

                try
                {
                    int idNumber = int.Parse(Console.ReadLine());
                    if (idNumber >= 0)
                    {
                        Console.WriteLine($"{Environment.NewLine}Процесс с ID {idNumber} завершен");
                        Process.GetProcessById(idNumber).Kill();

                                             
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Ошибка!!! Вы ввели число {idNumber} это Недопустимое значение");
                        Console.WriteLine();
                        Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Ошибка!!! Введите ID процесса");
                    Console.WriteLine();
                    Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                }

            }
            break;

        case 4:
            {
                Console.Clear();
                Console.WriteLine($"\t\t\tПри использовании данного метода, могут возникнуть необработанные ошибки {Environment.NewLine}");
                Console.WriteLine("Введите имя процесса, который вы хотите завершить");

                string name = Console.ReadLine();


                foreach (Process procName in Process.GetProcessesByName(name))
                {
                    Console.WriteLine($"{Environment.NewLine}Процесс {procName.ProcessName} завершен");
                    procName.Kill();
                }
                Console.WriteLine();
                Console.WriteLine("Для возврата в меню, нажмите любую клавишу");


            }
            break;
        case 5:
            {
                Console.Clear();
                Process exit = Process.GetCurrentProcess();
                Console.WriteLine($"Вы завершили работу программы Task Manager.{Environment.NewLine}{Environment.NewLine}Нажмите любую клавишу для выхода.");
                exit.Kill();

            }
            break;

        
        default:
            {
                Console.Clear();
                Console.WriteLine("Ошибка!!! Такой опции нет");
                Console.WriteLine();
                Console.WriteLine("Для возврата в меню, нажмите любую клавишу");
                
            }

            break;
    }

    Console.ReadKey();
    Console.Clear();
    
}





