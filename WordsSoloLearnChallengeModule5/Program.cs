using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // an array of strings 
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
            // bonus to get input from user what letter/word to search for and
            Console.WriteLine("This is your list of words:");
            foreach (var i in words)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pick a letter to search for");
            string letter = Console.ReadLine();

            //if count is still at 0 at the end we return "No Match"
            int count = 0;

            //write a for loop that checks each word in the array and returns the word if it contains the letter with an if statement
            // return the whole word, not just the found letter
            // append found words to a list
            // return list


            foreach (var i in words) //i represents the full word and we will search inside each word
            {
                if (i.Contains(letter))
                    {
                    Console.WriteLine(i);
                    count++;
                    //update the count

                }
            }
            if (count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
