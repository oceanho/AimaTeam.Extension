
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

using System.Text;
using System.Collections.Generic;
using System.Linq;

using Aima.Extension.Util;
using System;
using Aima.Extension.Common;

namespace Aima.Extension
{

    /// <summary>
    /// 字符串与字节数组之间的常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtension4sourceParser
    {
        #region --> GetBytesByUtf8()
        /// <summary>
        /// 使用Utf-8的编码方式获取参数:source字节数组获取到一个字符串
        /// </summary>
        /// <param name="source">指定的字节数组</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string source)
        {
            return source.GetBytesByUtf8(0);
        }


        /// <summary>
        /// 使用Utf-8编码方式获取参数:source字节数组获取到一个字符串
        /// </summary>
        /// <param name="source">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string source, int startIndex)
        {
            return source.GetBytesByUtf8(startIndex, source.Length);
        }

        /// <summary>
        /// 使用Utf-8编码方式获取参数:source字节数组获取到一个字符串
        /// </summary>
        /// <param name="source">指定的字节数组</param>
        /// <param name="encoding">指定的编码方式</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <param name="count">指定转换的字节数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByUtf8(this string source, int startIndex, int count)
        {
            return source.GetBytesByEncoding(Encodings._utf8, startIndex, count);
        }
        #endregion        

        #region --> GetBytesByAscii()

        /// <summary>
        /// 使用Ascii编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string source)
        {
            return source.GetBytesByAscii(0);
        }

        /// <summary>
        /// 使用Ascii编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string source, int index)
        {
            return source.GetBytesByAscii(index, source.Length);
        }

        /// <summary>
        /// 使用Ascii编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByAscii(this string source, int index, int count)
        {
            return source.GetBytesByEncoding(Encodings._ascii, index, count);
        }
        #endregion        

        #region --> GetBytesByUnicode()

        /// <summary>
        /// 使用Unicode编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string source)
        {
            return source.GetBytesByUnicode(0);
        }

        /// <summary>
        /// 使用Unicode编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string source, int index)
        {
            return source.GetBytesByUnicode(index, source.Length);
        }

        /// <summary>
        /// 使用Unicode编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByUnicode(this string source, int index, int count)
        {
            return source.GetBytesByEncoding(Encodings._unicode, index, count);
        }
        #endregion

        #region --> GetBytesByGbk()

        /// <summary>
        /// 使用Gbk编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string source)
        {
            return source.GetBytesByGbk(0);
        }

        /// <summary>
        /// 使用Gbk编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string source, int index)
        {
            return source.GetBytesByGbk(index, source.Length);
        }

        /// <summary>
        /// 使用Gbk编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByGbk(this string source, int index, int count)
        {
            return source.GetBytesByEncoding(Encodings._gbk, index, count);
        }
        #endregion

        #region --> GetBytesByGb2312()

        /// <summary>
        /// 使用Gb2312编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string source)
        {
            return source.GetBytesByGb2312(0);
        }

        /// <summary>
        /// 使用Gb2312编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string source, int index)
        {
            return source.GetBytesByGb2312(index, source.Length);
        }

        /// <summary>
        /// 使用Gb2312编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByGb2312(this string source, int index, int count)
        {
            return source.GetBytesByEncoding(Encodings._gb2312, index, count);
        }
        #endregion

        #region --> GetBytesByEncoding()

        /// <summary>
        /// 使用指定编码,指定开始索引,将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string source, Encoding encoding)
        {
            return source.GetBytesByEncoding(encoding, 0);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string source, Encoding encoding, int index)
        {
            return source.GetBytesByEncoding(encoding, index, source.Length);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,指定转换的个数.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByEncoding(this string source, Encoding encoding, int index, int count)
        {
            return encoding.GetBytes(source.ToArray(), index, count);
        }
        #endregion

        #region --> GetBytesByDefault()

        /// <summary>
        /// 使用DefaultEncoding编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string source)
        {
            return source.GetBytesByDefault(0);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string source, int index)
        {
            return source.GetBytesByDefault(index, source.Length);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将source数组转换为byte数组
        /// </summary>
        /// <param name="source">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static byte[] GetBytesByDefault(this string source, int index, int count)
        {
            return source.GetBytesByEncoding(Encodings._defaultEncoding, index, count);
        }
        #endregion
    }
}
