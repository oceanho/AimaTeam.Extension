
/***************************************************************
*
*   AimaTeam开源项目（版权所有：copyright@aimaTeam.com）       
*   Dear,我们真心希望您可以为我们保留的版权信息,o(∩_∩)o 
----------------------------------------------------------------
*   作   者：Mr.Hai
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

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串的文件路径,文件目录操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionDirectoryPath
    {
        private static readonly int backslashAscci = 47; // 反斜线 Ascci
        private static readonly int slashcharAscci = 92; // 正斜线 Ascci

        /// <summary>
        /// 获取目录的上一级磁盘路径（如果parentLevel大于了最大路径字符允许的最大的级别,返回根目录,否则返回parentLevel级的磁盘路径）
        /// </summary>
        /// <param name="path">磁盘路径字符串，比如：E:/project/opensrc/XX/XXXX/XX</param>
        /// <param name="parentLevel">上级目录的级别（如：上级 = ../,上上级 = ../../,每上一级增加一个../,某级下的子目录直接写为childrenA/childrenAc就可以了）</param>
        /// <returns></returns>
        public static string GetDirectoryPath(this string path, string parentLevel)
        {
            int intParentLevel = 0;
            string subVirtualPath = string.Empty;
            if (!string.IsNullOrEmpty(parentLevel))
            {
                if (!parentLevel.StartsWith("../"))
                    throw ExceptionUtility.Create<FormatException>("unsopport “{0}” starts with the parentLevel,should be {1}".Format2(parentLevel, "../"));
                intParentLevel = parentLevel.GetStringFindedCount("../");
                subVirtualPath = parentLevel.Substring((parentLevel.GetStringFindedCount("../") * 3));
            }
            return GetDirectoryPath(path, intParentLevel, subVirtualPath);
        }

        /// <summary>
        /// 获取目录的上一级磁盘路径（如果parentLevel大于了最大路径字符允许的最大的级别,返回根目录,否则返回parentLevel级的磁盘路径）
        /// </summary>
        /// <param name="path">磁盘路径字符串，比如：E:/project/opensrc/XX/XXXX/XX</param>
        /// <param name="parentLevel">上级目录的级别（如：上级 = 1,上上级 = 2,每上一级递增1）</param>
        /// <returns></returns>
        public static string GetDirectoryPath(this string path, int parentLevel)
        {
            EnsureUtility.IsNotNull(path, "path");
            if (parentLevel <= 0) return path;

            List<int> slashcharItemIndex = null;
            slashcharItemIndex = new List<int>();
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == backslashAscci || path[i] == slashcharAscci)
                    slashcharItemIndex.Add(i);
            }

            if (parentLevel >= slashcharItemIndex.Count)
                parentLevel = slashcharItemIndex[0];
            else
                parentLevel = slashcharItemIndex[slashcharItemIndex.Count - parentLevel];

            return path.Substring(0, parentLevel + 1);
        }

        /// <summary>
        /// 获取目录的上一级磁盘路径（如果parentLevel大于了最大路径字符允许的最大的级别,返回根目录,否则返回parentLevel级的磁盘路径）+subPath
        /// </summary>
        /// <param name="path">磁盘路径字符串，比如：E:/project/opensrc/XX/XXXX/XX</param>
        /// <param name="parentLevel">上级目录的级别（如：上级 = 1,上上级 = 2,每上一级递增1）</param>
        /// <param name="subVirtualPath">parentLevel的下级（下级/下....级的虚列目录路径，比如data/aimateam/blogs）</param>
        /// <returns></returns>
        public static string GetDirectoryPath(this string path, int parentLevel, string subVirtualPath)
        {
            EnsureUtility.IsNotNull(path, "path");
            if (parentLevel <= 0) return path;

            List<int> slashcharItemIndex = null;
            slashcharItemIndex = new List<int>();
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == backslashAscci || path[i] == slashcharAscci)
                    slashcharItemIndex.Add(i);
            }

            if (parentLevel >= slashcharItemIndex.Count)
                parentLevel = slashcharItemIndex[0];
            else
                parentLevel = slashcharItemIndex[slashcharItemIndex.Count - parentLevel];

            return path.Substring(0, parentLevel + 1).Concat2(subVirtualPath.Trim((char)slashcharAscci, (char)backslashAscci)).TrimEnd((char)slashcharAscci, (char)backslashAscci).Concat2('\\');
        }
    }
}
