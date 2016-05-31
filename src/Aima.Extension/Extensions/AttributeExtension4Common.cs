
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
    /// Attribute标记常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class AttributeExtension4Common
    {
        /// <summary>
        /// 获取Attribute的标注说明描述信息
        /// </summary>
        /// <param name="attrsrc">指定的Attribute对象</param>
        /// <returns></returns>
        public static string GetDescriptorText(this Attribute attrsrc)
        {
            throw new NotImplementedException();
            // return attrsrc.GetType().GetField().GetDescriptionAttributes().FirstOrDefault().Description;
        }
    }
}
