
/***************************************************************
*
*   AimaTeam开源项目（版权所有：copyright@aimaTeam.com）       
*   尽管它开源,我们真心希望您可以为我们保留的版权信息，谢谢
----------------------------------------------------------------
*   作   者：Hai he
*   日   期：2015/12/8 1:37:34
*   博   客：https://hehai.aimateam.com
*   说   明：
----------------------------------------------------------------
*
*   官方QQ群号：139849106
*   官方  网站：https://www.aimateam.com
****************************************************************/

using System;
using System.Collections.Generic;


using Aima.Extension;
using Aima.Extension.Util;
namespace Aima.Extension.Kernal.Tree.Impl
{
    /// <summary>
    /// 定义一个表示目录树结构的类
    /// </summary>
    public sealed class DirectoryTree : AbstractTree<string, DirectoryTree>
    {
        internal List<DirectoryTree> _childrenList;
        internal static readonly string _defaultVirtualPath = System.IO.Path.DirectorySeparatorChar.ToString();

        /// <summary>
        /// 初始化一个表示目录树结构的DirectoryTree对象
        /// </summary>
        /// <param name="physicalPath">物理路径，比如：E:\\wwwroot\\aimtem.com\\upload\\imgsource\\pro\\2015\\1215</param>
        public DirectoryTree(string physicalPath) : this(physicalPath, _defaultVirtualPath)
        {
        }

        /// <summary>
        /// 初始化一个表示目录树结构的DirectoryTree对象
        /// </summary>
        /// <param name="physicalPath">物理路径，比如：E:\\wwwroot\\aimtem.com</param>
        /// <param name="virtualPath">虚拟路径，比如（upload\\imgsource\\pro\\2015\\1215）</param>
        public DirectoryTree(string physicalPath, string virtualPath)
        {
            Ensure.IsNotNull(physicalPath, "physicalPath");
            if (virtualPath.IsNullOrEmp())
                virtualPath = _defaultVirtualPath;
            // base(physicalPath.Concat2(virtualPath).GetMD5As16(), physicalPath.Substring(0, physicalPath.Length - virtualPath.Length).GetMD5As16())
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            _childrenList = new List<DirectoryTree>();
            DirectoryTreeUtil.InitializerDirectoryTree(this);
        }

        /// <summary>
        /// 获取或者设置一个属性，该属性表示当前目录的虚拟路径，比如：/data/20151210/1124/001
        /// </summary>
        public string VirtualPath { get; internal set; }

        /// <summary>
        /// 获取或者设置一个属性，该属性表示当前目录的物理路径，比如：E:/usr/data/20151210/1124/001
        /// </summary>
        public string PhysicalPath { get; internal set; }

        /// <summary>
        /// 获取或者设置一个属性，该属性表示当前目录的物理路径，比如：DirectoryTreeNodeType.File
        /// </summary>
        public DirectoryTreeNodeType TreeNodeType { get; internal set; }

        /// <summary>
        /// 重写Children属性,如果需要对字节点进行控制,必须重写此Children属性与SetChildren()方法
        /// </summary>
        public override IEnumerable<ITree<string>> Children
        {
            get
            {
#if Net20
                return _childrenList as IEnumerable<ITree<string>>;
#else
                return _childrenList;
#endif
            }
        }

        /// <summary>
        /// 重写NewChildrenTree()方法以实现对子级节点的树进行操作
        /// </summary>
        /// <param name="treeElement">DirectoryTree树对象</param>
        public override void NewChildrenTree(DirectoryTree treeElement)
        {
            Ensure.IsNotNull(treeElement, "treeElement");
            Ensure.IsNotNull(treeElement.ParentID, "treeElement.ParentID");
            if (!treeElement.ParentID.Equals(ID))
                throw ExceptionUtil.Create<InvalidOperationException>(" treeElement.ParentID:{0} did not match this.ID:{1}".Format2(treeElement.ParentID, ID));

            if (_childrenList.Exists(m => m.ID.Equals(treeElement.ParentID)))
                throw ExceptionUtil.Create<InvalidOperationException>(" treeElement.ParentID:{0} has exists in CurrentTree,ID must be Unique ".Format2(treeElement.ParentID));

            _childrenList.Add(treeElement);
        }

        /// <summary>
        /// 重写DeleteChildrenTree()方法以实现对子级节点的删除操作
        /// </summary>
        /// <param name="idValue">节点ID</param>
        public override void DeleteChildrenTree(string idValue)
        {
            Ensure.IsNotNull(idValue, "idValue");
            int indexer = _childrenList.FindIndex(m => m.ID.Equals(idValue));
            if (indexer > -1)
            {
                _childrenList.RemoveAt(indexer);
            }
        }

        /// <summary>
        /// 重写DeleteChildrenTree()方法以实现对子级节点的删除操作
        /// </summary>
        /// <param name="predicate">条件断言</param>
        public override void DeleteChildrenTree(Func<DirectoryTree, bool> predicate)
        {
            for (int i = 0; i < _childrenList.Count; i++)
            {
                if (predicate(_childrenList[i]))
                {
                    _childrenList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// 重写NewSiblingTree()方法以实现对同级节点的树进行操作
        /// </summary>
        /// <param name="treeElement">DirectoryTree树对象</param>
        public override void NewSiblingTree(DirectoryTree treeElement)
        {
            throw new NotImplementedException();

            /*
            if (!treeElement.ParentID.Equals(this.ParentID))
                throw ExceptionUtil.Create<InvalidOperationException>("treeElement.ParentID:{0} Must Equals Current Tree's ParentID:{1}".Format2(treeElement.ID, ParentID));

            for (int i = 0; i < _childrenList.Count; i++)
            {
                if (_childrenList[i].ID.Equals(treeElement.ParentID))
                {
                    _childrenList.Add(treeElement);
                    break;
                }

                if (i == _childrenList.Count - 1) {
                    for (int j = 0; j < _childrenList.Count; j++)
                    {
                        for (int l = 0; l < _childrenList[j]._childrenList.Count; l++)
                        {
                            if (_childrenList[j]._childrenList[l].ID.Equals(treeElement.ParentID))
                            {
                                _childrenList[j]._childrenList[l]._childrenList.Add(treeElement);
                                break;
                            }
                        }
                    }
                }
            }   
            */
        }

        /// <summary>
        /// 重写DeleteSiblingTree()方法以实现对同级节点的删除操作
        /// </summary>
        /// <param name="idValue">节点ID</param>
        public override void DeleteSiblingTree(string idValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 重写DeleteSiblingTree()方法以实现对同级节点的删除操作
        /// </summary>
        /// <param name="predicate">条件断言</param>
        public override void DeleteSiblingTree(Func<DirectoryTree, bool> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 实现TreeType树形对象去实现
        /// </summary>
        public override Type DataType
        {
            get
            {
                return GetType();
            }
        }
    }

    /// <summary>
    /// 定义一个表示目录枚举级点类型的枚举
    /// </summary>
    public enum DirectoryTreeNodeType : byte
    {
        /// <summary>
        /// 表示当前目录节点是一个文件
        /// </summary>
        File = 1,

        /// <summary>
        /// 表示当前目录节点是一个未知类型
        /// </summary>
        UnKnow = 0,

        /// <summary>
        /// 表示当前节点是一个目录
        /// </summary>
        Directory = 2,
    }
}
