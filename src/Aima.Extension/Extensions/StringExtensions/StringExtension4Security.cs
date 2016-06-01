
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
using System.Text;
using System.Security.Cryptography;

namespace Aima.Extension
{
    using Utilities;

    /// <summary>
    /// 字符串的安全操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4Security
    {
        private static readonly Encoding _defaultEncoding = Encoding.UTF8;
        private static readonly bool _defaultThrowArgumentNullExceptionIfsrcIsNull = false;

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <returns></returns>
        public static string GetMD5_32(this string src)
        {
            return src.GetMD5_32(_defaultEncoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <returns></returns>
        public static string GetMD5_32(this string src, Encoding encoding)
        {
            return src.GetMD5_32(encoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string GetMD5_32(this string src, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            return src.GetMD5_32(_defaultEncoding, throwArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行32位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string GetMD5_32(this string src, Encoding encoding, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            if (src.IsNullOrEmp())
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
        public static string GetMD5_16(this string src)
        {
            return src.GetMD5_16(_defaultEncoding, _defaultThrowArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用utf-8编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string GetMD5_16(this string src, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            return src.GetMD5_16(_defaultEncoding, throwArgumentNullExceptionIfsrcIsNull);
        }

        /// <summary>
        /// 使用指定编码,对指定的字符串执行16位 md5 hash散列运算并返回其全大写的hash值
        /// </summary>
        /// <param name="src">指定的字符串</param>
        /// <param name="encoding">指定的编码格式</param>
        /// <param name="throwArgumentNullExceptionIfsrcIsNull">指定一个参数值，该参数表示当src源字符串为string.Empty或null时,是否抛出ArgumentNullException异常、如果指定为True,满足src为空,将抛出ArgumentNullException,指定为False,返回src原字符</param>
        /// <returns></returns>
        public static string GetMD5_16(this string src, Encoding encoding, bool throwArgumentNullExceptionIfsrcIsNull)
        {
            if (src.IsNullOrEmp())
            {
                if (throwArgumentNullExceptionIfsrcIsNull)
                    throw ExceptionUtility.Create<ArgumentNullException>("Parameter 'src' is null or empty");
                return src;
            }

            return src.GetMD5_32(encoding).Substring(8, 16);
        }
    }
}
