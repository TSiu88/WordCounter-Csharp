using System;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public int Count {get; set; }
    public RepeatCounter(string word, string sentence)
    {
      Word = word.ToLower();
      Sentence = sentence.ToLower();
      Count = 0;
    }

    public string TrimWhiteSpace(string input)
    {
      return input.Trim();
    }

    public bool CheckIfEmpty()
    {
      if (TrimWhiteSpace(Word) == "" || TrimWhiteSpace(Sentence) == "")
      {
        return true;
      }
      return false;
    }

    public string[] GetSplitString(string input)
    {
      return input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    }

    public bool CheckForMultipleWords()
    {
      string[] splitWord = GetSplitString(Word);
      if (splitWord.Length > 1)
      {
        return true;
      }
      return false;
    }

    public int CountRepeats()
    {
      
      return Count;
    }
  }
}