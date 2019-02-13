using System;
using Scrabble.Models;
namespace Scrabble
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give me a word to score.");
            string input = Console.ReadLine().ToUpper();
            ScrabbleScorer newScorer = new ScrabbleScorer(input);
            newScorer.ScoreWord();
        }
    }
}