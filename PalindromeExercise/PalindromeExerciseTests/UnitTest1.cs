using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("noon", true)]
        [InlineData("civic",true )]
        [InlineData("dog", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //arrange instance
            var wordsmith = new WordSmith();
            //act
            var actual = wordsmith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
