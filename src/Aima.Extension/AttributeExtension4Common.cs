
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
    /// Attribute标记常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class AttributeExtension4Common
    {
        /// <summary>
        /// 获取Attribute的标注说明描述信息
        /// </summary>
        /// <param name="attrSource">指定的Attribute对象</param>
        /// <returns></returns>
        public static string GetDescriptorText(this Attribute attrSource)
        {
            throw new NotImplementedException();
            // return attrSource.GetType().GetField().GetDescriptionAttributes().FirstOrDefault().Description;
        }
    }
}
