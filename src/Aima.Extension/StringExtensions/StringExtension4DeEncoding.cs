
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
using System.Text;

namespace Aima.Extension
{
    using Util;

    /// <summary>
    /// 字符串的编码与解码操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4DeEncoding
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
#if COREFX
            Ensure.IsNotNull(src, "src");
            byte[] bytes = encoding.GetBytes(src);
            return Convert.ToBase64String(bytes);
#else
            return Convert.ToBase64String(encoding.GetBytes(src));
#endif
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
            Ensure.IsNotNull(src, "src");
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
            Ensure.IsNotNull(src, "src");
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
            Ensure.IsNotNull(src, "src");
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
