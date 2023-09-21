using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражение 2.1");
            Console.WriteLine("\n Данная программа спрашивает имя у пользователя, после чего приветствует его.");
            Console.WriteLine("\nНапишите своё имя");
            string nameuser = Console.ReadLine();
            Console.WriteLine("\nОтвет консоли");
            Console.WriteLine("\nПривет " + nameuser);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
            
            Console.WriteLine("\nУпражнение 2.2");
            Console.WriteLine("\nДанная программа делит одно число на другое, в случае деление на 0, программа выдаст ошибку");
            int firstnumber, secondnumber;
            Console.WriteLine("Введите первое число");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            secondnumber = int.Parse(Console.ReadLine());
            if (secondnumber == 0)
            {
                Console.WriteLine("\nНа ноль делить нельзя");
            }
            else
            {
                Console.WriteLine("\nОтвет");
                Console.WriteLine((double)firstnumber / secondnumber);
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadLine();
            
            Console.WriteLine("\nДомашнее задание 2.1");
            Console.WriteLine("\nДанная прогрмма печатает следующую букву алфавита");
            Console.WriteLine("\nНапишите букву");
            string letter = Console.ReadLine();
            string number = "0123456789";
            if (letter.Length > 1)
            {
                Console.WriteLine("Нельзя вводить больше одного символа");
            }
            else if (number.Contains(letter))
            {
                Console.WriteLine("Нельзя вводить числа и цифры");
            }
            else if (letter == "z" || letter == "я")
            {
                Console.WriteLine("Вы ввели последнию букву алфавита");
            }
            else
            {
                Console.WriteLine("Следующая буква");
                char symbol = Convert.ToChar(letter);
                Console.WriteLine((char)(symbol + 1));
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadLine();
            
            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("Данная программа считает квадратное уравнение");
            double a, b, c;
            Console.WriteLine("Введите коэффицент a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент c");
            c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
                Console.WriteLine("Ответ");
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Нет решений");
            }
            Console.ReadKey();







        }
    }
}
