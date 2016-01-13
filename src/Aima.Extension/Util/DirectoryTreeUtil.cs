
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

using Aima.Extension.Kernal.Tree.Impl;
using System.Collections.Generic;
using System.IO;

namespace Aima.Extension.Util
{
    using Aima.Extension;
    /// <summary>
    /// DirectoryTree工具类
    /// </summary>
    internal sealed class DirectoryTreeUtil
    {
        /// <summary>
        /// 初始化DirectoryTree树的数据结构
        /// </summary>
        /// <param name="directoryTree">DirectoryTree初始化入口对象</param>
        /// <returns></returns>
        internal static void InitializerDirectoryTree(DirectoryTree directoryTree)
        {
            string virtualPath = directoryTree.VirtualPath;
            string physicalPath = Path.Combine(directoryTree.PhysicalPath, virtualPath);

            List<DirectoryTree> direcList = new List<DirectoryTree>();
            if (Directory.Exists(physicalPath))
            {
                directoryTree.TreeNodeType = DirectoryTreeNodeType.Directory;
                directoryTree.ParentID = directoryTree.ID;
                directoryTree.ID = physicalPath.GetMD5As16();

                FileSystemInfo[] fileSysInfoList = new DirectoryInfo(physicalPath).GetFileSystemInfos();
                foreach (FileSystemInfo fileSysInfo in fileSysInfoList)
                {
                    DirectoryTree childrenItem = new DirectoryTree(fileSysInfo.FullName, fileSysInfo.FullName.Substring(physicalPath.Length));

                    childrenItem.ParentID = directoryTree.ID;
                    childrenItem.ID = fileSysInfo.FullName.GetMD5As16();

                    if (fileSysInfo is DirectoryInfo)
                    {

                        childrenItem.TreeNodeType = DirectoryTreeNodeType.Directory;
                        childrenItem.NewChildrenTree(new DirectoryTree(fileSysInfo.FullName));

                        // childrenItem.SetChildren(InitChildTreeList(fileSysInfo.FullName, fileSysInfo.FullName.Substring(fileSysInfo.FullName.Length)));                        
                    }
                    else if (fileSysInfo is FileInfo)
                    {
                        childrenItem.TreeNodeType = DirectoryTreeNodeType.File;
                    }
                    directoryTree.NewChildrenTree(childrenItem);
                }
                directoryTree.PhysicalPath = physicalPath;
            }
            else
            {
                if (File.Exists(physicalPath))
                {
                    directoryTree.TreeNodeType = DirectoryTreeNodeType.File;
                }
            }
        }

        private static IEnumerable<DirectoryTree> InitChildTreeList(string physicalPath, string virtualPath)
        {
            List<DirectoryTree> direcList = new List<DirectoryTree>();
            if (Directory.Exists(physicalPath))
            {
                FileSystemInfo[] fileSysInfoList = new DirectoryInfo(physicalPath).GetFileSystemInfos();
                foreach (FileSystemInfo fileSysInfo in fileSysInfoList)
                {
                    direcList.Add(
                        new DirectoryTree(fileSysInfo.FullName,
                        virtualPath.TrimEnd('/', '\\') + "\\" + fileSysInfo.FullName.Substring(physicalPath.Length)){
                            ParentID = physicalPath.GetMD5As16(),
                            ID = fileSysInfo.FullName.GetMD5As16()
                        });
                }
            }
            else
            {
                if (File.Exists(physicalPath))
                {
                    direcList.Add(new DirectoryTree(physicalPath, virtualPath) { TreeNodeType = DirectoryTreeNodeType.File });
                }
            }
            return direcList;
        }
    }
}
