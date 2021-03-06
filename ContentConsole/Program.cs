﻿using System;

namespace ContentConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            string content =
                "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";
            TextParser textParser = new TextParser();

            int badWordsCount =textParser.CountBadWords(content);

            Console.WriteLine("Scanned the text:");
            Console.WriteLine(content);
            Console.WriteLine("Total Number of negative words: " + badWordsCount);

            Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
        }
    }

}
