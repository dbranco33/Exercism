using System;
using System.Collections.Generic;

public class NucleotideCount
{
    /*class variables*/

    //string variable to hold the 'strand'
    private string sequence;
    //dictionary of integers with char keys, it'll hold the possibles nucleotides.
    private IDictionary<char, int> nucleotides;

    public NucleotideCount(string sequence2)
    {
        if (!string.IsNullOrWhiteSpace(sequence2))
        {
            for (int i = 0; i < sequence2.Length; i++)
            {
                //throws an 'InvalidNucleotideException' in case of
                //the 'sequence2' has characters that are not valid nucleotides.
                if (sequence2[i] == 'A' ||
                    sequence2[i] == 'C' ||
                    sequence2[i] == 'G' ||
                    sequence2[i] == 'T')
                {
                    this.sequence = sequence2;
                }
                else
                {
                    throw new InvalidNucleotideException();
                }
            }
        }
        else
        {
            this.sequence = sequence2;
        }
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
                }
            }
            return nucleotides;
        }
    }
}

public class InvalidNucleotideException : Exception { }
