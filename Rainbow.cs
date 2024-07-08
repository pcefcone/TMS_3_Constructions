using System;



public class Rainbow
{
    public static void ChooseRainbowColor()
    {
        Console.WriteLine("Choose rainbow color: " +
            "\n1 - red" +
            "\n2 - orange" +
            "\n3 - yellow" +
            "\n4 - green" +
            "\n5 - blue" +
            "\n6 - dark blue" +
            "\n7 - violet");
        Console.Write("Your choose is: ");


        string rainbowColor = Console.ReadLine();
        
        bool parseSuccess = int.TryParse(rainbowColor, out int result);
                
        if (parseSuccess)
        {
            switch (result)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Color is red");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Color is orange");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Color is yellow");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Color is green");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Color is blue");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Color is darkBlue");
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Color is violet");
                    break;
                default:
                    Console.WriteLine("Bad color!");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine("Please press any key.");
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entered value must be a number!");
            Console.ResetColor();
        }
    }
}


