using Xunit;

namespace AimaTeam.Extension.Tests
{
    using AimaTeam.Extension;


    public class StringExtensionParserUnitTest
    {
        [Fact]
        public void ParserTo()
        {
            string valid_NumberString = "123";
            string invalid_NumberString = "123a";
            Assert.True(valid_NumberString.ToInt() == 123);
            Assert.True(valid_NumberString.To<int>() == 123);


            // invalid
            // Assert.True(invalid_NumberString.ToInt() == -1);
            Assert.True(invalid_NumberString.ToInt(-1) == -1);            
        }
    }
}
