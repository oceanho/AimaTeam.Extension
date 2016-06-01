
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
    /// 时间DateTime比较操作而定义的扩展方法静态类
    /// </summary>
    public static partial class DateTimeExtension4Comparer
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
