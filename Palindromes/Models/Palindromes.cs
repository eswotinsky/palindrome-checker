using System;
using System.Text;
using System.Collections.Generic.IEnumerable;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Palindrome
  {
    private string _userInput;
    private string _reversedUserInput; // need to eventually set it to the reversed version of _userInput

    //Constructor
    public Palindrome(string userInput)
    {

      //convert userInput to charArray, reverse charArray, make _reversedUserInput = to string of char array.
      char[] chars = _userInput.ToCharArray();
      //newArray = userInput.ToCharArray
      char[] reversedUserInput = chars.Reverse();
      //reversedString = newArray.converttostring
      //_reversedUserInput = reversedString
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
    public bool UserInput()
    {
      bool isEqual = chars.SequenceEqual(reversedUserInput);

      if(isEqual)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
