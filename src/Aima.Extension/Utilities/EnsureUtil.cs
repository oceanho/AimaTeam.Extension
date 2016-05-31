
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
namespace Aima.Extension.Util
{
    /// <summary>
    /// 断言工具
    /// </summary>
    internal sealed class Ensure
    {
        /// <summary>
        /// 断言一个对象不为空,为空抛出异常
        /// </summary>
        /// <param name="obj">断言的对象</param>
        /// <param name="argumentName">为空异常的参数名称</param>
        internal static void IsNotNull(object obj, string argumentName)
        {
            if (obj == null)
                throw ExceptionUtil.Create<ArgumentNullException>(argumentName);

            var type = obj.GetType();
            if (type == typeof(string))
            {
                if (Extension.StringExtension4Common.IsNullOrEmp(obj.ToString()))
                    throw ExceptionUtil.Create<ArgumentNullException>(argumentName);
            }
        }
    }
}
