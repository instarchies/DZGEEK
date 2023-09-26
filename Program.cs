int Degree(int a, int b)
{
    int result = 0;
    for (int i = 1; i <= b; i++)
    {
        if (result == 0)
        {
            result = a;
        }
        else
        {
            result = a * result;
        }
    }
    return result;
}
Console.WriteLine("Введите число а, в которое хотите возвести степень b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат = {Degree(a, b)}");


int SumOfDigits(int a)
{
    int[] x = new int[a.ToString().Length];
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = a % 10;
        a /= 10;
    }
    Array.Reverse(x);
    int result = 0;
    for (int i = 0; i < x.Length; i++)
    {
        result = result + x[i];
    }
    return result;
}
Console.WriteLine("Введите число, в котором хотите найти сумму цифр");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат = {SumOfDigits(number)}");

void Massive(int a, int b, int c, int d, int e, int f, int g, int h)
{
    int[] massive = { a, b, c, d, e, f, g, h };
    for (int i = 0; i < massive.Length; i++)
    {
        if (i == massive.Length - 1)
        {
            Console.Write($"[{massive[i]}]");
        }
        else
        {
            Console.Write($"[{massive[i]}],");
        }
        
    }

}
Console.WriteLine("введите 8 чисел, чтобы вывести их массив на экран");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int number6 = Convert.ToInt32(Console.ReadLine());
int number7 = Convert.ToInt32(Console.ReadLine());
int number8 = Convert.ToInt32(Console.ReadLine());

Massive(number1, number2, number3, number4, number5, number6, number7, number8);