using System;

namespace test4 
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            double axisX1;
            double axisY1;
            double axisX2;
            double axisY2;
            double zoom;


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

            double radiusVector = VectorLength(axisX1, axisY1, axisX2, axisY2);
            double circleSquare = CircleSquare(radiusVector);
            double circleLength = CircleLength(radiusVector);
            
            Console.WriteLine($"\nCoordinates of radius-vector:\n x1: {axisX1}\t y1: {axisY1}\n x2: {axisX2}\t y2: {axisY2}\n");
            Console.WriteLine($" Coordinates of center: ({axisX1};{axisY1})\n Radius: {radiusVector}\n Square: {circleSquare}\n Length: {circleLength}\n ");


            Console.Write("Enter zoom factor: ");
            var temp_zoom = Console.ReadLine();
            while (!double.TryParse(temp_zoom, out zoom))
            {
                Console.WriteLine("Invalid value, try again");
                temp_zoom = Console.ReadLine();
            }
                        
            double zoomedRadius = ZoomingTheCricle(ref radiusVector, ref zoom);
            double zoomedCircleSquare = CircleSquare(zoomedRadius);
            double zoomedCircleLength = CircleLength(zoomedRadius);

            Console.WriteLine($"\nCoordinates of zoomed radius-vector:\n x1: {axisX1}\t y1: {axisY1}\n x2: {axisX2 * zoom}\t y2: {axisY2 * zoom}\n");
            Console.WriteLine($" Coordinates of center: ({axisX1};{axisY1})\n Zoomed radius: {zoomedRadius}\n Zoomed square: {zoomedCircleSquare}\n Zoomed length: {zoomedCircleLength}\n ");

        }

        static double VectorLength(double x1, double y1, double x2, double y2)
        {
            double stdVector = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return stdVector;
        }
        static double CircleSquare(double r)
        {
            double square = r * r * Math.PI;
            return square;
        }

        static double CircleLength(double r)
        {
            double length = 2 * Math.PI * r;
            return length;
        }

        static double ZoomingTheCricle(ref double radiusVector, ref double zoom)
        {
            double zoomedRadiusVector = radiusVector * zoom;
            return zoomedRadiusVector;
        }

    }
}
