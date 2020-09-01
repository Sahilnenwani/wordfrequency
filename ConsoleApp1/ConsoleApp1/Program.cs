using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("counting word frequency in a paragraph\n");

            string paragraph = "Submit the code for counting word frequency in a paragraph Submit only single .cs file the name of the file should be your id";

            string[] words = paragraph.ToLower().Split(' ');

            Dictionary<string, int> myDictionry = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!myDictionry.ContainsKey(word))
                {
                    myDictionry.Add(word, 1);
                }
                else
                {
                    myDictionry[word]++;
                }
            }

            foreach (string key in myDictionry.Keys)
            {
                Console.WriteLine(key + " : " + myDictionry[key] + "\n");

            }

            Console.ReadLine();

        }
    }

}
