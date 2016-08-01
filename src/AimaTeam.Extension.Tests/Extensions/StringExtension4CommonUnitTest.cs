using Xunit;

namespace AimaTeam.Extension.Tests
{
    using AimaTeam.Extension;


    public class StringExtensionCommonUnitTest
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
