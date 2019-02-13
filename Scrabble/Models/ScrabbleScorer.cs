using System;
namespace Scrabble.Models
{
    public class ScrabbleScorer
    {
        private string Word;
        private char[] Letters;

        private char[] TierOne = 
        {'A','E','I','O','U','L','N','R','S','T'};
        private char[] TierTwo =
        {'D','G'};
        private char[] TierThree =
        {'B','C','M','P'};
        private char[] TierFour =
        {'F','H','V','W','Y'};
        private char[] TierFive =
        {'K'};
        private char[] TierSix =
        {'J','X'};
        private char[] TierSeven =
        {'Q','Z'};

        public ScrabbleScorer(string word)
        {
            Word = word.ToUpper();
            Letters = word.ToCharArray();
        }

        public string GetWord()
        {
            return Word;
        }
        public char[] GetTierOne()
        {
            return TierOne;
        }

        public bool Compare(char letter, char[] scoreCard)
        {
            for(var i=0; i<=scoreCard.GetUpperBound(0); ++i)
            {
                if(letter == scoreCard[i])
                {
                    return true;
                }
                else{}
            }
            return false;
        }

        public int GetLetterScore(char letter)
        {
            if(this.Compare(letter, TierOne))
            {
                return 1;
            }
            else if(this.Compare(letter, TierTwo))
            {
                return 2;
            }
            else if(this.Compare(letter, TierThree))
            {
                return 3;
            }
            else if(this.Compare(letter, TierFour))
            {
                return 4;
            }
            else if(this.Compare(letter, TierFive))
            {
                return 5;
            }
            else if(this.Compare(letter, TierSix))
            {
                return 8;
            }
            else if(this.Compare(letter, TierSeven))
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        public int ScoreWord()
        {
            int score = 0;
            foreach (char letter in Letters)
            {
                score += this.GetLetterScore(letter);
            }
            Console.WriteLine("Your scrabble score is " + score);
            return score;
        }
    }
}