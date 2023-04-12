using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3, 4},
            {5, 1, 2, 3},
            {9, 5, 1, 2}
        };
        bool isToeplitz = true;

        // 判断每个元素是否和左上角的元素相同
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != matrix[i - 1, j - 1])
                {
                    isToeplitz = false;
                    break;
                }
            }
        }

        // 输出结果
        if (isToeplitz)
        {
            Console.WriteLine("是托普利茨矩阵");
        }
        else
        {
            Console.WriteLine("不是托普利茨矩阵");
        }

        Console.ReadKey();
    }
}

