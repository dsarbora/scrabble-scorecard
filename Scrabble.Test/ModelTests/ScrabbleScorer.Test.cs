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
        public void ScrabbleScorer_GetsScore_Int()
        {
            char testChar = 'A';
            ScrabbleScorer test = new ScrabbleScorer("Doesn't matter");
            Assert.AreEqual (1, test.Score[testChar]);
        }
        [TestMethod]
        public void ScrabbleScorer_ScoresFullWord_Int()
        {
            string testString = "Lovely";
            ScrabbleScorer test = new ScrabbleScorer(testString.ToUpper());
            Assert.AreEqual(12, test.ScoreWord());
        }
    }
}