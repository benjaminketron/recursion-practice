using System;
using System.Collections.Generic;
using System.Text;

namespace recursion
{
    public interface IRecursion
    {
        IEnumerable<string> AnagramPermutations(string word);        
        IEnumerable<string> AnagramPermutations_Iterative(string word, string purmutation = "");
        IEnumerable<string> AnagramPermutations_Tail(string word, string permutation = "");
    }
}
