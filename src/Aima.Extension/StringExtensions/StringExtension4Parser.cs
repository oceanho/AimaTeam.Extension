
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
    /// 字符串的数据类型转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Parser
    { 
        /// <summary>
        /// 将一个字符串转换为指定类型的对象，若转换失败返回默认值，转换成功返回转换出来的值
        /// </summary>
        /// <typeparam name="TOut">指定类型，应该是任意一个是System.IConverable接口的实现类或者一个枚举</typeparam>
        /// <param name="src">字符串源</param>
        /// <exception cref="System.FormatException">
        ///     T:System.FormatException:
        ///     conversionType 无法识别value的格式。
        ///
        ///     T:System.OverflowException:
        ///     value 表示超出 conversionType 范围的数字。
        ///
        ///     T:System.ArgumentNullException:
        ///     conversionType 为 null。
        /// </exception>
        /// <returns></returns>
        public static TOut To<TOut>(this string src)
        {
            bool isEnum = false;
            isEnum = typeof(TOut).IsEnum();

            if (isEnum)
                return DelegateStaticConvertMethods<TOut>.ChangeTypeAsEnumFromString.Invoke(src);
            return DelegateStaticConvertMethods<TOut>.ChangeTypeFromString.Invoke(src);
        }

        /// <summary>
        /// 将一个字符串转换为指定类型的对象，若转换失败返回默认值，转换成功返回转换出来的值
        /// </summary>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败了，返回的默认值</param>
        /// <exception cref="System.FormatException">
        ///     T:System.FormatException:
        ///     conversionType 无法识别value的格式。
        ///
        ///     T:System.OverflowException:
        ///     value 表示超出 conversionType 范围的数字。
        ///
        ///     T:System.ArgumentNullException:
        ///     conversionType 为 null。
        /// </exception>
        /// <returns></returns>
        public static TOut To<TOut>(this string src, TOut defaultValue)
        {
            try
            {
                return src.To<TOut>();
            }
            catch { }
            return defaultValue;
        }

        /// <summary>
        /// 将一个字符串转换为int数据类型的对象值,如果转换失败,将会抛异常
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <returns></returns>
        public static int ToInt(this string src)
        {
            return src.To<int>();
        }

        /// <summary>
        /// 将一个字符串转换为int数据类型的对象值,如果转换失败,返回defaultValue
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败,返回的默认值</param>
        /// <returns></returns>
        public static int ToInt(this string src, int defaultValue)
        {
            return src.To(defaultValue);
        }

        /// <summary>
        /// 将一个字符串转换为float数据类型的对象值,如果转换失败,将会抛异常
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <returns></returns>
        public static float ToFloat(this string src)
        {
            return src.To<float>();
        }

        /// <summary>
        /// 将一个字符串转换为float数据类型的对象值,如果转换失败,返回defaultValue
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败,返回的默认值</param>
        /// <returns></returns>
        public static float ToFloat(this string src, float defaultValue)
        {
            return src.To(defaultValue);
        }


        /// <summary>
        /// 将一个字符串转换为Double数据类型的对象值,如果转换失败,将会抛异常
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <returns></returns>
        public static double ToDouble(this string src)
        {
            return src.To<double>();
        }

        /// <summary>
        /// 将一个字符串转换为Double数据类型的对象值,如果转换失败,返回defaultValue
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败,返回的默认值</param>
        /// <returns></returns>
        public static double ToDouble(this string src, double defaultValue)
        {
            return src.To(defaultValue);
        }

        /// <summary>
        /// 将一个字符串转换为Decimal数据类型的对象值,如果转换失败,将会抛异常
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string src)
        {
            return src.To<decimal>();
        }

        /// <summary>
        /// 将一个字符串转换为Double数据类型的对象值,如果转换失败,返回defaultValue
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败,返回的默认值</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string src, decimal defaultValue)
        {
            return src.To(defaultValue);
        }

        /// <summary>
        /// 将一个字符串转换为DateTime数据类型的对象值,如果转换失败,将会抛异常
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string src)
        {
            return src.To<DateTime>();
        }
        /// <summary>
        /// 将一个字符串转换为DateTime数据类型的对象值,如果转换失败,返回defaultValue
        /// </summary>
        /// <param name="src">字符串源</param>
        /// <param name="defaultValue">如果转换失败,返回的默认值</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string src, DateTime defaultValue)
        {
            return src.To(defaultValue);
        }
    }

    internal sealed class DelegateStaticConvertMethods<TOut>
    {
        internal static Func<string, TOut> ChangeTypeAsEnumFromString = new Func<string, TOut>((inObj) => { return (TOut)Enum.Parse(typeof(TOut), inObj); });
        internal static Func<string, TOut> ChangeTypeFromString = new Func<string, TOut>((inObj) => { return (TOut)Convert.ChangeType(inObj, typeof(TOut)); });
    }
}
