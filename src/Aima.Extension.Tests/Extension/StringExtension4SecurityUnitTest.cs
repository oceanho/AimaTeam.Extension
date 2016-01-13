using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4SecurityUnitTest
    {
        [Fact]
        public void GetMD5As32()
        {
            string _string = "123456";
            string _md5_string = _string.GetMD5As32();
            Assert.Equal(_md5_string, "E10ADC3949BA59ABBE56E057F20F883E");
        }

        [Fact]
        public void GetMD5As16()
        {
            string _string = "123456";
            string _md5As16_string = _string.GetMD5As16();
            Assert.Equal(_md5As16_string, "49BA59ABBE56E057");
        }
    }
}
