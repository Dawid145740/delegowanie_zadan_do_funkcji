using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj czas w sekundach:");
        int elapsedSeconds = Convert.ToInt32(Console.ReadLine());
        string formattedTime = FormatTime(elapsedSeconds);
        Console.WriteLine("Sformatowany czas: " + formattedTime);
    }

    static string FormatTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedHours = hours.ToString().PadLeft(2, '0');
        string formattedMinutes = minutes.ToString().PadLeft(2, '0');
        string formattedSeconds = remainingSeconds.ToString().PadLeft(2, '0');

        return $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    }
}
