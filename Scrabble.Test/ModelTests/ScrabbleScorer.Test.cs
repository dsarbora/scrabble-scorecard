using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleScorerTest
    {
        [TestMethod]
        public void ScrabbleScorer_AcceptsInput_String()
        {
            string testString = "Player";
            ScrabbleScorer test = new ScrabbleScorer(testString);
            string testStringUpper = testString.ToUpper();
            Assert.AreEqual(testStringUpper, test.GetWord());
        }
        [TestMethod]
        public void ScrabbleScorer_Compare_True()
        {
            string testString = "sample";
            ScrabbleScorer test = new ScrabbleScorer(testString);
            Assert.AreEqual (true, test.Compare('A', test.GetTierOne()));
        }
        [TestMethod]
        public void ScrabbleScorer_GetLetterScore_Int()
        {
            char testChar = 'A';
            ScrabbleScorer test = new ScrabbleScorer("Lovely");
            Assert.AreEqual(1, test.GetLetterScore(testChar));
        }
        
    }

}