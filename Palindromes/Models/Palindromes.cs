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

    public string GetInput()
    {
      return _userInput;
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
