using System;

namespace Palindrome
{
    class Exec
    {
        static void Main(string[] args)
        {
            string word = "i did did i";
            string wordReversed;

            char[] wordCh = word.ToCharArray();
            Array.Reverse(wordCh);

            wordReversed = new string(wordCh);

            Console.WriteLine("Pabra Normal: " + word);
            Console.WriteLine("Pabra Alreves: " + wordReversed);
            Console.WriteLine();

            if (word == wordReversed)
            {
                Console.WriteLine(word + " : It is a palindrome yay!");
            }
            else
            {
                Console.WriteLine(word + " : it is not a palindrome");
            }

            Console.ReadLine();

        }
    }
}
