using Microsoft.VisualStudio.TestTools.UnitTesting;
//using RockPaperScissor.Models;
using Palindrome.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Palindrome.Tests
{
  [TestClass]
  public class StringTests
  {
    [TestMethod]
      public void PalindromeWord()
    {
      WordCheck word = new WordCheck("Car");
      Assert.AreEqual(true,word.ValidatePalindrome());

    }
    [TestMethod]
      public void PalindromeWordWithSpaces()
    {
      WordCheck word = new WordCheck(" Understanding ");
      Assert.AreEqual(true,word.ValidatePalindrome());
    }
    [TestMethod]
      public void PalindromeWordWithComma()
      {
        WordCheck word = new WordCheck("Goodbye,");
        Assert.AreEqual(true,word.ValidatePalindrome());
      }
    [TestMethod]
      public void PalindromeWordWithExclamationandSpaces()
      {
        WordCheck word = new WordCheck(" What ever! ");
        Assert.AreEqual(true,word.ValidatePalindrome());
      }
  }
}
