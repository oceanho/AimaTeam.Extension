using Xunit;

#if COREFX || DNX
using DescriptionAttribute = Aima.Extension.MissingfromDNX.DescriptionAttribute;
#endif
namespace Aima.Extension.Tests
{
    using Aima.Extension;
    using System.ComponentModel;

    public class StringExtension4ByteParserUnitTest
    {
        [Fact]
        public void Instance()
        {
        }

        [Fact]
        public void GetBytesFromString()
        {            
        }

        [Fact]
        public void GetBytesFromStringByEncodingDefault()
        {
        }
    }
}
