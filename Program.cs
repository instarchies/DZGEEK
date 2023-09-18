//Илья Бутенко
//Задание 1 
Console.WriteLine("Task 1.");
int a1 = 5;
int b1 = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;
if (a1 < b1)
{
    Console.WriteLine($"1. a1 = {a1}, b1 = {b1}");
    Console.WriteLine($"Min = a1({a1})");
    Console.WriteLine($"Max = b1({b1})");

}
else
{
    Console.WriteLine($"1. a1 = {a1}, b1 = {b1}");
    Console.WriteLine($"Min = b1({b1})");
    Console.WriteLine($"Max = a1({a1})");
}
if (a2 < b2)
{
    Console.WriteLine($"2. a2 = {a2}, b2 = {b2}");
    Console.WriteLine($"Min = a2({a2})");
    Console.WriteLine($"Max = b2({b2})");

}
else
{
    Console.WriteLine($"2. a2 = {a2}, b2 = {b2}");
    Console.WriteLine($"Min = b2({b2})");
    Console.WriteLine($"Max = a2({a2})");
}
if (a3 < b3)
{
    Console.WriteLine($"3. a3 = {a3}, b3 = {b3}");
    Console.WriteLine($"Min = a3({a3})");
    Console.WriteLine($"Max = b3({b3})");

}
else
{
    Console.WriteLine($"3. a3 = {a3}, b3 = {b3}");
    Console.WriteLine($"Min = b3({b3})");
    Console.WriteLine($"Max = a3({a3})");
}
Console.WriteLine();

//Задание 2

Console.WriteLine("Task 2.");
int[] numbers = { 2, 3, 7 };
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("There are numbers: " + numbers[i]);
}
Console.WriteLine("Max: " + numbers.Max());
Console.WriteLine();

//Задание 3

Console.WriteLine("Task 3");
int a = 4;
int b = -3;
int c = 7;
if (a % 2 == 0)
{
    Console.WriteLine("Число а - четное");
}
else
{
    Console.WriteLine("Число а - нечетное");
}
if (b % 2 == 0)
{
    Console.WriteLine("Число b - четное");
}
else
{
    Console.WriteLine("Число b - нечетное");
}
if (c % 2 == 0)
{
    Console.WriteLine("Число c - четное");
}
else
{
    Console.WriteLine("Число c - нечетное");
}
Console.WriteLine();

//Задание 4

int n1 = 5;
Console.WriteLine($"1. There is number {n1}");
for (int i = 1; i <= n1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

}
int n2 = 8;
Console.WriteLine($"2. There is number {n2}");
for (int i = 1; i <= n2; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}