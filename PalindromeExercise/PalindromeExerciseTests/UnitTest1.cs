using Microsoft.VisualStudio.TestPlatform.TestHost;
using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Taco cat", true)]
        [InlineData("Cody", false)]
        [InlineData("Step on no pets", true)]
        [InlineData("This is not a palindrome", false)]
        [InlineData("sagas", true)]
        [InlineData("raDAR", true)]
        public void Test1(string input, bool expected)
        {
            WordSmith challenge = new WordSmith();

            var actual = challenge.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
