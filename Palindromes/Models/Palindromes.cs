using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes.Models
{
  public class Palindrome
  {
    private string _userInput;

    //Constructor
    public Palindrome(string userInput)
    {
      _userInput = userInput.Replace(" ", ""); 
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

    public bool IsPalindrome()
    {
        int min = 0;
        int max = _userInput.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = _userInput[min];
            char b = _userInput[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
    }
  }
}
