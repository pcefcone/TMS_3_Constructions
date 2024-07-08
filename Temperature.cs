using System;

public class Temperature
{
    public static void CheckWeather()
    {
        Console.Write("Введите температуру: ");
        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp <= -20)
        {
            Console.WriteLine("Cold weather");
        }
        else if (temp > -20 || temp < -5)
        {
            Console.WriteLine("Normal weather");
        }
        else if (temp >= -5)
        {
            Console.WriteLine("Hot temp");
        }
        else
        {
            Console.WriteLine("Incorect data! Please try again!");
        }
        Console.WriteLine("Please press any key.");
        Console.ReadKey();
        Console.Clear();
    }
}
