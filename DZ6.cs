int SolutionOne(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите количество чисел, которые хотите ввести");
int NumberOfDigits = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[NumberOfDigits];
Console.WriteLine("Введите числа");
for (int i = 0; i < NumberOfDigits; i++)
{
    digits[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Чисел больше нуля: " + SolutionOne(digits));


void SolutionTwo(float b1, float k1, float b2, float k2)
{

    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    Console.WriteLine($"X = {x}, Y = {y}");
}
Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());
SolutionTwo(b1, k1, b2, k2);