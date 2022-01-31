using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_part_4
{
    /*
     * Для полного закрепления понимания простых типов найдите любой чек, либо фотографию
       этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических,
       по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
       подставляйте переменные, которые были заранее заготовлены до вывода на консоль
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string LLCname = "White Mage LTD";
            string ShopName = "Neverland Store";
            string address = "You shall not pass bridge";
            string phoneNumber = "тел.: Обычно использую телепатию";
            string billNumber1 = "#5487515157";
            string billNumber2 = "#2154512315";
            string billNumber3 = "#5654654564";
            string ItemName1 = "Посох мага ледяных ветров";
            string ItemName2 = "Коса короля небытия";
            string ItemName3 = "Доспехи забытого драконьего всадника";
            string Discount = "% скидки:... 100%";
            string ItemPrice1 = "5000 золотых монет";
            string ItemPrice2 = "7000 золотых монет";
            string ItemPrice3 = "10000 золотых монет";
            string Finalstroke = $"ККМ 00074865  ИНН 005696986953 {dateTime}";

            

            System.Console.WriteLine("Приветствую тебя странник, как твое имя?");
            System.String Name = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine($"Тебе сегодня повезло {Name}, назови цифру от 1го до 3х и получи случайную вещицу совершенно бесплатно!");
            System.Console.WriteLine("P.S. Без чека товар обратно не принимается! Удачи странник");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"||                {LLCname}                        ||");
                    Console.WriteLine($"||                {ShopName}                       ||");
                    Console.WriteLine($"||           {address}                  ||");
                    Console.WriteLine($"||        {phoneNumber }              ||");
                    Console.WriteLine("||                                                      ||"); 
                    Console.WriteLine($"|| Кассовый чек {billNumber1}                             ||") ;
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine($"|| 14568                       {ItemName1}||");
                    Console.WriteLine($"|| Колличество:.....1          Цена:..{ItemPrice1}||");
                    Console.WriteLine($"|| {Discount}   Сумма скидки:..{ItemPrice1}||");
                    Console.WriteLine("||                              Сумма:.. 0 золотых монет||");
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||ИТОГ                                 = 0 золотых монет||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine($"|| {Finalstroke}   ||");
                    Console.WriteLine("||______________________________________________________||");
                    break;

                    case "2":
                    Console.WriteLine($"||                {LLCname}                        ||");
                    Console.WriteLine($"||                {ShopName}                       ||");
                    Console.WriteLine($"||           {address}                  ||");
                    Console.WriteLine($"||        {phoneNumber }              ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine($"|| Кассовый чек {billNumber2}                             ||");
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine($"|| 14568                       {ItemName2}      ||");
                    Console.WriteLine($"|| Колличество:.....1          Цена:..{ItemPrice2}||");
                    Console.WriteLine($"|| {Discount}   Сумма скидки:..{ItemPrice2}||");
                    Console.WriteLine("||                              Сумма:.. 0 золотых монет||");
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||ИТОГ                                 = 0 золотых монет||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine($"|| {Finalstroke}   ||");
                    Console.WriteLine("||______________________________________________________||");
                    break;

                    case "3":
                    Console.WriteLine($"||                {LLCname}                        ||");
                    Console.WriteLine($"||                {ShopName}                       ||");
                    Console.WriteLine($"||           {address}                  ||");
                    Console.WriteLine($"||        {phoneNumber }              ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine($"|| Кассовый чек {billNumber3}                             ||");
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine($"|| 14568            {ItemName3}||");
                    Console.WriteLine($"|| Колличество:.....1         Цена:..{ItemPrice3}||");
                    Console.WriteLine($"|| {Discount}  Сумма скидки:..{ItemPrice3}||");
                    Console.WriteLine("||                              Сумма:.. 0 золотых монет||");
                    Console.WriteLine("||======================================================||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||ИТОГ                                 = 0 золотых монет||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine("||                                                      ||");
                    Console.WriteLine($"|| {Finalstroke}   ||");
                    Console.WriteLine("||______________________________________________________||");
                    break;

                default:
                    Console.WriteLine($"Глупый странник, ты упустил свою возможность. Прощай {Name}.");
                    break;

            }


        }
    }
}
