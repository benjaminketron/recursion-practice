using recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace recursion_tests
{
    public class RecursionTests
    {
        [Theory]
        [InlineData(null, new string[] { })]
        [InlineData("", new string[] { })]
        [InlineData("a", new[] { "a" })]
        [InlineData("ab", new[] { "ab", "ba" })]
        [InlineData("abc", new[] { "abc", "acb", "bac", "bca", "cab", "cba" })]
        public void AnagramPermutations(string word, string [] expected)
        {
            var result = AnagramPermutations(word);
            Assert.Equal(expected, result);
        }

        public IEnumerable<string> AnagramPermutations(string word)
        {
            var recursion = new Recursion();
            return recursion.AnagramPermutations(word);
        }

        [Theory]
        [InlineData(null, new string[] { })]
        [InlineData("", new string[] { })]
        [InlineData("a", new[] { "a" })]
        [InlineData("ab", new[] { "ab", "ba" })]
        [InlineData("abc", new[] { "abc", "acb", "bac", "bca", "cab", "cba" })]
        public void AnagramPermutations_Tail(string word, string[] expected)
        {
            var result = AnagramPermutations_Tail(word);
            Assert.Equal(expected, result);
        }

        public IEnumerable<string> AnagramPermutations_Tail(string word)
        {
            var recursion = new Recursion();
            return recursion.AnagramPermutations_Tail(word);
        }

    }
}
