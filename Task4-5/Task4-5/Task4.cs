using System;

namespace test4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            double radius;
            do
            {
                Console.Write("Enter radius of circle: ");
                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Invalid radius, try again");
                }
            }
            while (radius <= 0);    

            double circleSquare = CalcualtingSquare(radius);
            double circleLength = CalculatingLength(radius);

            Console.WriteLine($" Radius: {radius}\n Square: {circleSquare}\n Length {circleLength}");

            CircleDraw(radius);


        }
        static double CalcualtingSquare(double radius)
        {
            double square = radius * radius * Math.PI;
            return square;
        }

        static double CalculatingLength(double radius)
        {
            double length = 2 * Math.PI * radius;
            return length;
        }

        static void CircleDraw(double radius)
        {
            bool toFillOrNot = false;
            string input;

            do
            {
                Console.Write("Do you want to fill the circle  y/n : ");
                input = Console.ReadLine().ToLower();
                if (input != "y" && input != "n")
                {
                    Console.WriteLine("Invalid reply, try again");
                }
                else if (input == "y")
                {
                    toFillOrNot = true;
                }
            }
            while (input != "y" && input != "n");

            Console.WriteLine();

            double radiusIn = radius - 0.4;
            double radiusOut = radius + 0.4;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < radiusOut; x += 0.5)
                {

                    double value = x * x + y * y;

                    if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                    {
                        Console.Write(".");
                    }
                    else if (toFillOrNot && value < radiusIn * radiusIn && value < radiusOut * radiusOut)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
