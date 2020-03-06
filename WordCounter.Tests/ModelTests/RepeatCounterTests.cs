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
    public void CheckIfEmpty_IfInputWordOrSentenceEmptyReturnTrue_True()
    {
      string word = "";
      string sentence = "";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool result = newCounter.CheckIfEmpty();
      Assert.AreEqual(true, result);
    }
  }
}