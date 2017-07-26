using System;
using System.Collections.Generic;

namespace recursion
{
    public class Recursion : IRecursion
    {
        public IEnumerable<string> AnagramPermutations(string word)
        {
            var result = new HashSet<string>();

            if (word != null)
            {
                if (word.Length == 1)
                {
                    result.Add(word);
                }
                else if (word.Length > 1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        var permutation = word.Substring(i, 1);
                        var subPermutations = AnagramPermutations(word.Remove(i, 1));
                        foreach (var subPermutation in subPermutations)
                        {
                            result.Add(permutation + subPermutation);
                        }
                    }
                }
            }

            return result;
        }

        public IEnumerable<string> AnagramPermutations_Iterative(string word, string permutation = "")
        {
            var result = new HashSet<string>();

            if (word != null)
            {
                if (word.Length == 1)
                {
                    result.Add(permutation + word);
                }
                else if (word.Length > 1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        var subPermutations = AnagramPermutations_Tail(word.Remove(i, 1), permutation + word.Substring(i, 1));
                        foreach (var subPermutation in subPermutations)
                        {
                            result.Add(subPermutation);
                        }
                    }
                }
            }

            return result;
        }

        public IEnumerable<string> AnagramPermutations_Tail(string word, string permutation = "")
        {
            var result = new HashSet<string>();

            if (word != null)
            {
                if (word.Length == 1)
                {
                    result.Add(permutation + word);
                }
                else if (word.Length > 1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        var subPermutations = AnagramPermutations_Tail(word.Remove(i, 1), permutation + word.Substring(i, 1));
                        foreach (var subPermutation in subPermutations)
                        {
                            result.Add(subPermutation);
                        }
                    }
                }
            }

            return result;
        }
    }
}
