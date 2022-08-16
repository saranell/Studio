//Studio: Counting Characters
//Write a program to count the number of times each character occurs in a string and print the results.
Console.WriteLine("Hello");
namespace CountingCharacters
{
    public class Program
{
    static void Main(string[] args)
        {
    
            Dictionary<char, int> characterCount = new();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\nNunc accumsan sem ut ligula scelerisque sollicitudin.\nUt at sagittis augue. Praesent quis rhoncus justo.\nAliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa.\nVestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa.\nDonec nec velit non ligula efficitur luctus.";

            
            int count = 0;
            foreach (char letter in text)
            {
                count++;
            }

}

    }

}

