using System;
using Counter.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:.");
    Console.WriteLine("                                WORD COUNTER");
    Console.WriteLine("  This Word Counter will find the frequency of a word in a sentence!");
    Console.WriteLine(".:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:._.:*~*:.");
    string word = GetWordInput();
    string sentence = GetSentenceInput();
    RepeatCounter counter = new RepeatCounter(word, sentence);
    PrintOutput(counter);
  }

  private static string GetWordInput()
  {
    RepeatCounter tester = new RepeatCounter();
    Console.WriteLine("Enter a word to match for counts:");
    string wordInput = Console.ReadLine();
    if(!tester.CheckIfSearchWordValid(wordInput))
    {
      Console.WriteLine("Empty or multiple words to match not valid.  Please try again.");
      Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
      wordInput = GetWordInput();
    }
    return wordInput;
  }

  private static string GetSentenceInput()
  {
    RepeatCounter tester = new RepeatCounter();
    Console.WriteLine("Enter a sentence to search for matches.");
    string sentenceInput = Console.ReadLine();
    if(tester.CheckIfEmpty(sentenceInput))
    {
      Console.WriteLine("Empty sentence to search not valid.  Please try again.");
      Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
      sentenceInput = GetSentenceInput();
    }
    return sentenceInput;
  }

  private static void PrintOutput(RepeatCounter counter)
  {
    Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo. ~RESULTS~ .oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
    Console.WriteLine($"Word to match: {counter.Word}");
    Console.WriteLine($"Sentence to search: {counter.Sentence}");
    Console.WriteLine($"Full Matches Found: {counter.CountRepeats()}");
    Console.WriteLine(".oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.oOo.");
  }
}