using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reverseWord = "";//will hold the reverse input.
        string[] myArray = new string[input.Length];//will hold the characters in 'input'.
        int counter = 0;

        //fills the 'myArray' with the 'input' characters.
        foreach (var character in input)
        {
            myArray[counter] = character.ToString();
            counter++;
        }

        //build the reverseWord string with the last to 
        //the first element at myArray.
        for (int i = myArray.Length; i > 0; i--)
        {
            reverseWord += myArray[i - 1];
        }

        //returns a string that's the inverse of 'input'.
        return reverseWord;
    }
}