using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static int PrintMenu()
        {
            string userInput = string.Empty;
            int menuSelection = -1;
            Console.Clear();
            Console.WriteLine("1. Convert time");
            Console.WriteLine("2. Exit");

            userInput = Console.ReadLine();
            try
            {
                menuSelection = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return menuSelection;
        }

        static double GetDateTime()
        {
            string userInput = string.Empty;
            double time = 0.00;

            while (time <= 0.00)
            {
                Console.WriteLine($"Enter the value of the time");
                userInput = Console.ReadLine();
                try
                {
                    time = Double.Parse(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured : {ex.Message}");
                }
            }
            return time;
        }

        static string[] GetConvertStrings()
        {
            string[] convertStrings = new string[2];
            Console.WriteLine("Enter the unit of the time you entered above");
            convertStrings[0] = Console.ReadLine();
            Console.WriteLine("Enter the unit of time you wish to convert to");
            convertStrings[1] = Console.ReadLine();
            return convertStrings;
        }


        public static void Main(string[] args)
        {
            bool exited = false;

            while (!exited)
            {
                int menuSelected = PrintMenu();
                while (menuSelected == -1)
                {
                    menuSelected = PrintMenu();
                }

                switch (menuSelected)
                {
                    case 1:
                        double time = GetDateTime();
                        string[] dateTimeStrings = GetConvertStrings();
                        try
                        {
                            double result = TimeConversion.Convert(time, dateTimeStrings[0], dateTimeStrings[1]);
                            Console.WriteLine($"The time of {time} {dateTimeStrings[0]} converted to {dateTimeStrings[1]} is {result} {dateTimeStrings[1]}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occured: {ex.Message}");
                        }
  
                        break;
                    case 2:
                        Console.WriteLine("Thank you, exiting now...");
                        exited = true;
                        break;
                }
                if (!exited)
                {
                    Console.WriteLine("press any key to continue to menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
