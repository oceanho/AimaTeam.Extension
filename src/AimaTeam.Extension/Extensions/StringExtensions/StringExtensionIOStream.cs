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


using System.Text;
using System.Linq;
using AimaTeam.Extension.Common;
using System.IO;

namespace AimaTeam.Extension
{
    /// <summary>
    /// 字符串与字节数组之间的常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class StringExtensionIOStream
    {
        #region --> GetStreamByUtf8()
        /// <summary>
        /// 使用Utf-8的编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <returns></returns>
        public static Stream GetStreamByUtf8(this string src)
        {
            return src.GetStreamByUtf8(0);
        }


        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <returns></returns>
        public static Stream GetStreamByUtf8(this string src, int startIndex)
        {
            return src.GetStreamByUtf8(startIndex, src.Length);
        }

        /// <summary>
        /// 使用Utf-8编码方式获取参数:src字节数组获取到一个字符串
        /// </summary>
        /// <param name="src">指定的字节数组</param>
        /// <param name="startIndex">开始转换的为字符的字节数组索引</param>
        /// <param name="count">指定转换的字节数组个数</param>
        /// <returns></returns>
        public static Stream GetStreamByUtf8(this string src, int startIndex, int count)
        {
            return src.GetStreamByEncoding(Encodings._utf8, startIndex, count);
        }
        #endregion        

        #region --> GetStreamByAscii()

        /// <summary>
        /// 使用Ascii编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static Stream GetStreamByAscii(this string src)
        {
            return src.GetStreamByAscii(0);
        }

        /// <summary>
        /// 使用Ascii编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByAscii(this string src, int index)
        {
            return src.GetStreamByAscii(index, src.Length);
        }

        /// <summary>
        /// 使用Ascii编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByAscii(this string src, int index, int count)
        {
            return src.GetStreamByEncoding(Encodings._ascii, index, count);
        }
        #endregion        

        #region --> GetStreamByUnicode()

        /// <summary>
        /// 使用Unicode编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static Stream GetStreamByUnicode(this string src)
        {
            return src.GetStreamByUnicode(0);
        }

        /// <summary>
        /// 使用Unicode编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByUnicode(this string src, int index)
        {
            return src.GetStreamByUnicode(index, src.Length);
        }

        /// <summary>
        /// 使用Unicode编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByUnicode(this string src, int index, int count)
        {
            return src.GetStreamByEncoding(Encodings._unicode, index, count);
        }
        #endregion

        #region --> GetStreamByGbk()

        /// <summary>
        /// 使用Gbk编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static Stream GetStreamByGbk(this string src)
        {
            return src.GetStreamByGbk(0);
        }

        /// <summary>
        /// 使用Gbk编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByGbk(this string src, int index)
        {
            return src.GetStreamByGbk(index, src.Length);
        }

        /// <summary>
        /// 使用Gbk编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByGbk(this string src, int index, int count)
        {
            return src.GetStreamByEncoding(Encodings._gbk, index, count);
        }
        #endregion

        #region --> GetStreamByGb2312()

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static Stream GetStreamByGb2312(this string src)
        {
            return src.GetStreamByGb2312(0);
        }

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByGb2312(this string src, int index)
        {
            return src.GetStreamByGb2312(index, src.Length);
        }

        /// <summary>
        /// 使用Gb2312编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByGb2312(this string src, int index, int count)
        {
            return src.GetStreamByEncoding(Encodings._gb2312, index, count);
        }
        #endregion

        #region --> GetStreamByEncoding()

        /// <summary>
        /// 使用指定编码,指定开始索引,将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <returns></returns>
        public static Stream GetStreamByEncoding(this string src, Encoding encoding)
        {
            return src.GetStreamByEncoding(encoding, 0);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByEncoding(this string src, Encoding encoding, int index)
        {
            return src.GetStreamByEncoding(encoding, index, src.Length);
        }

        /// <summary>
        /// 使用指定编码,指定开始索引,指定转换的个数.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <param name="encoding">指定待转换使用的编码</param>
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByEncoding(this string src, Encoding encoding, int index, int count)
        {
            return new MemoryStream(src.GetBytesByEncoding(encoding, index, count));
        }
        #endregion

        #region --> GetStreamByDefault()

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>
        /// <returns></returns>
        public static Stream GetStreamByDefault(this string src)
        {
            return src.GetStreamByDefault(0);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <returns></returns>
        public static Stream GetStreamByDefault(this string src, int index)
        {
            return src.GetStreamByDefault(index, src.Length);
        }

        /// <summary>
        /// 使用DefaultEncoding编码.将src数组转换为Stream对象
        /// </summary>
        /// <param name="src">指定待获取字节数组String对象</param>        
        /// <param name="index">指定待转换的数组索引开始值</param>
        /// <param name="count">指定从开始长度的字节数组置起,转换的Stream对象个数</param>
        /// <returns></returns>
        public static Stream GetStreamByDefault(this string src, int index, int count)
        {
            return src.GetStreamByEncoding(Encodings._defaultEncoding, index, count);
        }
        #endregion
    }
}
