using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueQuestion = true;
            while (continueQuestion)
            {
                Console.WriteLine();
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int userinput = int.Parse(Console.ReadLine());

                int bread = 2;
                int butter = 2;
                int jelly = 4;
                int jarbutter = 32;
                int jarjelly = 48;
                double totalslicesneeded = 2 * userinput;
                double slicesperloaf = 28;
                double totalbutterneeded = 2 * userinput;
                double totaljellyneeded = 4 * userinput;

                double totalloafneeded = Math.Ceiling(totalslicesneeded / slicesperloaf);
                double totalbutter = Math.Ceiling(totalbutterneeded / jarbutter);
                double totaljelly = Math.Ceiling(totaljellyneeded / jarjelly);

                {
                    string message = "You need:";
                    Console.WriteLine();
                    Console.WriteLine(message);
                    Console.WriteLine();
                }
                {
                    Console.WriteLine((bread * userinput) + " Slices of Bread");
                    Console.WriteLine((butter * userinput) + " Tablespoons of Peanut Butter");
                    Console.WriteLine((jelly * userinput) + " Teaspoons of Jelly");
                    Console.WriteLine();
                    {
                        Console.WriteLine("Which is:");
                        Console.WriteLine();
                        Console.WriteLine(totalloafneeded + " Loaves of Bread");
                        Console.WriteLine(totalbutter + " Jars of Peanut Butter");
                        Console.WriteLine(totaljelly + " Jars of Jelly");
                        Console.WriteLine();

                        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                        string input = (Console.ReadLine());

                        if (input.ToLower() == "yes" || input.ToLower() == "y")
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("GoodBye!!!");
                            continueQuestion = false;
                            break;

                        }
                    }

                }

            }
        }
    }
}













