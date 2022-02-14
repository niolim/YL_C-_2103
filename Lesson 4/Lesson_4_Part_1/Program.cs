using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Part_1
/*
 * Написать метод GetFullName(string firstName, string lastName, string
   patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
   объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
   3–4 разных ФИО.
*/
{
    internal class Program
    {
        // Сделано на основе данных в методичке. 

        static void Main()
        {
            (string firstName, string patronymic, string lastName)[] users = getFullName();
            ShowMenu(users);
        }
        static (string firstName, string patronymic, string lastName)[] getFullName()
        {
            Console.WriteLine("Введите количество пользователей:");
            int count = ReadInt();
            (string firstName, string patronymic, string lastName)[] users = new (string firstName, string patronymic, string lastName)[count];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = CreateUser();
                Console.WriteLine($"Пользователь {FormatUserData(users[i])} сохранен");
            }
            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            return users;
        }
        static void ShowMenu((string firstName, string patronymic, string lastName)[] users)
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        PrintUsers(users);
                        break;
                    case 2:
                        PrintSelectedUser(users);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
        static (string name, string middleName, string sureName) CreateUser()
        {
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество пользователя: ");
            string middleName = Console.ReadLine();
            Console.Write("Введите фамилию пользователя: ");
            string sureName = Console.ReadLine();
            return (name, middleName,sureName);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр данных всех пользователей");
            Console.WriteLine("2 - Просмотр конкретного пользователя");
            return ReadInt();
        }
        static void PrintSelectedUser((string firstName, string patronymic, string lastName)[] users)
        {
            int userIndex;
            do
            {
                Console.WriteLine($"Введите идентификатор пользователя - от 0 до { users.Length -1}");
                userIndex = ReadInt();
            } while (userIndex < 0 || userIndex >= users.Length);
            PrintUser(users[userIndex]);
        }
        static void PrintUsers((string firstName, string patronymic, string lastName)[] users)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < users.Length; i++)
            {
                PrintUser(users[i]);
            }
        }
        static void PrintUser((string firstName, string patronymic, string lastName) user)
        {
            Console.WriteLine(FormatUserData(user));
        }
        static string FormatUserData((string firstName, string patronymic, string lastName) user)
        {
            return $"{user.firstName} {user.patronymic} {user.lastName}";
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
