using System;

// 形状接口，包含计算面积和判断是否合法的方法
public interface IShape
{
    double GetArea();
    bool IsValid();
}

// 抽象形状类，实现了IShape接口中的IsValid方法
public abstract class Shape : IShape
{
    public abstract double GetArea();
    public abstract bool IsValid();
}

// 长方形类，继承自Shape抽象类
public class Rectangle : Shape
{
    public double width;
    public double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }

    public override bool IsValid()
    {
        return width > 0 && height > 0;
    }
}

// 正方形类，继承自Rectangle类
public class Square : Rectangle
{
    public Square(double side) : base(side, side) { }

    public override bool IsValid()
    {
        return width == height && width > 0;
    }
}

// 三角形类，继承自Shape抽象类
public class Triangle : Shape
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double GetArea()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public override bool IsValid()
    {
        return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    }
}

// 简单工厂类，用于创建不同类型的形状对象
public class ShapeFactory
{
    public static Shape CreateShape(string type, double[] args)
    {
        if (type.Equals("Rectangle"))
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("参数个数错误");
            }
            return new Rectangle(args[0], args[1]);
        }
        else if (type.Equals("Square"))
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("参数个数错误");
            }
            return new Square(args[0]);
        }
        else if (type.Equals("Triangle"))
        {
            if (args.Length != 3)
            {
                throw new ArgumentException("参数个数错误");
            }
            return new Triangle(args[0], args[1], args[2]);
        }
        else
        {
            throw new ArgumentException("不支持的形状类型");
        }
    }
}

// 测试代码
class Program
{
    static void Main(string[] Args)
    {
        // 随机创建10个形状对象，并计算它们的面积之和
        Random random = new Random();
        double totalArea = 0;
        for (int i = 0; i < 10; i++)
        {
            // 随机选择一种形状类型
            string type = random.Next(3) switch
            {
                0 => "Rectangle",
                1 => "Square",
                2 => "Triangle",
                _ => throw new Exception("不支持的形状类型")
            };

            // 随机生成形状参数，并创建形状对象
            double[] args = new double[3];
            for (int j = 0; j < args.Length; j++)
            {
                args[j] = random.NextDouble() * 10 + 1; // 生成1到11之间的随机数
            }

            try
            {
                // 使用简单工厂创建形状对象
                Shape shape = ShapeFactory.CreateShape(type, args);

                // 计算形状面积，并输出结果
                double area = shape.GetArea();
                Console.WriteLine($"第{i + 1}个形状为{type}，面积为{area}");
                totalArea += area;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"第{i + 1}个形状创建失败，原因是：{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"第{i + 1}个形状创建失败，原因是：{e.Message}");
            }
        }
        Console.WriteLine($"总面积为{totalArea}");
    }
}
