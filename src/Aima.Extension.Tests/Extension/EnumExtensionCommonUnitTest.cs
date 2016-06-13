using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AimaCore.Tests.Entities
{
    using Aima.Extension;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
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
