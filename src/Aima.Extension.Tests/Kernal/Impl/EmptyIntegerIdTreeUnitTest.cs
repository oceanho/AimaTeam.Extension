using System;
using Xunit;
using System.Collections.Generic;

using Aima.Extension;
using Aima.Extension.Kernal.Tree.Impl;

namespace Aima.Extension.Tests.Kernal.Impl
{


    public class EmptyIntegerIdTreeUnitTest
    {
        [Fact]
        public void Instance()
        {
            List<MenuTree> menuTreeList = new List<MenuTree>();
            List<MenuTreeData> menuTreeDataList = new List<MenuTreeData>();
            menuTreeDataList.Add(new MenuTreeData { Name = "系统设置", LinkUrl = "/sys/settings", MenuIcon = "icon-add" });
            menuTreeDataList.Add(new MenuTreeData { Name = "系统设置", LinkUrl = "/sys/settings", MenuIcon = "icon-add" });
            menuTreeDataList.Add(new MenuTreeData { Name = "系统设置", LinkUrl = "/sys/settings", MenuIcon = "icon-add" });

            // IEnumerable<MenuTree> menuTrees = menuTreeDataList.ToTree();
            MenuTree menuTree = new MenuTree(menuTreeDataList);

            Type type = menuTree.DataType;
            MenuTreeV2 menuTreeV2 = new MenuTreeV2();

            menuTreeDataList.ToTree<MenuTreeV2>();

            // menuTree.ForEach()
            menuTree.ForEach((obj) =>
            {
                // obj.IsNullReference()
            });
        }
    }
}

namespace Aima.Extension.Tests.Kernal.Impl
{
    /// <summary>
    /// 菜单树数据对象
    /// </summary>
    public class MenuTreeData
    {
        public string Name { get; set; }
        public string LinkUrl { get; set; }
        public string MenuIcon { get; set; }
    }

    public class MenuTreeV2 : EmptyIntegerIdTree<MenuTreeV2, MenuTreeData>
    {
        public MenuTreeV2() : base(null)
        {

        }

        public string Name { get; set; }
        public string LinkUrl { get; set; }
        public string MenuIcon { get; set; }
    }

    public class MenuTree : EmptyIntegerIdTree<MenuTreeData>
    {
        public MenuTree(IEnumerable<MenuTreeData> menuTreeDataCollection) : base(menuTreeDataCollection)
        {

        }
        public string Name { get; set; }
        public string LinkUrl { get; set; }
        public string MenuIcon { get; set; }
    }
}