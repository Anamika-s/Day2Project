﻿namespace AbstractClassInterfaceDemo
{
    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    class Square : Shape
    {
        int side;

        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter side");
            side = Byte.Parse(Console.ReadLine());
        }
    }
    class Rectangle : Shape
    {
        int length, breadth;
        
        public override void GetDimensions()
        {
            Console.WriteLine("Enter length");
            length = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Byte.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }


    }
    //class Square
    //{
    //    int side;
    //    int area;
    //    public void GetDimensions()
    //    {
    //        Console.WriteLine("Enter side");
    //        side = Byte.Parse(Console.ReadLine());
    //    }
    //    public void CalculateArea()
    //    {
    //        area = side * side;
    //    }
    //    public void DisplayArea()
    //    {
    //        Console.WriteLine("Area is " + area);
    //    }
    //}

    //class Rectangle
    //{
    //    int length, breadth;
    //    int area;
    //    public void GetDimensions()
    //    {
    //        Console.WriteLine("Enter length");
    //        length = Byte.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter breadth");
    //        breadth = Byte.Parse(Console.ReadLine());
    //    }
    //    public void CalculateArea()
    //    {
    //        area = length * breadth;
    //    }
    //    public void DisplayArea()
    //    {
    //        Console.WriteLine("Area is " + area);
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape square = new Square();
            // square.GetDimensions();
            // square.CalculateArea();
            // square.DisplayArea();
            Shape shape;
            Console.WriteLine("Enter shape type");
            int c = Byte.Parse(Console.ReadLine());
            shape = new Square();

        }
    }
}