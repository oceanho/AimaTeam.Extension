/*
 *
 *   Copyright © 2015-Presents AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
 *   mail：opensource@aimateam.org 
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

namespace AimaTeam.Extension
{
    /// <summary>
    /// 字符串比较操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionComparer
    {
        /// <summary>
        /// 忽略大小写、比较两个字符串是否相等，相等返回True,否则返回False（Equals选项:StringComparison.OrdinalIgnoreCase）
        /// </summary>
        /// <param name="src">指定比较的字符</param>
        /// <param name="compareString">指定比较的参考字符</param>
        /// <returns></returns>
        public static bool EqualIgnoreCase(this string src, string compareString)
        {
            return src.Equals(compareString, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// 忽略大小写、判断compareString中是否有任意一个字符串与src相等，相等返回True,否则返回False（Equals选项:StringComparison.OrdinalIgnoreCase）
        /// </summary>
        /// <param name="src">指定比较的字符</param>
        /// <param name="compareString">指定比较的参考字符</param>
        /// <returns></returns>
        public static bool EqualsAny(this string src, params string[] compareString)
        {
            foreach (var item in compareString)
            {
                if (src.EqualIgnoreCase(item)) return true;
            }
            return false;
        }
    }
}
