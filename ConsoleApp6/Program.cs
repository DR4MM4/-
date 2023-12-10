using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7.
            //По указанному номеру n вывести название соответствующего дня недели.
            //Console.Write("введите значение n");
            //byte n = byte.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //    default:
            //        Console.WriteLine("ошибка");
            //        break;
            //}
            //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12)
            //вывести на экран его название (январь, февраль, ... , декабрь).
            //Console.Write("введите номер month");
            //byte month = byte.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("март");
            //        break;
            //    case 4:
            //        Console.WriteLine("апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("май");
            //        break;
            //    case 6:
            //        Console.WriteLine("июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("август");
            //        break;
            //    case 9:
            //        Console.WriteLine("сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("декабрь");
            //        break;
            //    default:
            //        Console.WriteLine("ошибка");
            //        break;
            //}
            //Задача 3. По номеру месяца вывести название времени года.
            //Console.Write("введите номер month");
            //byte month = byte.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Зима");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Весна");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Лето");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Осень");
            //        break;
            //    default:
            //        Console.WriteLine("ошибка");
            //        break;


            //}
            //Задача 4. Вывести название предмета по введенной первой букве
            //: ф – физика, м – математика, и – история, г – география, б – биология.
            Console.Write("введитe letter");
            char letter = char.Parse(Console.ReadLine());
            switch (letter)
            {
                case 'ф':
                    Console.WriteLine("физика");
                    break;
                case 'м':
                    Console.WriteLine("математика");
                    break;
                case 'и':
                    Console.WriteLine("история");
                    break;
                case 'г':
                    Console.WriteLine("география");
                    break;
                case 'б':
                    Console.WriteLine("биология");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}