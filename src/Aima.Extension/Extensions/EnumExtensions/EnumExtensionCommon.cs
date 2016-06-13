
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
using System.ComponentModel;
using System.Reflection;

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 枚举常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class EnumExtensionCommon
    {
        /// <summary>
        /// 获取枚举的键
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static string GetKey(this Enum enumSrc)
        {
            return Enum.GetName(enumSrc.GetType(), enumSrc);
        }

        /// <summary>
        /// 获取枚举的值
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static TValue GetValue<TValue>(this Enum enumSrc)
        {
            int valueIndex = 0;
            string enumSrcKey = enumSrc.GetKey();
            foreach (var item in Enum.GetNames(enumSrc.GetType()))
            {
                if (enumSrcKey.EqualIgnoreCase(item))
                {
                    return (TValue)Enum.GetValues(enumSrc.GetType()).GetValue(valueIndex);
                }
                valueIndex++;
            }
            throw ExceptionUtility.Create<InvalidCastException>("The {0} invalid".Format2(enumSrc));
        }

        /// <summary>
        /// 获取枚举的描述,没有System.ComponentModel.DescriptionAttribute标记返回string.Empty
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static string GetDescriptorText(this Enum enumSrc)
        {

#if COREFX
            FieldInfo field =System.Reflection.TypeExtensions.GetField(enumSrc.GetType(), enumSrc.ToString());
            DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#else
            FieldInfo field = enumSrc.GetType().GetField(enumSrc.ToString());
            DescriptionAttribute[] desciptors = field.GetDescriptionAttributes().ToArray();
#endif
            if (desciptors.Length > 0)
                return desciptors[0].Description;
            return string.Empty;
        }

        /// <summary>
        /// 获取int枚举类型的值
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static int GetValueAsInt(this Enum enumSrc)
        {
            return enumSrc.GetValue<int>();
        }

        /// <summary>
        /// 获取byte枚举类型的值
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static int GetValueAsByte(this Enum enumSrc)
        {
            return enumSrc.GetValue<byte>();
        }

        /// <summary>
        /// 获取Long/Int64枚举类型的值
        /// </summary>
        /// <param name="enumSrc">枚举对象</param>
        /// <returns></returns>
        public static long GetValueAsLong(this Enum enumSrc)
        {
            return enumSrc.GetValue<long>();
        }

        /// <summary>
        /// 获取指定参数枚举值,包含了键/值以及Attribute附加属性的等等的 <see cref="EnumInfo{TValue}"/> 对象
        /// </summary>
        /// <typeparam name="TValue">指定枚举没的枚举值的。net数据类型</typeparam>
        /// <param name="enumSrc">指定的枚举键值</param>
        /// <returns></returns>
        public static EnumInfo<TValue> GetEnumInfo<TValue>(this Enum enumSrc)
        {
            return enumSrc.GetEnumInfoCollection<TValue>().FirstOrDefault(p => p.Name == enumSrc.GetKey());
        }

        /// <summary>
        /// 获取指定参数枚举值,包含了键/值以及Attribute附加属性的等等的 <see cref="EnumInfoCollection{TValue}"/> 集合
        /// </summary>
        /// <typeparam name="TValue">指定枚举没的枚举值的。net数据类型</typeparam>
        /// <param name="enumSrc">指定的枚举键值</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static EnumInfoCollection<TValue> GetEnumInfoCollection<TValue>(this Enum enumSrc)
        {
            return new EnumInfoCollection<TValue>(enumSrc.GetType());
        }
    }
}
