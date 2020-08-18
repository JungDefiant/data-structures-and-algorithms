using System;
using Xunit;

namespace RepeatedWords
{
    public class RepeatedWordsTest
    {
        [Fact]
        public void CheckRepeatedWords()
        {
            string str = "Once upon a time ,there was a brave princess who...";
            //string str = "Once upon a time, there was a brave princess who...";
            string word = RepeatedWords.CheckRepeatedWords(str);

            Assert.Equal("a", word);
        }

        [Fact]
        public void CheckSingleCharacter()
        {
            string str = "b b b b b b b b b b b b b b b b b c";
            string word = RepeatedWords.CheckRepeatedWords(str);

            Assert.Equal("b", word);
        }

        [Fact]
        public void CheckNullString()
        {
            string word = RepeatedWords.CheckRepeatedWords(null);

            Assert.Null(word);
        }
    }
}
