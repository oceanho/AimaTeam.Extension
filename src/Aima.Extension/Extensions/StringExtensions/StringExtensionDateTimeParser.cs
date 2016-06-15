/*
 *
 *   Copyright © 2015-2115 AimaTeam
 * 
 *   author：he hai
 *   time：2015/01/01 09:09:09
 *   mail：OpenSource@AimaTeam.com 
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.com
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
namespace Aima.Extension
{
    /// <summary>
    /// 字符串的DateTime数据类型转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionDateTimeParser
    {
        /// <summary>
        /// 转换指定时间格式的字符串为指定时间天的最小时间，也就是指定时间天的零点,零分,零秒
        /// 举个例子（2015-02-02 12:00:00）此方法返回2015-02-02 00:00:00
        /// </summary>
        /// <param name="src">时间格式的字符串</param>
        /// <returns></returns>
        public static DateTime ToMinDateTimeToDay(this string src)
        {
            return src.ToDateTime().GetDateTimeAsDayStart();
        }

        /// <summary>
        /// 转换指定时间格式的字符串为指定时间天的最大时间，也就是指定时间天的23点,59分,59秒
        /// 举个例子（2015-02-02 12:00:00）此方法返回2015-02-02 23:59:59
        /// </summary>
        /// <param name="src">时间格式的字符串</param>
        /// <returns></returns>
        public static DateTime ToMaxDateTimeToDay(this string src)
        {
            return src.ToDateTime().GetDateTimeAsDayEnded();
        }
    }
}
