
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
    /// 字符串的DateTime数据类型转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4DateTimeParser
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
