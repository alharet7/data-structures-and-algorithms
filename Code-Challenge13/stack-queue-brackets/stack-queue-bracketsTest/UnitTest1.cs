
using stack_queue_brackets;
using Xunit;

namespace stack_queue_bracketsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]

        public void TestIfItsBalanced(string p)
        {
            bool check = Program.ValidBrackets(p);
            Assert.True(check);
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]


        public void TestIfItsNotBalanced(string p)
        {
            bool check = Program.ValidBrackets(p);
            Assert.False(check);
        }
    }
}