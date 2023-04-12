using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int max = numbers[0];
        int min = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
