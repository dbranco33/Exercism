using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        /*Possible Bob's responses*/
        string yell         = "Whoa, chill out!";
        string question     = "Sure.";
        string noTalking    = "Fine. Be that way!";
        string anyElse      = "Whatever.";

        /*Testing the 'statement' directed to Bob*/
        
        //Tests if the 'statement' is a yell.
        if (statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement)
        {
            return yell;
        }
        //Tests if the 'statement' is a question.
        else if (statement.TrimEnd().EndsWith("?"))
        {
            return question;
        }
        //Tests if the 'statement' is saying nothing.
        else if (string.IsNullOrWhiteSpace(statement))
        {
            return noTalking;
        }
        //All other situations.
        else
        {
            return anyElse;
        }
    }
}