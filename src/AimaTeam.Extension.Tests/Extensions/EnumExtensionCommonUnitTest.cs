using Xunit;

namespace AimaCore.Tests.Entities
{
    using AimaTeam.Extension;
    using System.Diagnostics;
    public class EnumExtensionCommonUnitTest
    {
        [Fact]
        public void Instance()
        {

        }

        [Fact]
        public void GetKeyTest()
        {
            Status normal = Status.正常;
            Assert.True(normal.GetKey()=="正常");
        }

        [Fact]
        public void GetEnumInfoCollectionTest()
        {
            Status normal = Status.正常;
            var enumInfoCollection = normal.GetEnumInfoCollection<int>();
            foreach (var item in enumInfoCollection)
            {
                Debug.WriteLine(item.Name);
            }
            Assert.True(enumInfoCollection.Count == 3);
        }
    }
}
