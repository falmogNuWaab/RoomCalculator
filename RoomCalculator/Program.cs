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
                Console.Write("What is the Width of the Room? ");
                input = Console.ReadLine();
                double rWidth = double.Parse(input);
                Console.Write("What is the Height of the Room? ");
                input = Console.ReadLine();
                double rHeight = double.Parse(input);

                double rArea = rLength * rWidth;
                double rPerimeter = (rLength + rWidth) * 2;
                double rVolume = rLength * rWidth * rHeight;
                double tPaint = (rPerimeter * rHeight) / 5;
                double tCarpet = (rArea / 5);


                Console.WriteLine($"\n\nRoom Dimentions: L:{rLength} W:{rWidth} H:{rHeight}");
                Console.WriteLine($"Area: {rArea}");
                Console.WriteLine($"Perimeter: {rPerimeter}");
                Console.WriteLine($"Volume: {rVolume}");
                Console.WriteLine("\n=============\n| Materials |\n=============\n");
                Console.WriteLine($"Carpet Tiles: {tCarpet}");
                Console.WriteLine($"Paint Cans: {tPaint}");

                Console.Write("Continue? (y/n)");
                input = Console.ReadLine();
                string ctinue = input.ToLower();

                if (ctinue.Contains("y"))
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
