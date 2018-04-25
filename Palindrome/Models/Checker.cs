using System.Collections.Generic;
using System.Linq;
using System;

namespace Palindrome.Models
{
  public class WordCheck
  {
      private string _instance;
      public WordCheck(string instance)
      {
        _instance = instance;
      }

      public string GetPalindrome()
      {
        return _instance;
      }
      public bool ValidatePalindrome()
      {
      string original_instance = _instance.ToLower().Replace(" ","").Replace(",","").Replace("'","").Replace(".","").Replace("!","").Replace("?","").Replace("-","").Replace(")","").Replace("(","");; // original string
      char[] reverse_instance = _instance.ToLower().Replace(" ","").Replace(",","").Replace("'","").Replace(".","").Replace("!","").Replace("?","").Replace("-","").Replace(")","").Replace("(","").ToArray(); // convert to char array
      Array.Reverse(reverse_instance); // reverse the array
      string reverse_palindrome = string.Join("",reverse_instance);

      if(original_instance == reverse_palindrome)
      {
        return true;
      } else {
        return false;
      }
    }
    }
}
