using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      string userInput = AskForWord();
      ShowScore(userInput);
    }

    public static string AskForWord()
    {
      Console.WriteLine("Enter a word to check its scrabble score:");
      string userWord = Console.ReadLine();
      return userWord;
    }

    public static void ShowScore(string word)
    {
      try
      {
        int userScore = Word.CheckScore(word);
        if (userScore > 0)
        {
          Console.WriteLine($"{word} receives {userScore} points in Scrabble.");
        }
        else
        {
          throw new System.InvalidOperationException("invalid input");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}