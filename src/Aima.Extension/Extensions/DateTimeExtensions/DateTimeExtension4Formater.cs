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
