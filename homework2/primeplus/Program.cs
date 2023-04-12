using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 100;
        bool[] isPrime = new bool[n + 1];

        // 初始化数组
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        // 埃氏筛法
        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // 输出素数
        Console.WriteLine("2~100以内的素数为：");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadKey();
    }
}

