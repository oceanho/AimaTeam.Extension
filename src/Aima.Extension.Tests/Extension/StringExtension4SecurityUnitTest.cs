using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4SecurityUnitTest
    {
        [Fact]
        public void GetMD5_32()
        {
            string _string = "123456";
            string _md5_string = _string.GetMD5_32();
            Assert.Equal(_md5_string, "E10ADC3949BA59ABBE56E057F20F883E");
        }

        [Fact]
        public void GetMD5_16()
        {
            string _string = "123456";
            string _MD5_16_string = _string.GetMD5_16();
            Assert.Equal(_MD5_16_string, "49BA59ABBE56E057");
        }
    }
}
