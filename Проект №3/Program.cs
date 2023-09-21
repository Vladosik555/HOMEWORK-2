using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;

enum alcohol
{
    Пьяница,
    Пьющий,
    Выпивающий,
    Трезвый
}
struct students
{
    public string sername;
    public string name;
    public int identifier;
    public int birth;
    public double liter;
    public alcohol Alcoholismcategory;
    public void Print()
    {
        Console.WriteLine($"{name} выпил такое количество алкоголя: {Alcoholismcategory}");
    }
}
namespace Проект__3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
             Console.WriteLine("\nЗадание номер 1");
             Console.WriteLine("\nДанная программа показывает информацию о всех типах данных");
             Console.WriteLine("\nДля того чтобы продолжить, нажмите любую клавишу");
             Console.ReadKey();
             Console.WriteLine("\nbool: хранит значение true или false (логические литералы)." +
                 "\nbyte: хранит целое число от 0 до 255 и занимает 1 байт. " +
                 "\nsbyte: хранит целое число от -128 до 127 и занимает 1 байт." +
                 "\nshort: хранит целое число от -32768 до 32767 и занимает 2 байта." +
                 "\nushort: хранит целое число от 0 до 65535 и занимает 2 байта." +
                 "\nint: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта." +
                 "\nuint: хранит целое число от 0 до 4294967295 и занимает 4 байта." +
                 "\nlong: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт." +
                 "\nulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт." +
                 "\nfloat: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта." +
                 "\ndouble: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта." +
                 "\ndecimal: хранит десятичное дробное число. Если употребляется без десятичной запятой," +
                 "\nимеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт" +
                 "\nchar: хранит одиночный символ в кодировке Unicode и занимает 2 байта." +
                 "\nstring: хранит набор символов Unicode." +
                 "\nobject: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе" +
                 "\nи 8 байт на 64-разрядной платформе.");
             Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
             Console.ReadKey();
             
            Console.WriteLine("\nЗадание номер 2");
             Console.WriteLine("\nДанная программа принимает данные пользователя в виде имени,города, возраста и PIN-кода" +
                 "\nпосле чего расспечатывает всю информацию в правильном формате");
             Console.WriteLine("Для запуска программы нажмите любую клавишу");
             Console.ReadKey(); 
             Console.WriteLine("Напишите своё имя");
             string name = Console.ReadLine();
             Console.WriteLine("Напишите место, в котором вы проживаете");
             string city = Console.ReadLine();
             Console.WriteLine("Напишите ваш возраст");
             string age = Console.ReadLine();
             Console.WriteLine("Напишите ваш PIN-код");
             string Pincode = Console.ReadLine();
             Console.WriteLine($"\nИмя : {name}" +
                 $"\nАдрес проживания : {city}" +
                 $"\nВозраст : {age}" +
                 $"\nPINкод : {Pincode}");
             Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу");
             Console.ReadKey();

             Console.WriteLine("\nЗадание номер 3");
             Console.WriteLine("\nДанная программа преобразует строчные буквы на заглавные, заглавные – на строчные.");
             Console.WriteLine("Для запуска программы нажмите любую клавишу");
             Console.ReadKey();
             Console.WriteLine("Введите текст");
             string text = Console.ReadLine();
             string answer = "";
             for (int i = 0; i < text.Length; i++)
             {
                 string text1 = Convert.ToString(text[i]);
                 if (text1 == text1.ToLower()) 
                 {
                     answer += text1.ToUpper();
                 }
                 else 
                 {
                     answer += text1.ToLower();
                 }
             }
             Console.Write("Ответ: ");
             Console.WriteLine(answer);
             Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
             Console.ReadKey();

             Console.WriteLine("Задание номер 4");
             Console.WriteLine("Данная программа позволяет найти количество вхождений");
             int number = 0; 
             Console.WriteLine("Введите строку");
             string str = Console.ReadLine();
             Console.WriteLine("Введите подстроку");
             string srt1 = Console.ReadLine();
             str = str.Replace(srt1, "0");
             for (int i = 0; i < str.Length; i++)
             {
                 if (str[i] == '0')
                 {
                     number++;
                 }
             }
                 Console.WriteLine($"Количество вхождений в строку: {number}");
             Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
             Console.ReadKey();

             Console.WriteLine("\nЗадание номер 5");
             Console.WriteLine("\nДанная программа показывает, сколько нужно купить бутылок виски со скидкой" +
                 "\nчтобы накопить себе на отдых");
             Console.WriteLine("\nВведите стоимость отдыха");
             int holidayprice = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите стоимость виски без скидки");
             double whiskey = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Видите скидку на виски");
             double discount = Convert.ToDouble(Console.ReadLine());
             double discountwhiskey = (whiskey - (whiskey / 100 * discount));
             double bottles = holidayprice / (whiskey - discountwhiskey);
             Console.WriteLine($"Количество бутылок нужно купить, чтобы заработать на отпуск: {Math.Truncate(bottles)}");
             Console.ReadKey();
            
             Console.WriteLine("\nЗадание номер 6");
             Console.WriteLine("\nДанная программа воспроизводит разгоров Гарри Поттера и дневника Тома Реддла.");
             Console.WriteLine("\nДля того чтобы продолжить, нажмите любую клавишу");
             Console.ReadKey();
             Console.WriteLine("Поздоровайтесь с дневником");
             Console.ReadLine();
             Console.WriteLine("Дневник спрашивает: как тебя зовут?");
             string myname = Console.ReadLine();
             Console.WriteLine("Привет " + myname);
             Console.WriteLine("Спросить у дневника, знает ли он что-нибудь о тайной комнате");
             Console.ReadLine();
             Console.WriteLine("Да, знаю");
             Console.WriteLine("Попросите у консоли рассказать о тайной комнате");
             Console.ReadLine();
             Console.WriteLine("Дневник : нет");
            Console.BackgroundColor = ConsoleColor.Blue;
            Thread.Sleep(5000);
             Console.WriteLine("Но могу показать");
            Console.BackgroundColor = ConsoleColor.Black;
             Console.WriteLine($"\nДля того чтобы продолжить, нажмите любую клавишу");
             Console.ReadKey();
            
             Console.WriteLine("\nЗадание номер 7, пункт а");
             Console.WriteLine("\nДанная программа вычисляет контрольную цифру штрихкода");
             Console.WriteLine("\nДля того чтобы продолжить, нажмите любую клавишу");
             Console.ReadKey();
             Random random = new Random();
             int number1 = random.Next(10), number2 = random.Next(10), number3 = random.Next(10), number4 = random.Next(10),
                 number5 = random.Next(10), number6 = random.Next(10), number7 = random.Next(10), number8 = random.Next(10),
                 number9 = random.Next(10), number10 = random.Next(10), number11 = random.Next(10), number12 = random.Next(10);
             string ean13 = Convert.ToString(number1) + Convert.ToString(number2) + Convert.ToString(number3) +
                 Convert.ToString(number4) + Convert.ToString(number5) + Convert.ToString(number6) + Convert.ToString(number7) +
                 Convert.ToString(number8) + Convert.ToString(number9) + Convert.ToString(number10) + Convert.ToString(number11) +
                 Convert.ToString(number12);
             Console.WriteLine("Сформированный штрих код " + ean13);
             int sumeven = ((number2 + number4 + number6 + number8 + number10 + number12) * 3);
             int sumnoteven =number1 + number3 + number5 + number7 + number9 + number11;
             int sum = sumeven + sumnoteven;
             int ostatok = sum % 10;
            if (ostatok == 0)
            {
                int controlnumber = 0;
                Console.WriteLine($"Контрольная цифра равна: {controlnumber}");
            }
            else
            {
                int controlnumber = 10 - ostatok;
                Console.WriteLine($"Контрольная цифра равна: {controlnumber}");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
        
             Console.WriteLine("Пункт б, ввести первые 12 цифр штрихкода самостоятельно");
             Console.WriteLine("Введите 12 цифр");
             int even = 0;
             int noteven = 0;
             string eean13 = Console.ReadLine();
             if (eean13.Length == 12)
             {
                
                for (int j = 0; j < 12; j++)
                {
                     if (j == 0 || j % 2 == 0)
                     {
                         noteven += Convert.ToInt32(eean13[j]);
                     }
                     else
                     {
                         even += Convert.ToInt32(eean13[j]);
                     }
                }
                 even = 3 * even;
                 int result = even + noteven;
                 int ostatok1 = result % 10;
                 int otvet1 = 12 - ostatok1;
                if (ostatok1 == 0)
                {
                    int controlnumber1 = 0;
                    Console.WriteLine($"Контрольная цифра равна: {controlnumber1}");
                }
                else
                {
                    int controlnumber1 = 12 - ostatok1;
                    Console.WriteLine($"Контрольная цифра равна: {controlnumber1}");
                }
                Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы ввели больше или меньше 12-ти цифр");
            }
             
             Console.ReadKey();
             
             Console.WriteLine("\nЗадание номер 8");
             Console.WriteLine("\nДанная программа показывает, сколько алкоголя выпили студенты");
             Console.WriteLine("\nСоздаем 5 различных студентов");
             Console.WriteLine("\nДля того чтобы продолжить, нажмите любую кнопку");
             Console.ReadKey();
             students student1 = new students();
             student1.sername = "Иванов";
             student1.name = "Владислав";
             student1.identifier = 1;
             student1.birth = 2004;
             student1.Alcoholismcategory = alcohol.Пьяница;
             student1.liter = 3.5;
             students student2 = new students();
             student2.sername = "Пушкин";
             student2.name = "Никита";
             student2.identifier = 2;
             student2.birth = 2005;
             student2.Alcoholismcategory = alcohol.Трезвый;
             student2.liter = 0;
             students student3 = new students();
             student3.sername = "Батуев";
             student3.name = "Иван";
             student3.identifier = 3;
             student3.birth = 2005;
             student3.Alcoholismcategory = alcohol.Пьющий;
             student3.liter = 2;
             students student4 = new students();
             student4.sername = "Мосин";
             student4.name = "Александр";
             student4.identifier = 4;
             student4.birth = 2005;
             student4.Alcoholismcategory = alcohol.Пьяница;
             student4.liter = 4;
             students student5 = new students();
             student5.sername = "Сметанин";
             student5.name = "Илья";
             student5.identifier = 5;
             student5.birth = 2002;
             student5.Alcoholismcategory = alcohol.Выпивающий;
             student5.liter = 0.5;
             double litrs = student1.liter + student2.liter + student3.liter + student4.liter + student5.liter;
             Console.WriteLine("\nОбъем выпитого алкоголя:" + litrs);
             Console.WriteLine($"\n {student1.sername} {student1.name} тип алкоголизма {student1.Alcoholismcategory}" +
                 $"\n выпил {student1.liter} литра алкоголя, в процентах: {student1.liter / litrs * 100}%");

             Console.WriteLine($"\n {student2.sername} {student2.name} тип алкоголизма {student2.Alcoholismcategory}" +
                 $"\n выпил {student2.liter} литра алкоголя, в процентах: {student2.liter / litrs * 100}%");

             Console.WriteLine($"\n {student3.sername} {student3.name} тип алкоголизма {student3.Alcoholismcategory}" +
                 $"\n выпил {student3.liter} литра алкоголя, в процентах: {student3.liter / litrs * 100}%");

             Console.WriteLine($"\n {student4.sername} {student4.name} тип алкоголизма {student4.Alcoholismcategory}" +
                 $"\n выпил {student4.liter} литра алкоголя, в процентах: {student4.liter / litrs * 100}%");

             Console.WriteLine($"\n {student5.sername} {student5.name} тип алкоголизма {student5.Alcoholismcategory}" +
                 $"\n выпил {student5.liter} литра алкоголя, в процентах: {student5.liter / litrs * 100}%");
             Console.WriteLine("\nДля того чтобы закрыть программу, нажмите на любую кнопку клавиатуры");
             Console.ReadKey();
             
           

















        }
    }
}
