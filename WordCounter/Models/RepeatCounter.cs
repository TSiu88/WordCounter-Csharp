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
      Word = word.ToLower().Trim();
      Sentence = sentence.ToLower().Trim();
      Count = 0;
    }

    public bool CheckIfEmpty()
    {
      if (Word == "" || Sentence == "")
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
      string[] splitSentence = GetSplitString(Sentence);
      foreach (string word in splitSentence)
      {
        if (word == Word)
        {
          Count++;
        }
      }
      return Count;
    }
  }
}