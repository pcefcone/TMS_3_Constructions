using System;

public class Month
{
    public static void ChooseMonthByNumber()
    {
        Console.Write("Введите номер месяца: ");
        string monthNumber = Console.ReadLine();
        int resultMonthNumber;
        bool parseSuccess = int.TryParse(monthNumber, out resultMonthNumber);

        if (parseSuccess)
        {
            switch (resultMonthNumber)
            {
                case 1:
                    Console.WriteLine("Month - January");
                    break;
                case 2:
                    Console.WriteLine("Month - February");
                    break;
                case 3:
                    Console.WriteLine("Month - March");
                    break;
                case 4:
                    Console.WriteLine("Month - April");
                    break;
                case 5:
                    Console.WriteLine("Month - May");
                    break;
                case 6:
                    Console.WriteLine("Month - June");
                    break;
                case 7:
                    Console.WriteLine("Month - July");
                    break;
                case 8:
                    Console.WriteLine("Month - August");
                    break;
                case 9:
                    Console.WriteLine("Month - September");
                    break;
                case 10:
                    Console.WriteLine("Month - October");
                    break;
                case 11:
                    Console.WriteLine("Month - November");
                    break;
                case 12:
                    Console.WriteLine("Month - December");
                    break;
                default:
                    Console.WriteLine("Incorect data! Please try again!");
                    break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entered value must be a number!");
            Console.ResetColor();
        }
        Console.WriteLine("Please press any key.");
        Console.ReadKey();
        Console.Clear();
    }
    public static void CheckTimeOfTheYear()
    {
        Console.Write("Put month number: ");
        string monthNumber = Console.ReadLine();
        int resultMonthNumber;
        bool parseSuccess = int.TryParse(monthNumber, out resultMonthNumber);

        if (parseSuccess)
        {
            if (resultMonthNumber == 12 || resultMonthNumber == 1 || resultMonthNumber == 2)
            {
                Console.WriteLine("Time of year - Winter");
            }
            else if (resultMonthNumber == 3 || resultMonthNumber == 4 || resultMonthNumber == 5)
            {
                Console.WriteLine("Time of year - Spring");
            }
            else if (resultMonthNumber == 6 || resultMonthNumber == 7 || resultMonthNumber == 8)
            {
                Console.WriteLine("Time of year - Summer");
            }
            else if (resultMonthNumber == 9 || resultMonthNumber == 10 || resultMonthNumber == 11)
            {
                Console.WriteLine("Time of year - Autumn");
            }
            else
            {
                Console.WriteLine("Choose number of month between 1 - 12");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect data! Please try again!");
            Console.ResetColor();
        }
        Console.WriteLine("Please press any key.");
        Console.ReadKey();
        Console.Clear();
    }
    public static void CheckMonthEven()
    {
        Console.Write("Put month number: ");
        string monthNumber = Console.ReadLine();
        int resultMonthNumber;
        bool parseSuccess = int.TryParse(monthNumber, out resultMonthNumber);

        if (parseSuccess)
        {
            if (Enumerable.Range(1, 12).Contains(resultMonthNumber))
            {
                if (resultMonthNumber % 2 == 0)
                {
                    Console.WriteLine("Month is even");
                }
                else
                {
                    Console.WriteLine("Month is odd");
                }
            }
            else
            {
                if (resultMonthNumber % 2 == 0)
                {
                    Console.WriteLine("It is not a month, but this number is even=))");
                }
                else
                {
                    Console.WriteLine("It is not a month, but this number is odd=))");
                }
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorect data! Please try again!");
            Console.ResetColor();
        }
        Console.WriteLine("Please press any key.");
        Console.ReadKey();
        Console.Clear();
    }
}

