using System;

public class Answer
{

    public static void Solution1(int n)
    {
        if (n == 1)
        {
            Console.Write(n + " ");
        }
        else
        {
            Console.Write(n+" ");
            Solution1(n - 1);
        }

    }
    static void Print(int[] nums, int current = 0)
    {
        if (current == nums.Length) return;
        else
        {
            Console.Write(" " + nums[current++]);
            Print(nums, current);
        }
    }
    public static int Solution2(int n, int m)
    {
        int result = 0;
        while(n<=m)
        {
            result = result + m;
            m--;
        }
        return result;
    }

    static int Solution3(int m, int n)
    {
        
        if (m == 0)
        {
            return n + 1;
        }
        else if(m!=0 && n == 0)
        {
            return Solution3(m - 1, 1);
        }
        else
        {
            int mmm = Solution3(m, n - 1);
            return Solution3(m - 1, mmm);
        }
        
    }

     
    public static void Main(string[] args)
    {
        
        int n1 = 5;//Convert.ToInt32(Console.ReadLine());
        Solution1(n1);
        Console.WriteLine();
        Console.WriteLine();

        int n2 = 1;
        int m2 = 15;
        Console.WriteLine(Solution2(n2, m2));

        Console.WriteLine();

        int n3 = 2;
        int m3 = 3;
        int result = Solution3(m3, n3);
        Console.WriteLine(result);
    }
}