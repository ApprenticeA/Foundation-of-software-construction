using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入一个正整数：");
        int num = int.Parse(Console.ReadLine());
        Console.Write(num + "的所有素数因子为：");

        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0 && IsPrime(i))
            {
                Console.Write(i + " ");
                num /= i;
            }
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

