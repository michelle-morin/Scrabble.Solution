using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void CheckScore_ReturnZeroForPluralWords_0()
    {
      int score = Word.CheckScore("hello there");
      Assert.AreEqual(0, score);
    }
    
    [TestMethod]
    public void CheckScore_ReturnScore_1()
    {
      int score = Word.CheckScore("a");
      Assert.AreEqual(1, score);
    }
  }
}