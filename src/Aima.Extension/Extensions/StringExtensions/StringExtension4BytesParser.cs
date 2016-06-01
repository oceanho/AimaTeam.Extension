
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
using System.Linq;
using Aima.Extension.Common;

namespace Aima.Extension
{
    /// <summary>
    /// 字符串与字节数组之间的常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4BytesParser
    {
        #region --> GetBytesByUtf8()
        /// <summary>
        /// 使用Utf-8的编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string src)
        {
            return src.GetBytesByUtf8(0);
        }


        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string src, int startIndex)
        {
            return src.GetBytesByUtf8(startIndex, src.Length);
        }

        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <param name="count">指定转换的字节数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string src, int startIndex, int count)
        {
            return src.GetBytesByEncoding(Encodings._utf8, startIndex, count);
        }
        #endregion        

        #region --> GetBytesByAscii()

        /// <summary>
        /// 使用Ascii编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string src)
        {
            return src.GetBytesByAscii(0);
        }

        /// <summary>
        /// 使用Ascii编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string src, int index)
        {
            return src.GetBytesByAscii(index, src.Length);
        }

        /// <summary>
        /// 使用Ascii编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string src, int index, int count)
        {
            return src.GetBytesByEncoding(Encodings._ascii, index, count);
        }
        #endregion        

        #region --> GetBytesByUnicode()

        /// <summary>
        /// 使用Unicode编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string src)
        {
            return src.GetBytesByUnicode(0);
        }

        /// <summary>
        /// 使用Unicode编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string src, int index)
        {
            return src.GetBytesByUnicode(index, src.Length);
        }

        /// <summary>
        /// 使用Unicode编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string src, int index, int count)
        {
            return src.GetBytesByEncoding(Encodings._unicode, index, count);
        }
        #endregion

        #region --> GetBytesByGbk()

        /// <summary>
        /// 使用Gbk编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string src)
        {
            return src.GetBytesByGbk(0);
        }

        /// <summary>
        /// 使用Gbk编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string src, int index)
        {
            return src.GetBytesByGbk(index, src.Length);
        }

        /// <summary>
        /// 使用Gbk编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string src, int index, int count)
        {
            return src.GetBytesByEncoding(Encodings._gbk, index, count);
        }
        #endregion

        #region --> GetBytesByGb2312()

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string src)
        {
            return src.GetBytesByGb2312(0);
        }

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string src, int index)
        {
            return src.GetBytesByGb2312(index, src.Length);
        }

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string src, int index, int count)
        {
            return src.GetBytesByEncoding(Encodings._gb2312, index, count);
        }
        #endregion

        #region --> GetBytesByEncoding()

        /// <summary>
        /// 使用指定编码,指定开始索引,将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string src, Encoding encoding)
        {
            return src.GetBytesByEncoding(encoding, 0);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string src, Encoding encoding, int index)
        {
            return src.GetBytesByEncoding(encoding, index, src.Length);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,指定转换的个数.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string src, Encoding encoding, int index, int count)
        {
            return encoding.GetBytes(src.ToArray(), index, count);
        }
        #endregion

        #region --> GetBytesByDefault()

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string src)
        {
            return src.GetBytesByDefault(0);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string src, int index)
        {
            return src.GetBytesByDefault(index, src.Length);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为byte数组
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string src, int index, int count)
        {
            return src.GetBytesByEncoding(Encodings._defaultEncoding, index, count);
        }
        #endregion
    }
}
