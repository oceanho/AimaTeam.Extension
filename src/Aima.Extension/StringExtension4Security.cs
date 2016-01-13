
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
using System.Security.Cryptography;

namespace Aima.Extension
{
    using Util;

    /// <summary>
    /// 字符串的安全操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Security
    {
        private static readonly Encoding _defaultEncoding = Encoding.UTF8;
        private static readonly bool _defaultThrowArgumentNullExceptionIfSourceIsNull = false;

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <returns></returns>
        public static string GetMD5As32(this string source)
        {
            return source.GetMD5As32(_defaultEncoding, _defaultThrowArgumentNullExceptionIfSourceIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string GetMD5As32(this string source, Encoding encoding)
        {
            return source.GetMD5As32(encoding, _defaultThrowArgumentNullExceptionIfSourceIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfSourceIsNull">指定一个参数值，该参数表示当source源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足source为空,将抛出ArgumentNullException,指定为False,返回source原字符</param>
        /// <returns></returns>
        public static string GetMD5As32(this string source, bool throwArgumentNullExceptionIfSourceIsNull)
        {
            return source.GetMD5As32(_defaultEncoding, throwArgumentNullExceptionIfSourceIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfSourceIsNull">指定一个参数值，该参数表示当source源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足source为空,将抛出ArgumentNullException,指定为False,返回source原字符</param>
        /// <returns></returns>
        public static string GetMD5As32(this string source, Encoding encoding, bool throwArgumentNullExceptionIfSourceIsNull)
        {
            if (source.IsNullOrEmp())
            {
                if (throwArgumentNullExceptionIfSourceIsNull)
                    throw ExceptionUtil.Create<ArgumentNullException>("Parameter 'source' is null or empty");
                return source;
            }

            byte[] hash_bytes;
            byte[] bytes = encoding.GetBytes(source);
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
        /// <param name="source">指定的字符串</param>
        /// <returns></returns>
        public static string GetMD5As16(this string source)
        {
            return source.GetMD5As16(_defaultEncoding, _defaultThrowArgumentNullExceptionIfSourceIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfSourceIsNull">指定一个参数值，该参数表示当source源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足source为空,将抛出ArgumentNullException,指定为False,返回source原字符</param>
        /// <returns></returns>
        public static string GetMD5As16(this string source, bool throwArgumentNullExceptionIfSourceIsNull)
        {
            return source.GetMD5As16(_defaultEncoding, throwArgumentNullExceptionIfSourceIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="source">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfSourceIsNull">指定一个参数值，该参数表示当source源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足source为空,将抛出ArgumentNullException,指定为False,返回source原字符</param>
        /// <returns></returns>
        public static string GetMD5As16(this string source, Encoding encoding, bool throwArgumentNullExceptionIfSourceIsNull)
        {
            if (source.IsNullOrEmp())
            {
                if (throwArgumentNullExceptionIfSourceIsNull)
                    throw ExceptionUtil.Create<ArgumentNullException>("Parameter 'source' is null or empty");
                return source;
            }

            return source.GetMD5As32(encoding).Substring(8, 16);
        }
    }
}
