using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
struct Worker
{
    public string name;
    public string university;
    public void Print()
    {
        Console.WriteLine($"Имя сотрудника - {name} , ВУЗ - {university}");
    }
}
enum University
{
    КГУ,
    КАИ,
    КХТИ
}
enum Bank
{
    текущий,
    сберегательный
}
struct Informationbank
{
    public long number;
    public string type;
    public int balance;
    public void Print()
    {
        Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
    }
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Console.WriteLine("\nДанная программа создает перечислимый тип данных отображающий" +
                "\nвиды банковского счета (текущий и сберегательный).");
            Console.WriteLine("\nВыберите какой счет вы хотите посмотреть (текущий или сберегательный" +
                "\nДля того чтобы выбрать текущий счет, нажмите 0, если сберегательный, то нажмите 1");
            Bank youbank = (Bank)Convert.ToInt32(Console.ReadLine());
            switch (youbank)
            {
                case Bank.текущий:
                    Console.WriteLine("Вы выбрали текущий счёт");
                    break;
                case Bank.сберегательный:
                    Console.WriteLine("Вы выбрали сберегательный счет");
                    break;
            }
            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("\nУпражнение 3.2");
            Console.WriteLine("\nДанная программа хранит информацию о банковском счете – его номер, тип и баланс.");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Informationbank informationbank = new Informationbank();
            informationbank.number = 2202123443215555;
            informationbank.type = "Commercial";
            informationbank.balance = 1000000;
            informationbank.Print();
            Console.ReadKey();
            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Домашнее задание 3.1");
            Console.WriteLine("Данная программа, заполняет тип данных и распечатывает его");
            Console.WriteLine("Для того чтобы продолжить, нажмите любую клавишу");
            Console.ReadKey();
            Worker worker = new Worker();
            Console.WriteLine("Введите имя сотрудника");
            worker.name = Console.ReadLine();
            Console.WriteLine("Введите номер ВУЗа, в котором работает работник(КГУ - 0, КАИ - 1, КХТИ - 2");
            int vyz = Convert.ToInt32(Console.ReadLine());
            University university = (University)vyz;
            worker.university = university.ToString();
            worker.Print();
            Console.WriteLine("Для того чтобы закончить, нажмите любую кнопку");
            Console.ReadKey();
            













        }

    }

}
