using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AimaCore.Tests.Entities
{
    using AimaTeam.Common;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class EnumInfoTest
    {
        [Fact]
        public void Instance()
        {

        }

        [Fact]
        public void EnumInfoCollectionTest()
        {
            var enums = new EnumInfoCollection<int>(typeof(Status));
            Assert.True(enums.Count == 3);
            Assert.True(enums.FirstOrDefault(p => p.Descriptor != null).Descriptor.Description == "哈喽,我是正常的Descriptor");
        }
    }
    public enum Status
    {
        [Display(Name = "正常")]
        [Description("哈喽,我是正常的Descriptor")]
        正常 = 0,
        已删除 = 1,
        已过期 = 2
    }
}
