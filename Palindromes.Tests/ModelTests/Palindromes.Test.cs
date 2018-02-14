using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.TestTools
{
  [TestClass]
  public class PalindromesTest
  {
    [TestMethod]
    //user input should not contain digits, ideally
    public void InputCheck_InputContainsDigits_False()
    {
      Palindrome testString = new Palindrome("a");
      Assert.AreEqual(false, testString.InputCheck());
    }

    [TestMethod]
    //user input should not contain digits, ideally
    public void InputCheck_InputContainsDigits_True()
    {
      Palindrome testString = new Palindrome("1");
      Assert.AreEqual(true, testString.InputCheck());
    }

  }
}
