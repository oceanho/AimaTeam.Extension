﻿using Xunit;

#if COREFX || DNX
using DescriptionAttribute = Aima.Extension.MissingfromDNX.DescriptionAttribute;
#endif
namespace Aima.Extension.Tests
{
    using Aima.Extension;
    using System.ComponentModel;

    public class EnumExtension4CommonUnitTest
    {
        [Fact]
        public void Instance()
        {
        }

        [Fact]
        public void GetEnumKey()
        {
            PlatformEnumtor platform = PlatformEnumtor.Linux;
            Assert.True(platform.GetEnumKey().EqualIgnoreCase("Linux"));
        }

        [Fact]
        public void GetEnumValue()
        {
            PlatformEnumtor platform = PlatformEnumtor.Linux;
            Assert.True(platform.GetEnumValue<int>() == 2);
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