using System;
using System.IO;
using System.Text;

namespace Task4_modified
{
    class Program
    {
        static void Main(string[] args)
        {
            double axisX1;
            double axisY1;
            double axisX2;
            double axisY2;
            double zoom;
            const string UNDERLINE = "\x1B[4m";
            const string RESET = "\x1B[0m";

            Console.Write($"Press {UNDERLINE}ENTER{RESET} to use input data using keyboard or press {UNDERLINE}ANY KEY{RESET} to use file data: "); ;
            var check = Console.ReadLine();
            if (check == "")
            {
                Console.Write("Enter X1 coordinate: ");
                var temp_x1 = Console.ReadLine();
                while (!double.TryParse(temp_x1, out axisX1))
                {
                    Console.WriteLine("Invalid value, try again");
                    temp_x1 = Console.ReadLine();
                }

                Console.Write("Enter Y1 coordinate: ");
                var temp_y1 = Console.ReadLine();
                while (!double.TryParse(temp_y1, out axisY1))
                {
                    Console.WriteLine("Invalid value, try again");
                    temp_y1 = Console.ReadLine();
                }

                Console.Write("Enter X2 coordinate: ");
                var temp_x2 = Console.ReadLine();
                while (!double.TryParse(temp_x2, out axisX2))
                {
                    Console.WriteLine("Invalid value, try again");
                    temp_x2 = Console.ReadLine();
                }

                Console.Write("Enter Y2 coordinate: ");
                var temp_y2 = Console.ReadLine();
                while (!double.TryParse(temp_y2, out axisY2))
                {
                    Console.WriteLine("Invalid value, try again");
                    temp_y2 = Console.ReadLine();
                }
            }
            else
            {
                string path = @"C:\Users\nc_6d\source\repos\task4&5\Task4-5\Task4_modified\TextFile1.txt";
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {

                    axisX1 = Convert.ToDouble(sr.ReadLine());
                    axisY1 = Convert.ToDouble(sr.ReadLine());
                    axisX2 = Convert.ToDouble(sr.ReadLine());
                    axisY2 = Convert.ToDouble(sr.ReadLine());
                    
                }

            }
                        
            double radiusVector = Circle.VectorLength(axisX1, axisY1, axisX2, axisY2);
            double circleSquare = Circle.CircleSquare(radiusVector);
            double circleLength = Circle.CircleLength(radiusVector);
            
            Console.WriteLine($"\nCoordinates of radius-vector:\n x1: {axisX1}\t y1: {axisY1}\n x2: {axisX2}\t y2: {axisY2}\n");
            Console.WriteLine($" Coordinates of center: ({axisX1};{axisY1})\n Radius: {radiusVector}\n Square: {circleSquare}\n Length: {circleLength}\n ");


            Console.Write("Enter zoom factor: ");
            var temp_zoom = Console.ReadLine();
            while (!double.TryParse(temp_zoom, out zoom))
            {
                Console.WriteLine("Invalid value, try again");
                temp_zoom = Console.ReadLine();
            }

            double zoomedRadius = Circle.ZoomingTheCricle(ref radiusVector, ref zoom);
            double zoomedCircleSquare = Circle.CircleSquare(zoomedRadius);
            double zoomedCircleLength = Circle.CircleLength(zoomedRadius);

            Console.WriteLine($"\nCoordinates of zoomed radius-vector:\n x1: {axisX1}\t y1: {axisY1}\n x2: {axisX2 * zoom}\t y2: {axisY2 * zoom}\n");
            Console.WriteLine($" Coordinates of center: ({axisX1};{axisY1})\n Zoomed radius: {zoomedRadius}\n Zoomed square: {zoomedCircleSquare}\n Zoomed length: {zoomedCircleLength}\n ");
        }
    }
}
