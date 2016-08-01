using Xunit;

namespace AimaTeam.Extension.Tests
{
    using AimaTeam.Extension;


    public class StringExtensionSecurityUnitTest
    {
        [Fact]
        public void GetMD5_32()
        {
            string _string = "123456";
            string _md5_string = _string.Get_md5();
            Assert.Equal(_md5_string, "E10ADC3949BA59ABBE56E057F20F883E");
        }

        [Fact]
        public void GetMD5_16()
        {
            string _string = "123456";
            string _MD5_16_string = _string.Get_md5Short();
            Assert.Equal(_MD5_16_string, "49BA59ABBE56E057");
        }
    }
}
