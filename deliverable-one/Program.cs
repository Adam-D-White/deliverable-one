using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> dollarAmounts = new List<double>();



            Console.WriteLine("Please enter first dollar amount.");

            string userInput1 = Console.ReadLine();

            double newUserInput1 = Convert.ToDouble(userInput1);

            Console.WriteLine("Please enter the second dollar amount.");

            string userInput2 = Console.ReadLine();

            double newUserInput2 = Convert.ToDouble(userInput2);

            Console.WriteLine("Please enter the third dollar amount.");

            string userInput3 = Console.ReadLine();

            double newuserInput3 = Convert.ToDouble(userInput3);


            double result1 = (newUserInput1 + newUserInput2 + newuserInput3);

            Console.WriteLine($"Total: ${result1} \n" +
                $"In Japanese currency it would be-  {result1.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"))} \n" +
                $"In Swedish Currency it would be- {result1.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE"))} \n" +
                $"In Thai Currency it would be- {result1.ToString("C2", CultureInfo.CreateSpecificCulture("th-TH"))}\n" +
                $" ");

            double result2 = Math.Round(result1 / 3, 2);

            Console.WriteLine($"Average: ${result2}");



            dollarAmounts.Add(double.Parse(userInput1));
            dollarAmounts.Add(double.Parse(userInput2));
            dollarAmounts.Add(double.Parse(userInput3));

            dollarAmounts.Sort();

            Console.WriteLine($"Smallest Amount${dollarAmounts[0]}");

            dollarAmounts.Reverse();

            Console.WriteLine($"Largest Amount${dollarAmounts[0]}");

            Console.ReadLine();
        }
    }
}
