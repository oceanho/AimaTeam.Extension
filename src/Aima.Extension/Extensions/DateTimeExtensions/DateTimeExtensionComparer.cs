/*
 *
 *   Copyright © 2015-2115 AimaTeam
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
namespace Aima.Extension
{
    /// <summary>
    /// 时间DateTime比较操作而定义的扩展方法静态类
    /// </summary>
    public static partial class DateTimeExtensionComparer
    {
        /// <summary>
        /// 比较2个时间是否相等，相等返回True,否则返回False
        /// </summary>
        /// <param name="dateTime">指定比较的时间</param>
        /// <param name="compareDate">指定比较的参考时间</param>
        /// <returns></returns>
        public static bool Equal(this DateTime dateTime, DateTime compareDate)
        {
            return dateTime == compareDate;
        }

        /// <summary>
        /// 判定一个时间是否在某两个一大一小的时间区间段内，是返回True，否则返回False
        /// </summary>
        /// <param name="dateTime">指定比较的时间</param>
        /// <param name="compareStartDate">指定比较的参考起始时间</param>
        /// <param name="compareEndDate">指定比较的参考结束时间</param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime dateTime, DateTime compareStartDate, DateTime compareEndDate)
        {
            return dateTime >= compareStartDate && dateTime <= compareEndDate;
        }
    }
}
