using System;
using Counter.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("This Word Counter will find the frequency of a word in a sentence!");
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
    if(tester.CheckIfSearchWordValid(wordInput))
    {
      return wordInput;
    }
    else{
      Console.WriteLine("Empty or multiple words to match not valid.  Please try again.");
      GetWordInput();
      return "Word Error";
    }
  }

  private static string GetSentenceInput()
  {
    RepeatCounter tester = new RepeatCounter();
    Console.WriteLine("Enter a sentence to search for matches.");
    string sentenceInput = Console.ReadLine();
    if(!tester.CheckIfEmpty(sentenceInput))
    {
      return sentenceInput;
    }
    else
    {
      Console.WriteLine("Empty sentence to search not valid.  Please try again.");
      GetSentenceInput();
      return ("Sentence Error");

    }
  }

  private static void PrintOutput(RepeatCounter counter)
  {
    Console.WriteLine($"Word to match: {counter.Word}");
    Console.WriteLine($"Sentence to search: {counter.Sentence}");
    Console.WriteLine($"Full Matches Found: {counter.CountRepeats()}");
  }
}