using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;
using System;

namespace Counter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      string word = "hi";
      string sentence = "hello";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
    }

    [TestMethod]
    public void RepeatCounterConstructor_CheckConvertedToLowerCaseWhenConstructed_LowerCaseStrings()
    {
      string word = "hI";
      string sentence = "hElLO wORld";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      string expectedWord = "hi";
      string expectedSentence = "hello world";
      Assert.AreEqual(expectedWord, newCounter.Word);
      Assert.AreEqual(expectedSentence, newCounter.Sentence);
    }

    [TestMethod]
    public void TrimWhiteSpace_ReturnStringWithoutWhiteSpaces_TrimmedString()
    {
      string word = "   white ";
      string sentence = "   spaces    ";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      string trimmedWord = newCounter.TrimWhiteSpace(word);
      string trimmedSentence = newCounter.TrimWhiteSpace(sentence);
      Assert.AreEqual("white", trimmedWord);
      Assert.AreEqual("spaces", trimmedSentence);
    }

    [TestMethod]
    public void CheckIfEmpty_IfInputWordOrSentenceEmptyOrWhiteSpaceReturnTrue_True()
    {
      string word = "   ";
      string sentence = "";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool result = newCounter.CheckIfEmpty();
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CheckForMultipleWords_IfSearchWordHasMultipleWordsReturnTrue_True()
    {
      string word = "one    two";
      string sentence = "three four";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool result = newCounter.CheckForMultipleWords();
      Assert.AreEqual(true, result);
    }

    
  }
}