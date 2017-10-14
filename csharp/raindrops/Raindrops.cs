using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string message = "";
        /*Tests if the 'number' has:
         * 3 and/or 5 and/or 7 as a factor*/
        //I don't use 'else if' to guarantee 
        //that all tests be done. 
        if (number % 3 == 0)
        {
            message = "Pling";
        }

        if (number % 5 == 0)
        {
            message += "Plang";
        }

        if (number % 7 == 0)
        {
            message += "Plong";
        }

        if(string.IsNullOrWhiteSpace(message))
        {
            message = number.ToString();
        }

        return message;
    }
}