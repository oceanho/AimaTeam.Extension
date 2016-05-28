
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

namespace Aima.Extension.Util
{
    /// <summary>
    /// Exception的创建类
    /// </summary>
    internal sealed class ExceptionUtil
    {
        /// <summary>
        /// 创建一个指定Exception类型的Exception对象
        /// </summary>
        /// <typeparam name="TExceptionType">Exception对象或子对象</typeparam>
        /// <param name="message">消息</param>
        /// <returns></returns>
        internal static TExceptionType Create<TExceptionType>(string message) where TExceptionType : Exception
        {
            return (TExceptionType)Activator.CreateInstance(typeof(TExceptionType), new object[] { message });
        }

        /// <summary>
        /// 创建一个指定Exception类型的Exception对象
        /// </summary>
        /// <typeparam name="TExceptionType">Exception对象或子对象</typeparam>
        /// /// <param name="message">消息</param>
        /// <param name="innerException">异常消息</param>
        /// <returns></returns>
        internal static TExceptionType Create<TExceptionType>(string message, Exception innerException) where TExceptionType : Exception
        {
            return (TExceptionType)Activator.CreateInstance(typeof(TExceptionType), new object[] { message, innerException });
        }
    }
}
