using Xunit;

namespace AimaTeam.Extension.Tests
{
    using AimaTeam.Extension;


    public class StringExtensionEncodeAndDecodeUnitTest
    {
        [Fact]
        public void ToBase64String()
        {
            string rawString = "123";
            Assert.True(rawString.ToBase64String() == "MTIz");
        }

        [Fact]
        public void FromBase64ToString()
        {
            string rawBase64String = "MTIz";
            Assert.True(rawBase64String.FromBase64ToString() == "123");
        }
    }
}
