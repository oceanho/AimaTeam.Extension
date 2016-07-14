/*
 *
 *   Copyright © 2015-Presents AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
  
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.org
 *   
 *   Licensed to the AimaTeam Open Source under one or more agreements.
 *   The AimaTeam Open Source licenses this file to you under the MIT license. 
 *   
 *   The MIT License
 *   
 *   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 *   documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
 *   the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
 *   to permit persons to whom the Software is furnished to do so, subject to the following conditions:　　
 *   The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 *   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
 *   THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 *   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 *   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 */

using System;
using System.Text.RegularExpressions;

namespace AimaTeam.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串的正则表达式操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionRegex
    {        
        private static RegexOptions _defaultRegexOptions = RegexOptions.Compiled | RegexOptions.IgnoreCase;

#if Net40
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
        /// <param name="src">指定的源字符串</param>
        /// <param name="pattern">指定一个正则表达式匹配字符</param>
        /// <param name="regexOptions">指定一个正则表达式的选项枚举值</param>
        /// <returns></returns>
        public static bool IsRegexMath(this string src, string pattern, RegexOptions regexOptions)
        {
            EnsureUtility.IsNotNull(src, "IsRegexMath(src)");
            return Regex.IsMatch(src, pattern, regexOptions);
        }

        /// <summary>
        /// 通过正则表达式验证指定字符是否满足pattern,满足返回true,否则返回false
        /// </summary>
        /// <param name="src">指定的源字符串</param>
        /// <param name="pattern">指定一个正则表达式匹配字符</param>
        /// <returns></returns>
        public static bool IsRegexMath(this string src, string pattern)
        {
            return src.IsRegexMath(pattern, _defaultRegexOptions);
        }
    }
}
