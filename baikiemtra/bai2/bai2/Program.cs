using System;

interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();

        Console.WriteLine("nhap ban kinh hinh tron:");
        circle.Radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhap chieu rong hinh chu nhat:");
        rectangle.Width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhap chieu dai hinh chu nhat:");
        rectangle.Height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"dien tich hinh tron: {circle.CalculateArea():F2}");
        Console.WriteLine($"dien tich hinh chu nhat: {rectangle.CalculateArea():F2}");
    }
}