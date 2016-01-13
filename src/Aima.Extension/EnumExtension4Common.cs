
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
using System.Linq;
using Aima.Extension.Util;

#if COREFX || DNX
using DescriptionAttribute = Aima.Extension.MissingfromDNX.DescriptionAttribute;
#endif
namespace Aima.Extension
{ 
    /// <summary>
    /// 枚举常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class EnumExtension4Common
    {
        /// <summary>
        /// 获取枚举的键
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static string GetEnumKey(this Enum enumSource)
        {
            return Enum.GetName(enumSource.GetType(), enumSource);
        }

        /// <summary>
        /// 获取枚举的值
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static EnumValueType GetEnumValue<EnumValueType>(this Enum enumSource)
        {
            int valueIndex = 0;
            string enumSourceKey = enumSource.GetEnumKey();
            foreach (var item in Enum.GetNames(enumSource.GetType()))
            {
                if (enumSourceKey.EqualIgnoreCase(item))
                {
                    return (EnumValueType)Enum.GetValues(enumSource.GetType()).GetValue(valueIndex);
                }
                valueIndex++;
            }
            throw ExceptionUtil.Create<InvalidCastException>("the {0} invalid".Format2(enumSource));
        }

        /// <summary>
        /// 获取枚举的描述,没有System.ComponentModel.DescriptionAttribute标记返回string.Empty
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static string GetDescriptorText(this Enum enumSource)
        {

#if COREFX
            System.Reflection.FieldInfo field =System.Reflection.TypeExtensions.GetField(enumSource.GetType(), enumSource.ToString());
            DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#else
            System.Reflection.FieldInfo field = enumSource.GetType().GetField(enumSource.ToString());
            System.ComponentModel.DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#endif
            if (desciptors.Length > 0)
                return desciptors[0].Description;
            return string.Empty;
        }

        /// <summary>
        /// 获取int枚举类型的值
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static int GetEnumValueAsInt(this Enum enumSource)
        {
            return enumSource.GetEnumValue<int>();
        }

        /// <summary>
        /// 获取byte枚举类型的值
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static int GetEnumValueAsByte(this Enum enumSource)
        {
            return enumSource.GetEnumValue<byte>();
        }

        /// <summary>
        /// 获取Long/Int64枚举类型的值
        /// </summary>
        /// <param name="enumSource">枚举对象</param>
        /// <returns></returns>
        public static long GetEnumValueAsLong(this Enum enumSource)
        {
            return enumSource.GetEnumValue<long>();
        }
    }
}
