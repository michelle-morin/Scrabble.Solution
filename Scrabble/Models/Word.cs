using System;

namespace Scrabble.Models
{
  public class Word
  {
    public string InputWord { get; set; }
    public int Score { get; set; }

    public Word(string inputWord)
    {
      InputWord = inputWord;
      Score = 0;
    }

    public void CheckScore()
    {
      string space = " ";
      if (InputWord.Contains(space))
      {
        Score = 0;
      }
      else
      {
        char[] wordArray = InputWord.ToLower().ToCharArray();
        for (int i=0; i<wordArray.Length; i++)
        {
          if (wordArray[i] == 'a' || wordArray[i] == 'e' || wordArray[i] == 'i' || wordArray[i] == 'o' || wordArray[i] == 'u' || wordArray[i] == 'l' || wordArray[i] == 'n' || wordArray[i] == 'r' || wordArray[i] == 's' || wordArray[i] == 't')
          {
            Score += 1;
          }
          else if (wordArray[i] == 'd' || wordArray[i] == 'g')
          {
            Score += 2;
          }
          else if (wordArray[i] == 'b' || wordArray[i] == 'c' || wordArray[i] == 'm' || wordArray[i] == 'p')
          {
            Score += 3;
          }
          else if (wordArray[i] == 'f' || wordArray[i] == 'h' || wordArray[i] == 'v' || wordArray[i] == 'w' || wordArray[i] == 'y')
          {
            Score += 4;
          }
          else if (wordArray[i] == 'k')
          {
            Score += 5;
          }
          else if (wordArray[i] == 'j' || wordArray[i] == 'x')
          {
            Score += 8;
          }
          else if (wordArray[i] == 'q' || wordArray[i] == 'z')
          {
            Score += 10;
          }
        }
      }
    }
  }
}