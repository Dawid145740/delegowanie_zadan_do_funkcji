using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego ''[x] [y]'':");
        string[] startPoint = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(startPoint[0]);
        double y1 = Convert.ToDouble(startPoint[1]);

        Console.WriteLine("Podaj współrzędne punktu końcowego ''[x] [y]'':");
        string[] endPoint = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(endPoint[0]);
        double y2 = Convert.ToDouble(endPoint[1]);

        double length = CalculateLength(x1, y1, x2, y2);

        Console.WriteLine("Długość odcinka wynosi: " + length);
    }

    static double CalculateLength(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double length = Math.Sqrt(dx * dx + dy * dy);
        return length;
    }
}
