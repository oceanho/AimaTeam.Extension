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

namespace Aima.Extension
{
    /// <summary>
    /// Object类型常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class ObjectExtensionCommon
    {
        /// <summary>
        /// 验证对象是否为空引用。如果是空引用，返回True，不是返回False
        /// 注：针对String类型的数据，加入IsNullOrEmpty()方法进行了校验
        /// </summary>
        /// <param name="objSrc">指定校验的object对象</param>
        /// <returns></returns>
        public static bool IsNullReference(this object objSrc)
        {
            if (objSrc != null)
            {
                if (objSrc.GetType() == typeof(string))
                {
                    return objSrc.ToString().IsNullOrEmpty2();
                }
                return false;
            }
            return true;
        }
    }
}
