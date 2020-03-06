using System;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public RepeatCounter(string word, string sentence)
    {
      Word = word.ToLower();
      Sentence = sentence.ToLower();
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

    public bool CheckForMultipleWords()
    {
      string[] splitWord = Word.Split(" ", StringSplitOptions.RemoveEmptyEntries);
      if (splitWord.Length > 1)
      {
        return true;
      }
      return false;
    }
  }
}