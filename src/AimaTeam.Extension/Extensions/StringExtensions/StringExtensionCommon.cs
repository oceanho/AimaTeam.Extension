/*
 *
 *   Copyright © 2015-Presents AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
  
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
using System.Collections.Generic;

namespace AimaTeam.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionCommon
    {        
        private static char[] _defaultSplitChars = { ',' };     // 字符串默认拆分标记 数组

        /// <summary>
        /// 验证字符串是否为String.Empty或Null
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <returns></returns>
        public static bool IsNullOrEmptyExt(this string src)
        {
            return string.IsNullOrEmpty(src);
        }

        /// <summary>
        /// 获取一个值，该值表示一个字符串的长度是否小于某个长度值（compareLength）
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="compareLength">被比较的长度数值</param>
        /// <returns>满足条件返回true，否则返回false</returns>
        public static bool LengthIsLessThan(this string src, int compareLength)
        {
            if (src.IsNullOrEmptyExt()) return compareLength == 0;
            return src.Length < compareLength;
        }

        /// <summary>
        /// 获取一个值，该值表示一个字符串的长度是否小于或者等于某个长度值（compareLength）
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="compareLength">被比较的长度数值</param>
        /// <returns>满足条件返回true，否则返回false</returns>
        public static bool LengthIsLessThanOrEqual(this string src, int compareLength)
        {
            if (src.IsNullOrEmptyExt()) return compareLength == 0;
            return src.Length <= compareLength;
        }

        /// <summary>
        /// 使用指定参数调用 string.Format() 对传入字符进行format操作
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="formatArguments">格式化参数对象</param>
        /// <returns></returns>
        public static string FormatExt(this string src, params object[] formatArguments)
        {
            return string.Format(src, formatArguments);
        }

        /// <summary>
        /// 通过String.Join()将formatArguments进行链接起来,然后String.Format()
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="separator">分隔符</param>
        /// <param name="formatArguments">参数列表</param>
        /// <returns></returns>
        public static string JoinAndFormat(this string src, string separator, params object[] formatArguments)
        {
            return string.Format(src, string.Join(separator, formatArguments));
        }

        /// <summary>
        /// 使用指定参数调用 string.Concat() 对传入字符进行连接操作
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="concatParams">连接的参数对象</param>
        /// <returns></returns>
        public static string ConcatExt(this string src, params object[] concatParams)
        {
            foreach (var item in concatParams)
                src = string.Concat(src, item.ToString());
            return src;
        }

        /// <summary>
        /// 把一个字符串按照指定的拆分参数拆分为指定的List&lt;TResult%gt;对象，spitchars默认为','
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="splitChars">拆分函数所需拆分字符（默认值,逗号“,”）</param>
        /// <returns></returns>
        public static List<TResult> SplitExt<TResult>(this string src, params char[] splitChars)
        {
            EnsureUtility.IsNotNull(src, "SplitExt:src");
            List<TResult> list = new List<TResult>();
            Func<string, TResult> converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeFromString;

            if (typeof(TResult).IsEnum()) { converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeAsEnumFromString; }

            splitChars = (splitChars == null || splitChars.Length == 0) ? _defaultSplitChars : splitChars;
            foreach (var item in src.Split(splitChars))
            {
                list.Add(converthandler.Invoke(item));
            }
            return list;
        }

        /// <summary>
        /// 把一个字符串按照指定的拆分参数拆分为指定的List&lt;TResult%gt;对象，spitchars默认为','
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="getIndex">获取拆分后的转换为 TResult 对象的索引,默认值：0</param>
        /// <param name="splitChars">拆分函数所需拆分字符（默认值,逗号“,”）</param>
        /// <returns></returns>
        public static TResult SplitExtAndGetResultByIndex<TResult>(this string src, int getIndex = 0, params char[] splitChars) where TResult : class
        {
            EnsureUtility.IsNotNull(src, "SplitExtAndGetResultByIndex:src");
            Func<string, TResult> converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeFromString;
            if (typeof(TResult).IsEnum()) { converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeAsEnumFromString; }

            splitChars = (splitChars == null || splitChars.Length == 0) ? _defaultSplitChars : splitChars;
            var splitedArraies = src.Split(splitChars);
            if (splitedArraies != null && splitedArraies.Length > getIndex)
                return converthandler(splitedArraies[getIndex]);
            return null;
        }

        /// <summary>
        /// 获取一个值，该值表示一个字符串的长度是否小于另外一个字符串的长度（compareString）
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="compareString">另外一个字符串</param>
        /// <returns>满足条件返回true，否则返回false</returns>
        public static bool LengthIsLessThan(this string src, string compareString)
        {
            if (!src.IsNullOrEmptyExt() && !compareString.IsNullOrEmptyExt())
            {
                return src.Length < compareString.Length;
            }
            else if (!src.IsNullOrEmptyExt() && compareString.IsNullOrEmptyExt())
            {
                return src.Length == 0;
            }
            else if (src.IsNullOrEmptyExt() && !compareString.IsNullOrEmptyExt())
            {
                return compareString.Length == 0;
            }
            return true;
        }

        /// <summary>
        /// 判定一个字符串是否以某些任意字符开头
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="anyStrings">判定依据anyStrings</param>
        /// <returns></returns>
        public static bool StartsWithAny(this string src, params string[] anyStrings)
        {
            return src.StartsWithAny(StringComparison.OrdinalIgnoreCase, anyStrings);
        }

        /// <summary>
        /// 判定一个字符串是否以某些任意字符开头
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="comparison">StringComparison</param>
        /// <param name="anyStrings">判定依据anyStrings</param>
        /// <returns></returns>
        public static bool StartsWithAny(this string src, StringComparison comparison, params string[] anyStrings)
        {
            EnsureUtility.IsNotNull(src, "SplitExt:StartsWithAny");
            foreach (var str in anyStrings)
                if (src.StartsWith(str, comparison)) return true;
            return false;
        }

        /// <summary>
        /// 判定一个字符串是否以某些任意字符开头
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="anyStrings">判定依据anyStrings</param>
        /// <returns></returns>
        public static bool EndsWithAny(this string src, params string[] anyStrings)
        {
            return src.EndsWithAny(StringComparison.OrdinalIgnoreCase, anyStrings);
        }

        /// <summary>
        /// 判定一个字符串是否以某些任意字符结尾
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="comparison">StringComparison</param>
        /// <param name="anyStrings">判定依据anyStrings</param>
        /// <returns></returns>
        public static bool EndsWithAny(this string src, StringComparison comparison, params string[] anyStrings)
        {
            EnsureUtility.IsNotNull(src, "SplitExt:EndsWithAny 'src'");
            foreach (var str in anyStrings)
                if (src.EndsWith(str, comparison)) return true;
            return false;
        }

        /// <summary>
        /// 获取在src字符串中，某个字符出现的次数
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="findChar">需要查找出现的字符</param>
        /// <returns></returns>
        public static int GetCharFindedCount(this string src, char findChar)
        {
            int record = 0;
            if (src.IsNullOrEmptyExt()) return 0;
            for (int i = 0; i < src.Length; i++)
            {
                if (src[i] == findChar) { record++; }
            }
            return record;
        }

        /// <summary>
        /// 获取在src字符串中，某个字符串出现的次数，如果src的长度没有findString大，返回零，如果src或findString为string.Empty,返回零
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="findString">需要查找出现的字符串</param>
        /// <returns></returns>
        public static int GetStringFindedCount(this string src, string findString)
        {
            return src.GetStringFindedCount(findString, StringComparison.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// 获取在src字符串中，某个字符串出现的次数，如果src的长度没有findString大，返回零，如果src或findString为string.Empty,返回零
        /// </summary>
        /// <param name="src">字符串</param>
        /// <param name="findString">需要查找出现的字符串</param>
        /// <param name="stringComparison">字符串的比较方式枚举</param>
        /// <returns></returns>
        public static int GetStringFindedCount(this string src, string findString, StringComparison stringComparison)
        {

            if (src.IsNullOrEmptyExt()) return 0;
            if (findString.IsNullOrEmptyExt()) return 0;

            int record = 0;
            int foreachRecord = 0;
            int findStringLen = 0;
            string recordSubstr = string.Empty;

            findStringLen = findString.Length;
            if (findString.LengthIsLessThan(src))
            {
                foreachRecord = src.Length - findString.Length;
            }

            if (src.Length == findString.Length)
            {
                if (findString.Equals(findString, stringComparison))
                    record = 1;
            }
            else
            {
                for (int i = 0; i <= foreachRecord; i++)
                {
                    recordSubstr = src.Substring(i, findStringLen);
                    if (recordSubstr.Equals(findString, stringComparison))
                        record++;
                }
            }
            return record;
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="src">字符串数据源</param>
        /// <param name="indexStartChar">开始截取字符串的字符检索char</param>
        /// <returns></returns>
        public static string SubString(this string src, char indexStartChar)
        {
            return src.SubString(indexStartChar, 0);
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="src">字符串数据源</param>
        /// <param name="indexStartChar">开始截取字符串的字符检索char</param>
        /// <param name="indexStartCharPosition">从第几个indexCharPosition开始截取（比如：indexStartChar在字符串中出现了4次,该参数为0表示,从indexStartChar出现的第一个位置开始截取）</param>
        /// <returns></returns>
        public static string SubString(this string src, char indexStartChar, int indexStartCharPosition)
        {
            int forIndex = -1;
            int startIndex = -1;
            int _indexStartCharPosition = -1;
            foreach (var item in src)
            {
                forIndex++;
                if (indexStartChar == item && startIndex == -1)
                {
                    _indexStartCharPosition++;
                    if (indexStartCharPosition == _indexStartCharPosition)
                    {
                        startIndex = forIndex;
                    }
                }
            }
            if (startIndex > -1)
                return src.Substring(startIndex);
            throw new ArgumentException("无效的indexStartChar,indexStartCharPosition参数");
        }

        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="src">字符串数据源</param>
        /// <param name="indexStartChar">开始截取字符串的字符检索char</param>
        /// <param name="indexStartCharPosition">从第几个indexCharPosition开始截取</param>
        /// <param name="indexEndChar">结束截取字符串的字符检索char</param>
        /// <param name="indexEndPosition">从第几个indexEndChar停止截取</param>
        /// <returns></returns>
        public static string SubString(this string src, char indexStartChar, int indexStartCharPosition, char indexEndChar, int indexEndPosition)
        {
            int forIndex = -1;
            int endIndex = -1;
            int startIndex = -1;
            int _indexStartCharPosition = -1;
            int _indexEndPosition = -1;
            foreach (var item in src)
            {
                forIndex++;
                if (indexStartChar == item && startIndex == -1)
                {
                    _indexStartCharPosition++;
                    if (indexStartCharPosition == _indexStartCharPosition)
                    {
                        startIndex = forIndex;
                    }
                }
                else if (indexEndChar == item && endIndex == -1)
                {
                    _indexEndPosition++;
                    if (indexEndPosition == _indexEndPosition)
                    {
                        endIndex = forIndex;
                    }
                }
            }
            if (startIndex > -1 && endIndex > -1)
                return src.Substring(startIndex, endIndex + 1);

            throw new ArgumentException("无效的indexStartChar,indexStartCharPosition,indexEndChar,indexEndPosition参数");
        }
    }
}
