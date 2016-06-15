/*
 *
 *   Copyright © 2015-2115 AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
 *   mail：opensource@aimateam.org 
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.org
 *   
 *   Licensed to the AimaTeam Open Source under one or more agreements.
 *   The AimaTeam Open Source licenses this file to you under the MIT license. 
 *   
 *   The MIT License
 *   
 *   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 *   documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
 *   the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
 *   to permit persons to whom the Software is furnished to do so, subject to the following conditions:　　
 *   The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 *   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
 *   THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 *   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 *   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 */

using System;
namespace Aima.Extension
{
    /// <summary>
    /// 字符串的数据类型转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionParser
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
