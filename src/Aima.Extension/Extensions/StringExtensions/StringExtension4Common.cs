
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
*   官方 网 站：https://www.aimateam.com
****************************************************************/

using System;
using System.Collections.Generic;

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Common
    {
        private static char _defaultSplitChar = ',';     // 字符串默认拆分标记

        /// <summary>
        /// 验证字符串是否为String.Empty或Null
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <returns></returns>
        public static bool IsNullOrEmp(this string src)
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
            if (src.IsNullOrEmp()) return compareLength == 0;
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
            if (src.IsNullOrEmp()) return compareLength == 0;
            return src.Length <= compareLength;
        }

        /// <summary>
        /// 使用指定参数调用 string.Format() 对传入字符进行format操作
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="formatArguments">格式化参数对象</param>
        /// <returns></returns>
        public static string Format2(this string src, params object[] formatArguments)
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
        public static string JoinFormat(this string src, string separator, params object[] formatArguments)
        {
            return string.Format(src, string.Join(separator, formatArguments));
        }

        /// <summary>
        /// 使用指定参数调用 string.Concat() 对传入字符进行连接操作
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="concatParams">连接的参数对象</param>
        /// <returns></returns>
        public static string Concat2(this string src, params object[] concatParams)
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
        public static List<TResult> Split2<TResult>(this string src, params char[] splitChars)
        {
            EnsureUtility.IsNotNull(src, "Split2:src");
            List<TResult> list = new List<TResult>();
            Func<string, TResult> converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeFromString;

            if (typeof(TResult).IsEnum()) { converthandler = DelegateStaticConvertMethods<TResult>.ChangeTypeAsEnumFromString; }

            splitChars = (splitChars == null || splitChars.Length == 0) ? new char[] { _defaultSplitChar } : splitChars;
            foreach (var item in src.Split(splitChars))
            {
                list.Add(converthandler.Invoke(item));
            }
            return list;
        }

        /// <summary>
        /// 获取一个值，该值表示一个字符串的长度是否小于另外一个字符串的长度（compareString）
        /// </summary>
        /// <param name="src">源字符串</param>
        /// <param name="compareString">另外一个字符串</param>
        /// <returns>满足条件返回true，否则返回false</returns>
        public static bool LengthIsLessThanOther(this string src, string compareString)
        {
            if (!src.IsNullOrEmp() && !compareString.IsNullOrEmp())
            {
                return src.Length < compareString.Length;
            }
            else if (!src.IsNullOrEmp() && compareString.IsNullOrEmp())
            {
                return src.Length == 0;
            }
            else if (src.IsNullOrEmp() && !compareString.IsNullOrEmp())
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
            EnsureUtility.IsNotNull(src, "Split2:StartsWithAny");
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
            EnsureUtility.IsNotNull(src, "Split2:EndsWithAny 'src'");
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
            if (src.IsNullOrEmp()) return 0;
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

            if (src.IsNullOrEmp()) return 0;
            if (findString.IsNullOrEmp()) return 0;

            int record = 0;
            int foreachRecord = 0;
            int findStringLen = 0;
            string recordSubstr = string.Empty;

            findStringLen = findString.Length;
            if (findString.LengthIsLessThanOther(src))
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
        /// <param name="indexStartCharPosition">从第几个indexCharPosition开始截取</param>
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
