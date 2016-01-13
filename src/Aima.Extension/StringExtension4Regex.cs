
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
using System.Text.RegularExpressions;

namespace Aima.Extension
{
    using Util;

    /// <summary>
    /// 字符串的正则表达式操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Regex
    {        
        private static RegexOptions _defaultRegexOptions = RegexOptions.Compiled | RegexOptions.IgnoreCase;

#if Net20||Net40
        private static Regex _urlRegex = new Regex("", _defaultRegexOptions);
        private static Regex _mailRegex = new Regex("", _defaultRegexOptions);
        private static Regex _integerRegex = new Regex("^\\d+$", _defaultRegexOptions);
#else
        private static TimeSpan _defaultRegexTs = new TimeSpan(0, 0, 30);
        private static Regex _urlRegex = new Regex("", _defaultRegexOptions, _defaultRegexTs);
        private static Regex _mailRegex = new Regex("", _defaultRegexOptions, _defaultRegexTs);
        private static Regex _integerRegex = new Regex("^\\d+$", _defaultRegexOptions, _defaultRegexTs);
#endif

        /// <summary>
        /// 通过正则表达式验证指定字符是否满足pattern,满足返回true,否则返回false
        /// </summary>
        /// <param name="source">指定的源字符串</param>
        /// <param name="pattern">指定一个正则表达式匹配字符</param>
        /// <param name="regexOptions">指定一个正则表达式的选项枚举值</param>
        /// <returns></returns>
        public static bool IsRegexMath(this string source, string pattern, RegexOptions regexOptions)
        {
            Ensure.IsNotNull(source, "IsRegexMath(source)");
            return Regex.IsMatch(source, pattern, regexOptions);
        }

        /// <summary>
        /// 通过正则表达式验证指定字符是否满足pattern,满足返回true,否则返回false
        /// </summary>
        /// <param name="source">指定的源字符串</param>
        /// <param name="pattern">指定一个正则表达式匹配字符</param>
        /// <returns></returns>
        public static bool IsRegexMath(this string source, string pattern)
        {
            return source.IsRegexMath(pattern, _defaultRegexOptions);
        }
    }
}
