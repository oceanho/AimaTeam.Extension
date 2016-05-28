
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
namespace Aima.Extension
{
    /// <summary>
    /// 时间DateTime常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class DateTimeExtension4Common
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
