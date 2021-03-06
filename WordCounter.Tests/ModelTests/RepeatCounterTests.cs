using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;

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
    public void RepeatCounterConstructor_CheckAllNumericalAndSpecialCharacterInputsAccepted_SameString()
    {
      string word = "hI!";
      string sentence = "h3lLO!! wOR1d?";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      string expectedWord = "hi!";
      string expectedSentence = "h3llo!! wor1d?";
      Assert.AreEqual(expectedWord, newCounter.Word);
      Assert.AreEqual(expectedSentence, newCounter.Sentence);
    }

    [TestMethod]
    public void RepeatCounterConstructor_ReturnStringWithoutWhiteSpaces_TrimmedString()
    {
      string word = "   white ";
      string sentence = "   spaces    ";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      Assert.AreEqual("white", newCounter.Word);
      Assert.AreEqual("spaces", newCounter.Sentence);
    }

    [TestMethod]
    public void CheckIfEmpty_IfInputWordOrSentenceEmptyOrWhiteSpaceReturnTrue_True()
    {
      string word = "   ";
      string sentence = "";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool wordResult = newCounter.CheckIfEmpty(newCounter.Word);
      bool sentenceResult = newCounter.CheckIfEmpty(newCounter.Sentence);
      Assert.AreEqual(true, wordResult);
      Assert.AreEqual(true, sentenceResult);
    }

    [TestMethod]
    public void GetSplitString_ReturnStringArrayOfWords_StringArray()
    {
      string word = "one";
      string sentence = "three point one four one five!";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      string[] expected = new string[6] {"three", "point", "one", "four", "one", "five!"};
      CollectionAssert.AreEquivalent(expected, newCounter.GetSplitString(sentence));
    }

    [TestMethod]
    public void CheckForMultipleWords_IfSearchWordHasMultipleWordsReturnTrue_True()
    {
      string word = "one    two";
      string sentence = "three four";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool result = newCounter.CheckForMultipleWords(newCounter.Word);
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CheckIfSearchWordValid_ReturnTrueIfNotEmptyAndSingleWord_True()
    {
      string word = "one ";
      string sentence = "three point one four one";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      bool result = newCounter.CheckIfSearchWordValid(newCounter.Word);
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CountRepeats_Return0IfFullWordNotFound_0()
    {
      string word = "you";
      string sentence = "your you're joyous you!";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      int result = newCounter.CountRepeats();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CountRepeats_ReturnCountIfFullWordFound_2()
    {
      string word = "Hello";
      string sentence = "Hello! Hello and hello again. Hello.";
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      int result = newCounter.CountRepeats();
      Assert.AreEqual(2, result);
    }
  }
}