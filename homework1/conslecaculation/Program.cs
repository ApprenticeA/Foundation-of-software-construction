using System;

class Calculator
{
    static void Main()
    {
        Console.Write("请输入第一个数字：");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("请输入第二个数字：");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("请输入运算符 (+, -, *, /)：");
        char op = Console.ReadKey().KeyChar;

        double result;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("输入的运算符不合法！");
                return;
        }

        Console.WriteLine("\n计算结果为：{0}", result);
    }
}

