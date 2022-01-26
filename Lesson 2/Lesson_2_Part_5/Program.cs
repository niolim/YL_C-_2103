using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Part_5 // Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Приветствую тебя Старк, хочешь узнать какая погода за стеной, введи порядковый номер интересующего тебя месяца");

            int minTemp;
            int maxTemp;


            switch (Console.ReadLine())

            {
                case "1":
                    Console.Clear();
                    
                    Console.WriteLine("Как истинный Старк, ты выбрал зимний месяц - Январь");
                   
                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());
                    
                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());
                    
                    System.Console.Clear();

                    int averageTemp = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp);

                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Что ж, тебя ждет Дождливая зима Старк");
                    }

                    else
                    {
                        Console.WriteLine("Мужайся, Ходоки на подходе");

                    }

                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("Как истинный Старк, ты выбрал зимний месяц - Февраль");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp2 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp2);

                    if (averageTemp2 > 0)
                    {
                        Console.WriteLine("Что ж, тебя ждет Дождливая зима Старк");
                    }

                    else
                    {
                        Console.WriteLine("Мужайся, Ходоки на подходе");

                    }
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("Ты выбрал Март - хочется немного весенней романтики Старк?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp3 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp3);

                    if (averageTemp3 > 0)
                    {
                        Console.WriteLine("Погода не помешает твоим любовным похождениям Старк");
                    }

                    else
                    {
                        Console.WriteLine("Не повезло тебе Старк, все девушки будут сидеть дома");

                    }
                    break;

                case "4":
                    Console.Clear();

                    Console.WriteLine("Ты выбрал Апрель - хочется немного весенней романтики Старк?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp4 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp4);

                    if (averageTemp4 > 0)
                    {
                        Console.WriteLine("Погода не помешает твоим любовным похождениям Старк");
                    }

                    else
                    {
                        Console.WriteLine("Не повезло тебе Старк, все девушки будут сидеть дома");

                    }
                    break;

                case "5":
                    Console.Clear();

                    Console.WriteLine("Ты выбрал Май - хочется немного весенней романтики Старк?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp5 = (minTemp + maxTemp) / 2;
                    Console.Write(averageTemp5);

                    if (averageTemp5 > 0)
                    {
                        Console.WriteLine("Погода не помешает твоим любовным похождениям Старк");
                    }

                    else
                    {
                        Console.WriteLine("Не повезло тебе Старк, все девушки будут сидеть дома");

                    }
                    break;

                case "6":
                    Console.Clear();

                    Console.WriteLine("хм..Июнь? - даже в Винтерфелле бывает лето?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp6 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp6);

                    if (averageTemp6 > 0)
                    {
                        Console.WriteLine("Насладись последними лучами солнца Старк");
                    }

                    else
                    {
                        Console.WriteLine("На севере даже лето бывает обманчивым Старк");

                    }
                    break;

                case "7":
                    Console.Clear();

                    Console.WriteLine("хм..Июль? - даже в Винтерфелле бывает лето?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp7 = (minTemp + maxTemp) / 2;
                    Console.Write(averageTemp7);    

                    if (averageTemp7 > 0)
                    {
                        Console.WriteLine("Насладись последними лучами солнца Старк");
                    }

                    else
                    {
                        Console.WriteLine("На севере даже лето бывает обманчивым Старк");

                    }
                    break;

                case "8":
                    Console.Clear();

                    Console.WriteLine("хм..Август? - даже в Винтерфелле бывает лето?");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp8 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp8);

                    if (averageTemp8 > 0)
                    {
                        Console.WriteLine("Насладись последними лучами солнца Старк");
                    }

                    else
                    {
                        Console.WriteLine("На севере даже лето бывает обманчивым Старк");

                    }
                    break;

                case "9":
                    Console.Clear();

                    Console.WriteLine("Осторожнее, ты выбрал один из месяцев Осени - Сентябрь, ты должен понимать что это значит Старк");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp9 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp9);

                    if (averageTemp9 > 0)
                    {
                        Console.WriteLine("Если удача будет на твоей стороне Старк, ты сможешь увидеть солнце");
                    }

                    else
                    {
                        Console.WriteLine("Зима близко Старк!");

                    }
                    break;

                case "10":
                    Console.Clear();

                    Console.WriteLine("Осторожнее, ты выбрал один из месяцев Осени - Октябрь, ты должен понимать что это значит Старк");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp10 = (minTemp + maxTemp) / 2;
                    Console.Write(averageTemp10);

                    if (averageTemp10 > 0)
                    {
                        Console.WriteLine("Если удача будет на твоей стороне Старк, ты сможешь увидеть солнце");
                    }

                    else
                    {
                        Console.WriteLine("Зима близко Старк!");

                    }
                    break;

                case "11":
                    Console.Clear();

                    Console.WriteLine("Осторожнее, ты выбрал один из месяцев Осени - Ноябрь, ты должен понимать что это значит Старк");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp11 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp11);

                    if (averageTemp11 > 0)
                    {
                        Console.WriteLine("Если удача будет на твоей стороне Старк, ты сможешь увидеть солнце");
                    }

                    else
                    {
                        Console.WriteLine("Зима близко Старк!");

                    }
                    break;

                case "12":
                    Console.Clear();

                    Console.WriteLine("Как истинный Старк, ты выбрал зимний месяц - Декабрь");

                    System.Console.WriteLine($"Подскажи, какая минимальная температура была в этом месяце на стене");
                    minTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine($"а теперь, скажи, какая максимальная температура была в этом месяце на стене");
                    maxTemp = Convert.ToInt32(Console.ReadLine());

                    System.Console.Clear();

                    int averageTemp12 = (minTemp + maxTemp) / 2;
                    Console.WriteLine(averageTemp12);

                    if (averageTemp12 > 0)
                    {
                        Console.WriteLine("Что ж, тебя ждет Дождливая зима Старк");
                    }

                    else
                    {
                        Console.WriteLine("Мужайся, Ходоки на подходе");

                    };
                    break;

                default:
                    Console.WriteLine("Не глупи Старк, в году всего 12 месяцев!");
                    break;

            }


        }
    }
}
