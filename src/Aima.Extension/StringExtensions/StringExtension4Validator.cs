
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
    /// 字符串验证操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Validator
    {
        private static readonly string _base64Regex = "^[a-z0-9+/]+$";
        /// <summary>
        /// 验证字符串是否是一个有效的Base64编码格式的字符串
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static bool IsValidBASE64String(this string src)
        {
            return src.IsRegexMath(_base64Regex, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
    }
}
