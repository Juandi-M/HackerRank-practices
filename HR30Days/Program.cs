using System;

namespace HR30Days
{
    class Program
    {
        /*
        //1st day
        static void Main(String[] args)
        {
            // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);

            Console.ReadLine();
        }
        */

        //2nd day

        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int a;
            double b;
            string c;

            // Read and save an integer, double, and String to your variables.

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToDouble(Console.ReadLine());

            c = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            int rInt = i + a;
            Console.WriteLine(rInt);

            // Print the sum of the double variables on a new line.
            double rDouble = d + b;
            //Formats output to force printing of 1 or 2 decimals even if its a whole Number.
            Console.WriteLine(string.Format("{0:0.0}", rDouble));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

            Console.WriteLine(s + c);

            //TextWriter.Flush();
            //TextWriter.Close();
        }
    }
}