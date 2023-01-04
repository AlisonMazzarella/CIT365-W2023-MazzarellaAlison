using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //variable to hold name 
            string name = "Alison";

            //variable to hold location
            string location = "Georgia";

            //display variables with string interpolation 
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My location is " + location);

            //current date without time
            DateTime dateAndTime = DateTime.Now;
            Console.WriteLine("Todays date is: " + dateAndTime.ToString("dd/MM/yyyy"));

            //days till Christmas this year 
            int daysTillChristmas = (Convert.ToDateTime("12/25/2023").Date - DateTime.Now.Date).Days;
            Console.WriteLine("There are this many days left until Christmas: " + daysTillChristmas);

            //exercise from 2.1 in Yellow Book 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width of the wood in metres: ");

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height for the wood in metres: ");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();





        }
    }
}

