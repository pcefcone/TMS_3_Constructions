using System;
internal class Program
{
    private static void Main(string[] args)
    {
        bool doOperation = true;

        while (doOperation)
        {
            Console.WriteLine("Choose operation: " +
                "\n1 - To check rainbow color" +
                "\n2 - To check month by number" +
                "\n3 - To check month even" +
                "\n4 - To check year part" +
                "\n5 - To check weather" +
                "\n6 - To exit program");
            Console.Write("Your choose is: ");
            int chooseOperation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOperation)
            {
                case 1:
                    Rainbow.ChooseRainbowColor();
                    break;
                case 2:
                    Month.ChooseMonthByNumber();
                    break;
                case 3:
                    Month.CheckMonthEven();
                    break;
                case 4:
                    Month.CheckTimeOfTheYear();
                    break;
                case 5:
                    Temperature.CheckWeather();
                    break;
                case 6:
                    Console.WriteLine("Bye Bye!");
                    doOperation = false;
                    Console.WriteLine("Please press any key to exit.");
                    Console.ReadKey();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bad choise! Please choose somethink!");
                    Console.ResetColor();
                    break;
            }

        }
    }
}