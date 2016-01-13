using Xunit;

namespace Aima.Extension.Tests
{
    using Aima.Extension;


    public class StringExtension4CommonUnitTest
    {
        [Fact]
        public void GetStringFindedCount()
        {
            string rawString = "张三是一个好人,是一个好人啊";
            int findStringCount = rawString.GetStringFindedCount("好人");
            Assert.True(findStringCount == 2);
        }
    }
}
