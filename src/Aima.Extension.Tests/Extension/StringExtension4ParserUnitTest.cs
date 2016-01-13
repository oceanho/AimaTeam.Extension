using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4ParserUnitTest
    {
        [Fact]
        public void Parser2()
        {
            string valid_NumericString = "123";
            string invalid_NumericString = "123a";
            Assert.True(valid_NumericString.Parser2Int() == 123);
            Assert.True(valid_NumericString.Parser2<int>() == 123);


            // invalid
            // Assert.True(invalid_NumericString.Parser2Int() == -1);
            Assert.True(invalid_NumericString.Parser2Int(-1) == -1);            
        }
    }
}
