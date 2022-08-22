//3.8 Studio
//Write a program to count the number of times each character occurs in a string and print the results.
using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Super Bonus: Read the string in from a file.
            //Solution: Create text file & import the following class...
            //string exampleString = System.IO.File.ReadAllText( --> "local path to text file goes here" <-- );

            //string exampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\nNunc accumsan sem ut ligula scelerisque sollicitudin.\nUt at sagittis augue. Praesent quis rhoncus justo.\nAliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa.\nVestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa.\nDonec nec velit non ligula efficitur luctus.";
            //Bonus: Prompt the user to enter the string in the command line.
            Console.WriteLine("Enter some text to count the characters: ");
            string exampleString = Console.ReadLine();

            //Bonus: Make the character counts case-insensitive.
            char[] characters = exampleString.ToLower().ToCharArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in characters)
            {
                if (!counts.Keys.Contains(c))
                {
                    counts.Add(c, 1);
                }
                else
                {
                    counts[c]++;
                }
            }

                foreach (KeyValuePair<char, int> letter in counts)
                {
                    Console.WriteLine(letter.Key + ": " + letter.Value);
                }

                //Console.ReadLine();
        }
    }
}

