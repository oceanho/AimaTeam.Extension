
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
namespace Aima.Extension.Utilities
{
    /// <summary>
    /// String工具类
    /// </summary>
    internal sealed class StringUtility
    {
        /// <summary>
        /// 校验 arguments 参数中所有的String对象,是否有为 Null 或者 Empty 的值,有返回True,没有或者arguments==null返回False
        /// </summary>
        /// <param name="arguments">参数列表</param>
        /// <returns></returns>
        public static bool IsExistNullOrEmpty(params string[] arguments)
        {
            if (args != null)
            {
                foreach (var item in args)
                    if (string.IsNullOrEmpty(item))
                        return true;
            }
            return false;
        }
    }
}
