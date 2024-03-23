using System;


using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

//public class Ramill
//{

//    public static void Main(string[] args)
//    {
//        Console.Write("Введите число а ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Введите число b ");
//        int b = int.Parse(Console.ReadLine());
//        Console.Write("Введите число c ");
//        int c = int.Parse(Console.ReadLine());

//        int min = a;
//        if (b < min) min = b;
//        if (c < min) min = c;
//        Console.WriteLine("Минимальное число " + min);
//    }
//}

//class SumNumbers
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string str = Console.ReadLine();

//        int x = Convert.ToInt32(str);

//        int counter = 0;

//        while (x > 0)
//        {
//            counter++;
//            x = x / 10;
//        }

//        Console.WriteLine("Данное число содержит цифр: " + counter);
//    }
//}

//class SumPolghisl
//{
//    static void Main()
//    {
//        int sum = 0;
//        int num = 0;

//        do
//        {
//            Console.Write("Введите число  ");
//            num = int.Parse(Console.ReadLine());
//            if (num > 0 && num % 2 == 1)
//                sum += num;

//        } while (num != 0);

//        Console.WriteLine("Сумма нечетных чисел равна " + sum);
//    }
//}


//class Parol
//{
//    static void Main(string[] args)
//    {
//        string login = "Ramil";
//        string password = "12345";

//        int count = 0;
//        do
//        {
//            Console.WriteLine("Введите логин: ");
//            string Login = Console.ReadLine();

//            Console.WriteLine("Введите пароль: ");
//            string Password = Console.ReadLine();

//            if (login == Login && password == Password)
//            {
//                Console.WriteLine("Добро пожаловать");
//                Console.ReadLine();
//                break;
//            }
//            Console.WriteLine("Неверно введен логин или пароль");
//            Console.ReadLine();
//            ++count;
//        } while (count < 3);

//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        int a, b, r;
//        //b - оптимальный вес
//        Console.WriteLine("Введите свой рост в см");
//        r = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите свой вес в кг");
//        a = int.Parse(Console.ReadLine());

//        b = r - 100;

//        if (b > a)
//            Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо поправиться", b);
//        else if (b < a)
//            Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо похудеть", b);
//        else
//            Console.WriteLine("Ваш оптимальный вес = {0}, все в порядке", b);

//        Console.ReadKey();
//    }
//}


class Task_1
{
    static void Main()
    {
        int a, b, count;

        Console.Write("Вводим число A: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("Вводим число B: ");
        b = Int32.Parse(Console.ReadLine());

        if (a >= b)
        {
            Console.Write("Вы ввели не правильное условие: a >= b");
            return;
        }

        for (int i = a; i <= b; i++)
        {
            Console.Write(" {0} ", i);
        }

        count = b - a + 1;
        Console.Write("\nКоличество чисел равно: {0} ", count);
    }
}


//class RecursMetod
//{
//    static void Main()
//    {
//        int a, b, num;
//        int sum = 0;
//        Console.Write("Вводим число A: ");
//        a = Int32.Parse(Console.ReadLine());
//        Console.Write("Вводим число B: ");
//        b = Int32.Parse(Console.ReadLine());

//        if (a >= b)
//        {
//            Console.Write("Вы ввели не правильное условие: a > b");
//        }
//        if (a < b)
//        {
//            for (int i = a; i <= b; i++)
//            {
//                Console.Write(" {0} ", i);
//            }
//        }
//    }
//}










