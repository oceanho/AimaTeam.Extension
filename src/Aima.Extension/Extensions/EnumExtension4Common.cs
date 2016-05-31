
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
using System.Linq;
using Aima.Extension.Util;
using System.ComponentModel;
using System.Reflection;

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
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static string GetEnumKey(this Enum enumsrc)
        {
            return Enum.GetName(enumsrc.GetType(), enumsrc);
        }

        /// <summary>
        /// 获取枚举的值
        /// </summary>
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static EnumValueType GetEnumValue<EnumValueType>(this Enum enumsrc)
        {
            int valueIndex = 0;
            string enumsrcKey = enumsrc.GetEnumKey();
            foreach (var item in Enum.GetNames(enumsrc.GetType()))
            {
                if (enumsrcKey.EqualIgnoreCase(item))
                {
                    return (EnumValueType)Enum.GetValues(enumsrc.GetType()).GetValue(valueIndex);
                }
                valueIndex++;
            }
            throw ExceptionUtil.Create<InvalidCastException>("the {0} invalid".Format2(enumsrc));
        }

        /// <summary>
        /// 获取枚举的描述,没有System.ComponentModel.DescriptionAttribute标记返回string.Empty
        /// </summary>
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static string GetDescriptorText(this Enum enumsrc)
        {

#if COREFX
            FieldInfo field =System.Reflection.TypeExtensions.GetField(enumsrc.GetType(), enumsrc.ToString());
            DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#else
            FieldInfo field = enumsrc.GetType().GetField(enumsrc.ToString());
            DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#endif
            if (desciptors.Length > 0)
                return desciptors[0].Description;
            return string.Empty;
        }

        /// <summary>
        /// 获取int枚举类型的值
        /// </summary>
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static int GetEnumValueAsInt(this Enum enumsrc)
        {
            return enumsrc.GetEnumValue<int>();
        }

        /// <summary>
        /// 获取byte枚举类型的值
        /// </summary>
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static int GetEnumValueAsByte(this Enum enumsrc)
        {
            return enumsrc.GetEnumValue<byte>();
        }

        /// <summary>
        /// 获取Long/Int64枚举类型的值
        /// </summary>
        /// <param name="enumsrc">枚举对象</param>
        /// <returns></returns>
        public static long GetEnumValueAsLong(this Enum enumsrc)
        {
            return enumsrc.GetEnumValue<long>();
        }
    }
}
