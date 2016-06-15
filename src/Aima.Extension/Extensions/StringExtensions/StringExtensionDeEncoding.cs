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

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串的编码与解码操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionDeEncoding
    {
        private static readonly Encoding _defaultEncoding = Encoding.UTF8;

        #region ToBase64String/FromBase64ToString

        /// <summary>
        /// 使用utf-8编码,指定的Base64FormattingOptions.None,将一个普通字符串转换为base64编码字符
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <returns></returns>
        public static string ToBase64String(this string src)
        {
            return src.ToBase64String(_defaultEncoding);
        }

        /// <summary>
        /// 使用指定的编码,指定的Base64FormattingOptions.None,将一个普通字符串转换为base64编码字符
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string ToBase64String(this string src, Encoding encoding)
        {
            return Convert.ToBase64String(encoding.GetBytes(src));
        }

#if !COREFX
        /// <summary>
        /// 使用指定的编码,指定的Base64FormattingOptions,将一个普通字符串转换为base64编码字符
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="base64FrmOption">指定的Base64FormattingOptions</param>
        /// <returns></returns>
        public static string ToBase64String(this string src, Encoding encoding, Base64FormattingOptions base64FrmOption)
        {
            EnsureUtility.IsNotNull(src, "src");
            byte[] bytes = encoding.GetBytes(src);
            return Convert.ToBase64String(bytes, base64FrmOption);
        }
#endif
        /// <summary>
        /// 使用utf-8编码,指定的Base64FormattingOptions.None,将一个base64编码字符转换为普通字符串
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <returns></returns>
        public static string FromBase64ToString(this string src)
        {
            return src.FromBase64ToString(_defaultEncoding);
        }

        /// <summary>
        /// 使用指定的编码,指定的Base64FormattingOptions.None,将一个base64编码字符转换为普通字符串
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string FromBase64ToString(this string src, Encoding encoding)
        {

#if COREFX
            EnsureUtility.IsNotNull(src, "src");
            byte[] bytes = Convert.FromBase64String(src);
            return encoding.GetString(bytes,0,bytes.Length);
#else
            return src.FromBase64ToString(encoding, Base64FormattingOptions.None);
#endif

        }

#if !COREFX
        /// <summary>
        /// 使用指定的编码,指定的Base64FormattingOptions,将一个base64编码字符转换为普通字符串，src必须是一个正确的base64编码字符串
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="base64FrmOption">指定的Base64FormattingOptions</param>
        /// <returns></returns>
        public static string FromBase64ToString(this string src, Encoding encoding, Base64FormattingOptions base64FrmOption)
        {
            EnsureUtility.IsNotNull(src, "src");
            byte[] bytes = Convert.FromBase64String(src);
            return encoding.GetString(bytes);
        }
#endif
        #endregion

        #region HtmlEncode/HtmlDecode/UrlEncode/UrlDecode

        /// <summary>
        /// 对 Html字符串进行编码操作,返回编码后的字符串
        /// </summary>
        /// <param name="src">指定需要进行编码的字符串</param>
        /// <returns></returns>
        public static string HtmlEncode(this string src)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 对 字符串进行Html解码操作,返回解码后的字符串
        /// </summary>
        /// <param name="src">指定需要进行解码的字符串</param>
        /// <returns></returns>
        public static string HtmlDecode(this string src)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 对 字符串进行URL编码操作,返回编码后的字符串
        /// </summary>
        /// <param name="src">指定需要进行编码的字符串</param>
        /// <returns></returns>
        public static string UrlEncode(this string src)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 对 字符串进行URL解码操作,返回解码后的字符串
        /// </summary>
        /// <param name="src">指定需要进行解码的字符串</param>
        /// <returns></returns>
        public static string UrlDecode(this string src)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
