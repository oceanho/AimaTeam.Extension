using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4ParserUnitTest
    {
        [Fact]
        public void ParserTo()
        {
            string valid_NumericString = "123";
            string invalid_NumericString = "123a";
            Assert.True(valid_NumericString.ToInt() == 123);
            Assert.True(valid_NumericString.To<int>() == 123);


            // invalid
            // Assert.True(invalid_NumericString.ToInt() == -1);
            Assert.True(invalid_NumericString.ToInt(-1) == -1);            
        }
    }
}
