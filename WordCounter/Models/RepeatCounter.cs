using System;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public bool CheckIfEmpty()
    {
      if (Word.Trim() == "" || Sentence.Trim() == "")
      {
        return true;
      }
      return false;
    }
  }
}