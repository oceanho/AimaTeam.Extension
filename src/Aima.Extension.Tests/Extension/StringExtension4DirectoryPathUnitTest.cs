using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4DirectoryPathUnitTest
    {
        [Fact]
        public void Instance() {
        }

        [Fact]
        public void GetParentPath()
        {
            string _string = "E:\\data\\scripts\\js\\jquery";
            string _string2 = _string.GetDirectoryPath("../../typescripts");
            Assert.Equal(_string2, "E:\\data\\scripts\\typescripts\\");
        }
    }
}
