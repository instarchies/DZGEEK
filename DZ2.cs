using System;

class Program
{
    static void Main(string[] args)
    {
        //Задание 1
        Console.WriteLine("Введите 3-х значное число");
        int n = Convert.ToInt32(Console.ReadLine());

        while (n >= 100)
        {
            n /= 10;
        }

        int r = n % 10;

        Console.WriteLine("Вторая цифра числа = " + r);
        
        //Задание 2
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number.ToString().Length >= 3)
        {
            while (number >= 1000)
            {
                number /= 100;
            }
            int rr = number % 10;
            Console.WriteLine(rr);  
        }
        else
        {
            Console.WriteLine("Третей цифры нет");
        }

        //Задание 3
        Console.WriteLine("Введите номер дня недели");
        string week = Console.ReadLine();
        if (week == "6" || week == "7")
        {
            Console.WriteLine("Этот день является выходным");
        }
        else if (week == "1" || week == "2" || week == "3" || week == "4" || week == "5")
        {
            Console.WriteLine("Иди работай");
        }
        else Console.WriteLine("Это не день недели!");
    }
}