using System;

  public static class TwoFer
  {
      public static string Name(string input = null)
      {
        string x;

        if (string.IsNullOrWhiteSpace(input))
        {
            x = "you";
        }
        else
        {
            x = input.Trim();
        }

        return "One for " + x + ", one for me.";
      }
  }
