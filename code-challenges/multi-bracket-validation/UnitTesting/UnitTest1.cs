using System;
using Xunit;
using MultiBracketValidation;
using System.Runtime.InteropServices;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("{}{Code}[Fellows](())")]
        [InlineData("(){}[[]]")]
        public void CheckTrueValidations(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void CheckFalseValidations(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }

        [Fact]
        public void CheckBlankValidation()
        {
            Assert.True(Program.MultiBracketValidation(""));
        }
    }
}
