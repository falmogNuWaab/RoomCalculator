using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "n";
            do
            {
                Console.WriteLine("Welcome to the Room Calculator");
                Console.WriteLine("In order to calculate your room, I will need some measurements");
                Console.Write("What is the Length of the Room? ");
                string input = Console.ReadLine();
                double rLength = double.Parse(input);
                Console.Write("What is the Length of the Room? ");
                input = Console.ReadLine();
                double rWidth = double.Parse(input);
                Console.Write("What is the Length of the Room? ");
                input = Console.ReadLine();
                double rHeight = double.Parse(input);

                double rArea = rLength * rWidth;
                double rPerimeter = (rLength + rWidth) * 2;

                Console.WriteLine($"Room Dimentions: L:{rLength} W:{rWidth} H:{rHeight}");
                Console.WriteLine($"Area: {rArea}");
                Console.WriteLine($"Perimeter: {rPerimeter}");


                double tPaint = (rPerimeter * rPerimeter) / 5;
                double tCarpet = (rArea / 5);
                double rVolume = rLength * rWidth * rHeight;
                Console.WriteLine($"Volume: {rVolume}");
                Console.WriteLine($"Carpet Tiles: {tCarpet}");
                Console.WriteLine($"Paint Cans: {tPaint}");

                Console.WriteLine("Continue? (y/n)");
                string ctinue = Console.ReadLine();
                if (ctinue == "y")
                {
                    response = "y";
                } else
                {
                    response = "n";
                }

            }
            while (response == "y");

        }
    }
}
