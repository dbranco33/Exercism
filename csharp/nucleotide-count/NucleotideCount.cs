using System;
using System.Collections.Generic;

public class NucleotideCount
{
    /*class variables*/

    //string variable to hold the 'strand'
    private string sequence;
    //dictionary of integers with char keys, it'll hold the possibles nucleotides.
    private IDictionary<char, int> nucleotides;

    public NucleotideCount(string sequence)
    {
        this.sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    { 
        get
        {

            if (nucleotides == null)
            {
                nucleotides = new Dictionary<char, int>
                {
                    ['A'] = 0,
                    ['C'] = 0,
                    ['G'] = 0,
                    ['T'] = 0
                    //or {'A',0}, {'C',0},{'G',0},{'T',0}
                };
                
                foreach (char key in sequence)
                {
                    if (nucleotides.ContainsKey(key))
                    {
                        nucleotides[key] += 1;
                        //or nucleotides[key]++;
                    }
                    
                    //not working, why??
                    if(!nucleotides.ContainsKey(key))
                    {
                        throw new InvalidNucleotideException();
                    }
                }
            }
            return nucleotides;
        }
    }
}

public class InvalidNucleotideException : Exception { }
