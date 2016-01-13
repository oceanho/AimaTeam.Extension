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

namespace Aima.Extension.Kernal
{
    /// <summary>
    /// 定义一个枚举的键值集合对象
    /// </summary>
    public sealed class EnumKV
    {
        /// <summary>
        /// 枚举的键
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 枚举的值
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 枚举DescriptionAttribute的Text文本
        /// </summary>
        public string DescriptorText { get; set; }
    }
}
