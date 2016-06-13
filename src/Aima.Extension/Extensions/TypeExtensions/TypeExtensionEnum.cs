
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
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;


namespace Aima.Extension
{
    /// <summary>
    /// System.Type -> Enum常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class TypeExtensionEnum
    {
        /// <summary>
        /// 获取枚举对象的键/值集合以及Attribute附加属性信息,参数必须是枚举Type,否则会抛出 <see cref="ArgumentException"/>
        /// </summary>
        /// <typeparam name="TEnumValue">指定枚举没的枚举值的。net数据类型</typeparam>
        /// <param name="enumType">指定的枚举类型（通常使用typeof(XXX)指定）,此参数必须是任意的枚举类型</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static EnumInfoCollection<TEnumValue> GetEnumInfoCollection<TEnumValue>(this Type enumType)
        {
            return new EnumInfoCollection<TEnumValue>(enumType);
        }
    }
}
