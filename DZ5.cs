using System.Runtime.Serialization.Formatters;

int SolutionOne(int[] Massive)
{
    int count = 0;
    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i] % 2 == 0) { count++; }
    }
    return count;
}
int[] MassiveOne = { 345, 897, 568, 234  };
Console.WriteLine(SolutionOne(MassiveOne));

int SolutionTwo(int[] Massive)
{
    int result = 0;
    for (int i = 1; i < Massive.Length; i = i + 2)
    {
        result += Massive[i];
    }
    return result;
}
int[] MassiveTwo = { 3, 7, 23, 12 };
Console.WriteLine(SolutionTwo(MassiveTwo));

double SolutionThree(double[] Massive)
{
    double result = 0;
    double max = Massive.Max();
    double min = Massive.Min();
    
    result = max - min;
    return result;
}
double[] MassiveThree = { 3.22, 4.2, 1.15, 77.15, 65.2 };
Console.WriteLine(SolutionThree(MassiveThree));