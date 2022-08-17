//Studio: Counting Characters
//Write a program to count the number of times each character occurs in a string and print the results.
using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\nNunc accumsan sem ut ligula scelerisque sollicitudin.\nUt at sagittis augue. Praesent quis rhoncus justo.\nAliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa.\nVestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa.\nDonec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> count = new();

            foreach (char letter in text)
            {
                if (!count.Keys.Contains(letter))
                {
                    count.Add(letter, 1);
                }
                else
                {
                    count[letter]++;
                }


                foreach (KeyValuePair<char, int> count in count)
                {
                    Console.WriteLine(count.Key + ": " + count.Value);
                }
            }
        }
    }

}

