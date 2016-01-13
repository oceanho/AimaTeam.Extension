

/***************************************************************
*
*   爱码Team开源项目（版权所有：copyright@aimaTeam.com）       
*   作为开源项目，我们希望在您的项目中,可以保留以上版权,谢谢！
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

namespace Aima.Extension
{
    /// <summary>
    /// 字符串比较操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Comparer
    {
        /// <summary>
        /// 忽略大小写、比较两个字符串是否相等，相等返回True,否则返回False（Equals选项:StringComparison.OrdinalIgnoreCase）
        /// </summary>
        /// <param name="source">指定比较的字符</param>
        /// <param name="compareString">指定比较的参考字符</param>
        /// <returns></returns>
        public static bool EqualIgnoreCase(this string source, string compareString)
        {
            return source.Equals(compareString, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 忽略大小写、判断compareString中是否有任意一个字符串与source相等，相等返回True,否则返回False（Equals选项:StringComparison.OrdinalIgnoreCase）
        /// </summary>
        /// <param name="source">指定比较的字符</param>
        /// <param name="compareString">指定比较的参考字符</param>
        /// <returns></returns>
        public static bool EqualsAny(this string source, params string[] compareString)
        {
            foreach (var item in compareString)
            {
                if (source.EqualIgnoreCase(item)) return true;
            }
            return false;
        }
    }
}
