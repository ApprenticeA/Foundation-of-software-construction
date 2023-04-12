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
    private double width;
    private double height;

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

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }
}

// 正方形类，继承自Rectangle类
public class Square : Rectangle
{
    public Square(double side) : base(side, side) { }

    public override bool IsValid()
    {
        return Width == Height && Width > 0;
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

    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public double B
    {
        get { return b; }
        set { b = value; }
    }

    public double C
    {
        get { return c; }
        set { c = value; }
    }
}

// 测试代码
class Program
{
    static void Main(string[] args)
    {
        // 创建一个长方形对象
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine("长方形面积：" + rectangle.GetArea());

        // 创建一个正方形对象
        Square square = new Square(5);
        Console.WriteLine("正方形面积：" + square.GetArea());

        // 创建一个三角形对象
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("三角形面积：" + triangle.GetArea());

        // 修改长方形的宽度和高度
        rectangle.Width = 8;
        rectangle.Height = 6;
        Console.WriteLine("修改后的长方形面积：" + rectangle.GetArea());

        // 测试非法的三角形
        Triangle invalidTriangle = new Triangle(3, 4, 8);
        Console.WriteLine("非法三角形是否合法：" + invalidTriangle.IsValid());
    }
}

