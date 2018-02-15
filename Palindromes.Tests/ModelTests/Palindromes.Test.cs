using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.TestTools
{
  [TestClass]
  public class PalindromesTest
  {

    [TestMethod]
    public void IsPalindrome_SingleLetterInput_True()
    {
      Palindrome showInput = new Palindrome("b");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_MultiLetterInput_False()
    {
      Palindrome showInput = new Palindrome("oh");
      Assert.AreEqual(false, showInput.IsPalindrome());
    }
    [TestMethod]
    public void IsPalindrome_MultiLetterInput_True()
    {
      Palindrome showInput = new Palindrome("aha");
      Assert.AreEqual(true, showInput.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindrome_InputWithSpaces_True()
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
    
  }
}
