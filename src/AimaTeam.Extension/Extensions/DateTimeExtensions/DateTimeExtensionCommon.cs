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
    /// 时间DateTime常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class DateTimeExtensionCommon
    {
        /// <summary>
        /// 获取dateTime日期的起始时间值,返回这一天中最开始的时间点（比如：2015-12-07 23:33:39,返回2015-12-07 00:00:00）
        /// </summary>
        /// <param name="dateTimesrc">指定的dateTime</param>
        /// <returns></returns>
        public static DateTime GetDateTimeAsDayStart(this DateTime dateTimesrc)
        {
            return new DateTime(dateTimesrc.Year, dateTimesrc.Month, dateTimesrc.Day, 00, 00, 00);
        }

        /// <summary>
        /// 获取dateTime日期的起始时间值,返回这一天中最开始的时间点（比如：2015-12-07 23:33:39,返回2015-12-07 23:59:59）
        /// </summary>
        /// <param name="dateTimesrc">指定的dateTime</param>
        /// <returns></returns>
        public static DateTime GetDateTimeAsDayEnded(this DateTime dateTimesrc)
        {
            return new DateTime(dateTimesrc.Year, dateTimesrc.Month, dateTimesrc.Day, 23, 59, 59);
        }

        /// <summary>
        /// 获取指定时间的时间戳（1970-01-01 00:00:00 到 dateTimesrc之间的时间戳）
        /// </summary>
        /// <param name="dateTimesrc">dateTimesrc</param>
        /// <returns></returns>
        public static long GetTicks(this DateTime dateTimesrc)
        {
            return new TimeSpan(dateTimesrc.Ticks).Ticks;
        }
    }
}
