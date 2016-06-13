using Xunit;


namespace Aima.Extension.Tests
{
    using Aima.Extension;
    using System.ComponentModel;

    public class EnumExtensionCommonUnitTest
    {
        [Fact]
        public void Instance()
        {
        }

        [Fact]
        public void GetEnumKey()
        {
            PlatformEnumtor platform = PlatformEnumtor.Linux;
            Assert.True(platform.GetKey().EqualIgnoreCase("Linux"));
        }

        [Fact]
        public void GetEnumValue()
        {
            PlatformEnumtor platform = PlatformEnumtor.Linux;
            Assert.True(platform.GetValue<int>() == 2);
        }

        [Fact]
        public void GetDescriptorText()
        {
            PlatformEnumtor platform = PlatformEnumtor.Windows;
            Assert.True(platform.GetDescriptorText().EqualIgnoreCase("Windows Platform"));
            Assert.True(PlatformEnumtor.Linux.GetDescriptorText().EqualIgnoreCase(string.Empty));
        }
    }

    public enum PlatformEnumtor : int
    {
        [Description("Windows Platform")]
        Windows = 1,
        Linux = 2,
        Unix = 3
    }
}
