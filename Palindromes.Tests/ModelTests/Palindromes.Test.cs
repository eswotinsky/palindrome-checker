using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.TestTools
{
  [TestClass]
  public class PalindromesTest
  {
    // [TestMethod]
    // //user input should not contain digits, ideally
    // public void InputCheck_InputContainsDigits_False()
    // {
    //   Palindrome testString = new Palindrome("a");
    //   Assert.AreEqual(false, testString.InputCheck());
    // }
    //
    // [TestMethod]
    // //user input should not contain digits, ideally
    // public void InputCheck_InputContainsDigits_True()
    // {
    //   Palindrome testString = new Palindrome("1");
    //   Assert.AreEqual(true, testString.InputCheck());
    // }
    [TestMethod]
    public void IsPalindrome_InputIsPalindrome_True()
    {
      Palindrome showInput = new Palindrome("b");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_TwoLetterPalindrome_False()
    {
      Palindrome showInput = new Palindrome("oh");
      Assert.AreEqual(false, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_ThreeLetterPalindrome_True()
    {
      Palindrome showInput = new Palindrome("aha");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_MultipleLetterPalindrome_True()
    {
      Palindrome showInput = new Palindrome("racecar");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_PalindromeWithSpaces_True()
    {
      Palindrome showInput = new Palindrome("race car");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_PalindromeWithSpaces_False()
    {
      Palindrome showInput = new Palindrome("french fry");
      Assert.AreEqual(false, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_PalindromeWithCharacters_False()
    {
      Palindrome showInput = new Palindrome("@#$%&*/?");
      Assert.AreEqual(false, showInput.IsPalindrome());
    }
  }
}
