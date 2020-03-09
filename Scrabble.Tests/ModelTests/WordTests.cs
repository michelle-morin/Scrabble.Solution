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
      Word myWord = new Word("hello there");
      myWord.CheckScore();
      Assert.AreEqual(0, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_1()
    {
      Word myWord = new Word("a");
      myWord.CheckScore();
      Assert.AreEqual(1, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_5()
    {
      Word myWord = new Word("dog");
      myWord.CheckScore();
      Assert.AreEqual(5, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_7()
    {
      Word myWord = new Word("map");
      myWord.CheckScore();
      Assert.AreEqual(7, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_10()
    {
      Word myWord = new Word("yawn");
      myWord.CheckScore();
      Assert.AreEqual(10, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_13()
    {
      Word myWord = new Word("yuck");
      myWord.CheckScore();
      Assert.AreEqual(13, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsScore_12()
    {
      Word myWord = new Word("job");
      myWord.CheckScore();
      Assert.AreEqual(12, myWord.Score);
    }

    [TestMethod]
    public void CheckScore_ReturnsZScore_12()
    {
      Word myWord = new Word("zoo");
      myWord.CheckScore();
      Assert.AreEqual(12, myWord.Score);
    }
  }
}