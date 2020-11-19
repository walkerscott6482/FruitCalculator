using System;

namespace Calculator
{
    class FruitCalculator
    {
        static void Main(string[] args)
        {
            double priceOranges = 0;
            double priceApples = 0;
            string promotions = string.Empty;
            double promotionsOranges = 0;
            double promotionsApples = 0;
            double numOranges = 0;
            double numApples = 0;
            double[] basket = new double[2];

            Console.WriteLine("Fruit Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Get orange price with user input
            Console.WriteLine("Price of Oranges: ");
            try
            {
                priceOranges = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Price of Oranges");
                EndProgram();
            }

            // Get apple price with user input
            Console.WriteLine("Price of Apples: ");
            try
            {
                priceApples = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Price of Apples");
                EndProgram();
            }

            // Promotions
            Console.WriteLine("Promotions: ");
            try
            {
                promotions = Console.ReadLine();
                if (string.IsNullOrEmpty(promotions))
                {
                    promotions = "No";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Promotions");
                EndProgram();
            }

            if (promotions != "No")
            {
                // Get promotions with user input
                Console.WriteLine("Promotions for Oranges (Enter zero for no promotions, press Enter): ");
                try
                {
                    promotionsOranges = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in Promotions for Oranges");
                    EndProgram();
                }

                // Get promotions with user input
                Console.WriteLine("Promotions for Apples (Enter zero for no promotions, press Enter): ");
                try
                {
                    promotionsApples = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in Promotions for Apples");
                    EndProgram();
                }
            }
            else
            {
                promotionsOranges = 0;
                promotionsApples = 0;
            }

            // Get number of oranges with user input
            Console.WriteLine("Number of Oranges: ");
            try
            {
                numOranges = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Number of Oranges");
                EndProgram();
            }

            // Get number of apples with user input
            Console.WriteLine("Number of Apples: ");
            try
            {
                numApples = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Number of Apples");
                EndProgram();
            }

            // Intialize basket array
            for (int i = 0; i < 2; i++)
            {
                basket[i] = i;
            }

            // Add fruit to the basket
            try
            {
                basket[0] = numOranges;
            }
            catch (FormatException e)
            {
                // Error handling if the input couldn't be parsed
                Console.WriteLine("Number of Oranges " + e.Message);
            }
            try
            {
                basket[1] = numApples;
            }
            catch (FormatException e)
            {
                // Error handling if the input couldn't be parsed
                Console.WriteLine("Number of Apples " + e.Message);
            }

            // Calculate the totals
            Console.WriteLine("Total price = " + (GetTotal(priceOranges, basket[0], promotionsOranges) + GetTotal(priceApples, basket[1], promotionsApples)));
            EndProgram();
        }

        static double GetTotal(double price, double number, double promotions)
        {
            // Calculate the total for fruit
            double total = 0;
            total = (price * number);
            if (promotions > 0)
                total *= promotions;
            return total;
        }

        static void EndProgram()
        {

            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Fruit Calculator console app...");
            Console.ReadKey();
            Environment.Exit(0);
        }        
    }
}
