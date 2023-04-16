using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print out name and state
            string myName = "Adam Ulrich";
            string myState = "Washington";
            Console.WriteLine($"My name is {myName}. I am from {myState}.");

            // print out todays date (date only)
            var date = DateTime.Now;
            Console.WriteLine($"Today's date is {date:MM/dd/yyyy}");


            // print out days until christmas
            var christmasDay = new DateTime(date.Year, 12, 25);
            var daysUntilChristmas = christmasDay -  date;
            Console.WriteLine($"There are {daysUntilChristmas.Days} days until Christmas");

            //add code from 2.1 example
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            string widthString, heightString;
            do
            {
                Console.Write("Give the width of the window between " +
                MIN_WIDTH + " and " + MAX_WIDTH + " :");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);
            do
            {
                Console.Write("Give the height of the window between " +
                MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


            // add a press any key to continue
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }

}