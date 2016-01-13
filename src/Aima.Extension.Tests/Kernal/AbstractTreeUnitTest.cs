using System;
using Xunit;
using System.Collections.Generic;

using Aima.Extension;
using Aima.Extension.Kernal.Tree.Impl;

#if Net20UnitTest
using Aima.Extension.Net20.Missfrom;
#endif

namespace Aima.Extension.Tests.Kernal
{

    public class AbstractTreeUnitTest
    {
        [Fact]
        public void Instance()
        {
            IList<MenuTree> menuTreeList = MenuTreeUnitTestUtil.CreateUnitTestMenuTree();

            MenuTree tree = menuTreeList[0];
            List<MenuTree> childrenTree = new List<MenuTree>();
            //foreach (var item in tree.GetChildren<int, MenuTree>(1001))
            //{
            //    childrenTree.Add(item);
            //}
        }
    }
}

namespace Aima.Extension.Tests
{
    /// <summary>
    /// 定义一个用户测试的菜单树
    /// </summary>
    internal class MenuTree : AbstractTree<int, MenuTree>
    {
        public MenuTree(int id, int parentId, string url, string menuName, int sortNum)
            : this(id, parentId, null, url, menuName, sortNum)
        {

        }
        public MenuTree(int id, int parentId, IEnumerable<MenuTree> childCollection, string url, string menuName, int sortNum)
            : base(id, parentId, childCollection)
        {
            this.Url = url;
            this.Name = menuName;
            this.SortNum = sortNum;
        }
        public string Url { get; set; }
        public int SortNum { get; set; }
        public string Name { get; set; }

        public override Type DataType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void NewSiblingTree(MenuTree treeElement)
        {
            throw new NotImplementedException();
        }

        public override void NewChildrenTree(MenuTree treeElement)
        {
            throw new NotImplementedException();
        }

        public override void DeleteSiblingTree(int idValue)
        {
            throw new NotImplementedException();
        }

        public override void DeleteSiblingTree(Func<MenuTree, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override void DeleteChildrenTree(int idValue)
        {
            throw new NotImplementedException();
        }

        public override void DeleteChildrenTree(Func<MenuTree, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }

    internal class MenuData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentID { get; set; }
        public int SortNum { get; set; }
    }

    internal sealed class MenuTreeUnitTestUtil
    {
        internal static List<MenuTree> CreateUnitTestMenuTree()
        {
            List<MenuData> menuList = new List<MenuData>();
            for (int idStart = 1000; idStart < 1010; idStart++)
            {
                menuList.Add(CreateUnitTestMenuData(idStart,
                    idStart == 1000 ? 0 : idStart < 1005 ? 1000 : idStart > 1008 ? 1002 : 1001, 0));
            }
            return BuildMenuTreeList(menuList, 0, 1001);
        }

        private static MenuData CreateUnitTestMenuData(int id, int parentId, int childrenCount)
        {
            return new MenuData
            {
                ID = id,
                ParentID = parentId,
                SortNum = childrenCount,
                Name = "ParentID={0}".Format2(parentId),
                Url = "Url={0}".Format2("http://www.baidu.com")
            };
        }

        private static List<MenuTree> BuildMenuTreeList(IEnumerable<MenuData> menuList, params int[] menuParentID)
        {
            MenuTree menuTree = null;
            List<MenuTree> children = null;
            List<MenuTree> menuTreeList = new List<MenuTree>();
            IEnumerable<MenuData> menuRawList = GetChildrenMenu(menuList, menuParentID);
            IEnumerable<MenuData> childrenMenuData = null;
            foreach (var menu in menuRawList)
            {
                if (EqualsAnyParentID(menu.ParentID, menuParentID))
                {

                    children = new List<MenuTree>();
                    childrenMenuData = GetChildrenMenu(menuList, menu.ID);
                    foreach (var item in childrenMenuData)
                    {
                        children.Add(BuildMenuTree(item, menuList));
                    }
                    menuTree = new MenuTree(menu.ID, menu.ParentID, children, menu.Url, menu.Name, menu.SortNum);
                    menuTreeList.Add(menuTree);
                }
            }
            return menuTreeList;
        }

        private static MenuTree BuildMenuTree(MenuData menuData, IEnumerable<MenuData> menuList)
        {
            MenuTree menuTree = null;
            IEnumerable<MenuData> childrenMenuData = null;
            List<MenuTree> children = new List<MenuTree>();
            childrenMenuData = GetChildrenMenu(menuList, menuData.ID);
            foreach (var item in childrenMenuData)
            {
                children.Add(BuildMenuTree(item, menuList));
            }
            menuTree = new MenuTree(menuData.ID, menuData.ParentID, children, menuData.Url, menuData.Name, menuData.SortNum);
            return menuTree;
        }

        private static IEnumerable<MenuData> GetChildrenMenu(IEnumerable<MenuData> menuList, params int[] parentIdList)
        {
            foreach (var menu in menuList)
            {
                if (EqualsAnyParentID(menu.ParentID, parentIdList))
                {
                    yield return menu;
                }
            }
            yield break;
        }

        private static bool EqualsAnyParentID(int id, params int[] menuParentIdList)
        {
            foreach (var item in menuParentIdList)
            {
                if (item == id) return true;
            }
            return false;
        }
    }
}