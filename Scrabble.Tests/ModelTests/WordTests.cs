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
    public void CheckScore_ReturnsScore_1()
    {
      int score = Word.CheckScore("a");
      Assert.AreEqual(1, score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_5()
    {
      int score = Word.CheckScore("dog");
      Assert.AreEqual(5, score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_7()
    {
      int score = Word.CheckScore("map");
      Assert.AreEqual(7, score);
    }
  }
}