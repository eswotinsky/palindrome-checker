using System;
using System.Text;

using System.Linq;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Palindrome
  {
    private string _userInput;

    public Palindrome(string userInput)
    {
      _userInput = userInput;
    }
    public bool InputCheck()
    {
      bool UserInputHasDigits = _userInput.All(char.IsDigit);

      if(UserInputHasDigits)
      {
        return true; //and prompt user to enter a word
      }
      else
      {
        return false;
      }
    }
  }

}
