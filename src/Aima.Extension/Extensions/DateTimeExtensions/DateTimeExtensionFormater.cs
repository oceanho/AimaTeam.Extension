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
    /// 时间DateTime转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class DateTimeExtensionFormater
    {
        private static readonly string _frmt_yyyyMMdd = "yyyyMMdd";
        private static readonly string _frmt_yyyyMMddHHmmssms = "yyyyMMddHHmmssms";
        private static readonly string _frmt_yyyy_MM_dd_HH_mm_ss = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// 将指定的时间dateTime转换为yyyyMMdd的格式,比如（2015-12-07 23:20:32，此方法返回20151207)
        /// </summary>
        /// <param name="dateTime">指定转换的时间对象</param>
        /// <returns></returns>
        public static string Format2yyyyMMdd(this DateTime dateTime)
        {
            return dateTime.Format2(_frmt_yyyyMMdd);
        }

        /// <summary>
        /// 将指定的时间dateTime转换为yyyyMMddHHmmssms的格式,比如（2015-12-07 23:20:32，此方法返回20151207232032)
        /// </summary>
        /// <param name="dateTime">指定转换的时间对象</param>
        /// <returns></returns>
        public static string Format2yyyyMMddHHmmssms(this DateTime dateTime)
        {
            return dateTime.Format2(_frmt_yyyyMMddHHmmssms);
        }

        /// <summary>
        /// 将指定的时间dateTime转换为yyyy_MM_dd_HH_mm_ss的格式,比如（2015-12-07 23:20:32，此方法返回2015-12-07 23:20:32)
        /// </summary>
        /// <param name="dateTime">指定转换的时间对象</param>
        /// <returns></returns>
        public static string Format2yyyy_MM_dd_HH_mm_ss(this DateTime dateTime)
        {
            return dateTime.Format2(_frmt_yyyy_MM_dd_HH_mm_ss);
        }

        /// <summary>
        /// 将指定的时间dateTime转换为指定的格式的字符串,比如（yyyy/MM/dd HH:mm:ss)
        /// </summary>
        /// <param name="dateTime">指定转换的时间对象</param>
        /// <param name="format">指定转换的时间对象format字符</param>
        /// <returns></returns>
        public static string Format2(this DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }

        /// <summary>
        /// 将指定的时间dateTime转换为指定的格式的字符串,比如（yyyy/MM/dd HH:mm:ss)
        /// </summary>
        /// <param name="dateTime">指定转换的时间对象</param>
        /// <param name="format">指定转换的时间对象format字符</param>
        /// <param name="formatProvier">指定转换的时间的IFormatProvider接口实现类</param>
        /// <returns></returns>
        public static string Format2(this DateTime dateTime, string format, IFormatProvider formatProvier)
        {
            return dateTime.ToString(format, formatProvier);
        }
    }
}
