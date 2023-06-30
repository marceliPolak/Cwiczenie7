using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę sekund: ");
        int seconds = int.Parse(Console.ReadLine());
        string formattedTime = FormatTime(seconds);
        Console.WriteLine("Wynik: " + formattedTime);
    }

    public static string FormatTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        return $"{hours:00}::{minutes:00}::{seconds:00}";
    }
}
