/*
 *
 *   Copyright © 2015-2115 AimaTeam
 * 
 *   author：he hai
 *   time：2015/01/01 09:09:09
 *   mail：OpenSource@AimaTeam.com 
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.com
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
using System.Text;
using System.Security.Cryptography;

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串的安全操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionSecurity
    {
        private static readonly Encoding _defaultEncoding = Encoding.UTF8;
        private static readonly bool _defaultThrowArgumentNullExceptionIfsrcIsNull = false;

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <returns></returns>
        public static string Get_md5(this string src)
        {
            return src.Get_md5(_defaultEncoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string Get_md5(this string src, Encoding encoding)
        {
            return src.Get_md5(encoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string Get_md5(this string src, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            return src.Get_md5(_defaultEncoding, throwArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string Get_md5(this string src, Encoding encoding, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            if (src.IsNullOrEmpty2())
            {
                if (throwArgumentNullExceptionIfsrcIsNull)
                    throw ExceptionUtility.Create<ArgumentNullException>("Parameter 'src' is null or empty");
                return src;
            }

            byte[] hash_bytes;
            byte[] bytes = encoding.GetBytes(src);
            StringBuilder hash_builder = new StringBuilder();

            using (MD5 cryptoProvider = MD5.Create())
            {
                hash_bytes = cryptoProvider.ComputeHash(bytes);
                for (int i = 0; i < hash_bytes.Length; i++)
                {
                    hash_builder.Append(hash_bytes[i].ToString("X2"));
                }
            }
            return hash_builder.ToString();
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <returns></returns>
        public static string Get_md5Short(this string src)
        {
            return src.Get_md5Short(_defaultEncoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string Get_md5Short(this string src, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            return src.Get_md5Short(_defaultEncoding, throwArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string Get_md5Short(this string src, Encoding encoding, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            if (src.IsNullOrEmpty2())
            {
                if (throwArgumentNullExceptionIfsrcIsNull)
                    throw ExceptionUtility.Create<ArgumentNullException>("Parameter 'src' is null or empty");
                return src;
            }

            return src.Get_md5(encoding).Substring(8, 16);
        }
    }
}
