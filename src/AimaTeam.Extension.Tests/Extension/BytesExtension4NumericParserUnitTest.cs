using Xunit;

namespace AimaTeam.Extension.Tests
{
    public class BytesExtensionNumericParserUnitTest
    {
        [Fact]
        public void Instance()
        {

        }

        [Fact]
        public void ToInt32()
        {
            var intMaxBytes = new byte[] { 255, 255, 255, 127 };
            Assert.True(intMaxBytes.ToInt32() == int.MaxValue);

            Assert.True(new byte[] { 0, 255, 255, 255, 127 }.ToInt32(1) == int.MaxValue);

            Assert.True(new byte[] { 255, 255, 255 }.ToInt32(0, 127, true) == int.MaxValue);
        }
    }
}
