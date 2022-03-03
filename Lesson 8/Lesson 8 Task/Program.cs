using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greetings = Properties.Settings.Default.Greetings;
            string userName = Properties.Settings.Default.UserName;
            string userAge = Properties.Settings.Default.UserAge;
            string userOccupation = Properties.Settings.Default.UserOccupation;
            int answer;
          
            Console.WriteLine($"{greetings} Вас зовут {userName}, Вам {userAge} лет и Вы {userOccupation}?");
            
            Console.WriteLine($"Выберите :{Environment.NewLine}1 - Да {Environment.NewLine}2 - Нет");
            
            try
            {
                answer = int.Parse(Console.ReadLine());


                switch (answer)
                {
                    case 1:
                        {
                            Console.Clear();    

                            Console.WriteLine($"Замечательно {userName}. Значит все верно. Возвращайтесь снова!");
                          
                            Console.ReadKey();

                        }
                        break;
                    case 2:
                        {
                            Console.Clear();

                            Console.WriteLine("Опс. Значит произошла какая то ошибка. Внесем ваши данные заново");

                            Console.WriteLine();

                            Console.WriteLine("Пожалуйста представьтесь");
                            
                            Properties.Settings.Default.UserName = Console.ReadLine();
                            Properties.Settings.Default.Save();

                            Console.WriteLine("Сколько вам лет?");
                            
                            Properties.Settings.Default.UserAge = Console.ReadLine();
                            Properties.Settings.Default.Save();

                            Console.WriteLine("Чем вы занимаетесь?");
                            
                            Properties.Settings.Default.UserOccupation = Console.ReadLine();
                            Properties.Settings.Default.Save();


                            Console.Clear();
                            
                            Console.WriteLine("Новые данные были сохранены.");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Произошла ошибка, выберите один из вариантов");
                            Console.ReadKey();
                        }
                        break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введите числа");
                Console.ReadKey();
            }




        }
    }
}
