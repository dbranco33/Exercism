using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0; 
        int[] setOfValues = multiples.ToArray();
        //better than array cause we don't need to set a size.
        List<int> multipleValuesTaken = new List<int>(); 

        /*loop for all 'setOfValues' elements*/
        for(int i=0; i < setOfValues.Length; i++)
        {
            //in case the element value is smaller than 'max'
            if (setOfValues[i]<max)
            {
                //we loop until we reach the previous integer number before 'max'
                for (int j = setOfValues[i]; j < max; j++)
                {
                    //if the number is multiple and
                    //if the number has not been selected before.
                    if (j % setOfValues[i] == 0 && 
                        multipleValuesTaken.Contains(j) == false)
                    {
                        sum = sum + j;
                        //will hold all multiple numbers selected.
                        multipleValuesTaken.Add(j);
                    }
                }
            }
        }
        return sum;
    }
}