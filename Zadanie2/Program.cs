using System;

public class Program
{
    public static void Main(string[] args)
    {
        double x1, y1, x2, y2;

        RandomizeCoordinates(out x1, out y1, out x2, out y2);

        Console.WriteLine($"Punkt początkowy: ({x1:F2}, {y1:F2})");
        Console.WriteLine($"Punkt końcowy: ({x2:F2}, {y2:F2})");

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka: {distance:F2}");
    }

    public static void RandomizeCoordinates(out double x1, out double y1, out double x2, out double y2)
    {
        Random random = new Random();//Generowanie losowych współrzędnych 
        int min = -20;
        int max = 20;
        x1 = random.Next(min, max) / 2.0; 
        y1 = random.Next(min, max) / 2.0;
        x2 = random.Next(min, max) / 2.0;
        y2 = random.Next(min, max) / 2.0;
    }

    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        return distance;
    }
}
