using Xunit;

namespace AimaTeam.Extension.Tests
{
    using AimaTeam.Extension;


    public class StringExtensionDirectoryPathUnitTest
    {
        [Fact]
        public void GetParentPath()
        {
            string _string = "E:\\data\\scripts\\js\\jquery";
            string _string2 = _string.GetDirectoryPath("../../typescripts");
            Assert.Equal(_string2, "E:\\data\\scripts\\typescripts\\");
        }
    }
}
