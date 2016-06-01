using Aima.Extension.Utilities;
using Aima.Extension.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Aima.Extension
{
    /// <summary>
    ///字节数组与string常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static class BytesExtension4StringParser
    {
        #region --> GetStringByUtf8()
        /// <summary>
        /// 使用Utf-8的编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <returns></returns>
        public static string GetStringByUtf8(this IEnumerable<byte> src)
        {
            return src.GetStringByUtf8(0);
        }


        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <returns></returns>
        public static string GetStringByUtf8(this IEnumerable<byte> src, int startIndex)
        {
            return src.GetStringByUtf8(startIndex, src.Count());
        }

        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <param name="count">指定转换的字节数组个数</param>
        /// <returns></returns>
        public static string GetStringByUtf8(this IEnumerable<byte> src, int startIndex, int count)
        {
            return src.GetStringByEncoding(Encodings._utf8, startIndex, count);
        }
        #endregion        

        #region --> GetStringByAscii()

        /// <summary>
        /// 使用Ascii编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <returns></returns>
        public static string GetStringByAscii(this IEnumerable<byte> bytes)
        {
            return bytes.GetStringByAscii(0);
        }

        /// <summary>
        /// 使用Ascii编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByAscii(this IEnumerable<byte> bytes, int index)
        {
            return bytes.GetStringByAscii(index, bytes.Count());
        }

        /// <summary>
        /// 使用Ascii编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByAscii(this IEnumerable<byte> bytes, int index, int count)
        {
            return bytes.GetStringByEncoding(Encodings._ascii, index, count);
        }
        #endregion        

        #region --> GetStringByUnicode()

        /// <summary>
        /// 使用Unicode编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <returns></returns>
        public static string GetStringByUnicode(this IEnumerable<byte> bytes)
        {
            return bytes.GetStringByUnicode(0);
        }

        /// <summary>
        /// 使用Unicode编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByUnicode(this IEnumerable<byte> bytes, int index)
        {
            return bytes.GetStringByUnicode(index, bytes.Count());
        }

        /// <summary>
        /// 使用Unicode编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByUnicode(this IEnumerable<byte> bytes, int index, int count)
        {
            return bytes.GetStringByEncoding(Encodings._unicode, index, count);
        }
        #endregion

        #region --> GetStringByGbk()

        /// <summary>
        /// 使用Gbk编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <returns></returns>
        public static string GetStringByGbk(this IEnumerable<byte> bytes)
        {
            return bytes.GetStringByGbk(0);
        }

        /// <summary>
        /// 使用Gbk编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByGbk(this IEnumerable<byte> bytes, int index)
        {
            return bytes.GetStringByGbk(index, bytes.Count());
        }

        /// <summary>
        /// 使用Gbk编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByGbk(this IEnumerable<byte> bytes, int index, int count)
        {
            return bytes.GetStringByEncoding(Encodings._gbk, index, count);
        }
        #endregion

        #region --> GetStringByGb2312()

        /// <summary>
        /// 使用Gb2312编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <returns></returns>
        public static string GetStringByGb2312(this IEnumerable<byte> bytes)
        {
            return bytes.GetStringByGb2312(0);
        }

        /// <summary>
        /// 使用Gb2312编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByGb2312(this IEnumerable<byte> bytes, int index)
        {
            return bytes.GetStringByGb2312(index, bytes.Count());
        }

        /// <summary>
        /// 使用Gb2312编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByGb2312(this IEnumerable<byte> bytes, int index, int count)
        {
            return bytes.GetStringByEncoding(Encodings._gb2312, index, count);
        }
        #endregion

        #region --> GetStringByEncoding()

        /// <summary>
        /// 使用指定编码,指定开始索引,将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <returns></returns>
        public static string GetStringByEncoding(this IEnumerable<byte> bytes, Encoding encoding)
        {
            return bytes.GetStringByEncoding(encoding, 0);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByEncoding(this IEnumerable<byte> bytes, Encoding encoding, int index)
        {
            return bytes.GetStringByEncoding(encoding, index, bytes.Count());
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,指定转换的个数.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByEncoding(this IEnumerable<byte> bytes, Encoding encoding, int index, int count)
        {
            return encoding.GetString(bytes.ToArray(), index, count);
        }
        #endregion

        #region --> GetStringByDefault()

        /// <summary>
        /// 使用DefaultEncoding编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>
        /// <returns></returns>
        public static string GetStringByDefault(this IEnumerable<byte> bytes)
        {
            return bytes.GetStringByDefault(0);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static string GetStringByDefault(this IEnumerable<byte> bytes, int index)
        {
            return bytes.GetStringByDefault(index, bytes.Count());
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将bytes数组转换为String
        /// </summary>
        /// <param name="bytes">指定待转换的数组对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的byte数组个数</param>
        /// <returns></returns>
        public static string GetStringByDefault(this IEnumerable<byte> bytes, int index, int count)
        {
            return bytes.GetStringByEncoding(Encodings._defaultEncoding, index, count);
        }
        #endregion
    }
}
