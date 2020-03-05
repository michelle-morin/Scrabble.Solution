using System;

namespace Scrabble.Models
{
  public class Word
  {
    public static int CheckScore(string word)
    {
      string space = " ";
      if (word.Contains(space))
      {
        return 0;
      }
      else
      {
        int score = 0;
        char[] wordArray = word.ToLower().ToCharArray();
        for (int i=0; i<wordArray.Length; i++)
        {
          if (wordArray[i] == 'a' || wordArray[i] == 'e' || wordArray[i] == 'i' || wordArray[i] == 'o' || wordArray[i] == 'u' || wordArray[i] == 'l' || wordArray[i] == 'n' || wordArray[i] == 'r' || wordArray[i] == 's' || wordArray[i] == 't')
          {
            score += 1;
          }
          else if (wordArray[i] == 'd' || wordArray[i] == 'g')
          {
            score += 2;
          }
          else if (wordArray[i] == 'b' || wordArray[i] == 'c' || wordArray[i] == 'm' || wordArray[i] == 'p')
          {
            score += 3;
          }
        }
        return score;
      }

    }
  }
}