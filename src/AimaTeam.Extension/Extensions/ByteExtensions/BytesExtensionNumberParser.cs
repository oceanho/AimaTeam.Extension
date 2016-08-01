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

using AimaTeam.Extension.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AimaTeam.Extension
{
    /// <summary>
    ///字节数组与Number常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class BytesExtensionNumberParser
    {
        private static readonly bool _defaultIsAppendToEnd = true;
        private static readonly byte _defaultAutoApeendByteIfLengthLess = 0x00;

        #region --> ToInt16()

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足2长度的字节数组,自动后面补0,以满足2长度的字节数组</param>
        /// <returns></returns>
        public static short ToInt16(this IEnumerable<byte> bytes)
        {
            return bytes.ToInt16(0);
        }

        /// <summary>
        /// byte数组转为short数值(等待转换的字节数组,长度不足2长度的字节数组,自动后面补0,以满足2长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足2长度的字节数组,自动后面补0,以满足2长度的字节数组</param>
        /// <returns></returns>
        public static short ToInt16(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToInt16(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节2长度时,用于自动填充其值</param>
        /// <returns></returns>
        public static short ToInt16(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToInt16(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节2长度时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足short转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static short ToInt16(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<short>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToUInt16()

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static ushort ToUInt16(this IEnumerable<byte> bytes)
        {
            return bytes.ToUInt16(0);
        }

        /// <summary>
        /// byte数组转为short数值(等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static ushort ToUInt16(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToUInt16(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节2长度时,用于自动填充其值</param>
        /// <returns></returns>
        public static ushort ToUInt16(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToUInt16(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为short数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节2长度时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足short转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static ushort ToUInt16(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<ushort>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToInt32()

        /// <summary>
        /// byte数组转为int数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static int ToInt32(this IEnumerable<byte> bytes)
        {
            return bytes.ToInt32(0);
        }

        /// <summary>
        /// byte数组转为int数值(等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static int ToInt32(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToInt32(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <returns></returns>
        public static int ToInt32(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToInt32(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static int ToInt32(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<int>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToUInt32()

        /// <summary>
        /// byte数组转为int数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static uint ToUInt32(this IEnumerable<byte> bytes)
        {
            return bytes.ToUInt32(0);
        }

        /// <summary>
        /// byte数组转为int数值(等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static uint ToUInt32(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToUInt32(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <returns></returns>
        public static uint ToUInt32(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToUInt32(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static uint ToUInt32(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<uint>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToInt64()

        /// <summary>
        /// byte数组转为long数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static long ToInt64(this IEnumerable<byte> bytes)
        {
            return bytes.ToInt64(0);
        }

        /// <summary>
        /// byte数组转为long数值(等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static long ToInt64(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToInt64(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <returns></returns>
        public static long ToInt64(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToInt64(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static long ToInt64(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<long>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToUInt64()

        /// <summary>
        /// byte数组转为ulong数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static ulong ToUInt64(this IEnumerable<byte> bytes)
        {
            return bytes.ToUInt64(0);
        }

        /// <summary>
        /// byte数组转为ulong数值(等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static ulong ToUInt64(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToUInt64(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <returns></returns>
        public static ulong ToUInt64(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToUInt64(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为int类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static ulong ToUInt64(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<ulong>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToFloat()

        /// <summary>
        /// byte数组转为float类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static float ToFloat(this IEnumerable<byte> bytes)
        {
            return bytes.ToFloat(0);
        }

        /// <summary>
        /// byte数组转为float类型(等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足4长度的字节数组,自动后面补0,以满足4长度的字节数组</param>
        /// <returns></returns>
        public static float ToFloat(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToFloat(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为float类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <returns></returns>
        public static float ToFloat(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToFloat(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为float类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足int类型转换所需字节长度4时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static float ToFloat(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<float>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToDouble()

        /// <summary>
        /// byte数组转为Double类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static double ToDouble(this IEnumerable<byte> bytes)
        {
            return bytes.ToDouble(0);
        }

        /// <summary>
        /// byte数组转为Double类型(等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组)
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组,长度不足8长度的字节数组,自动后面补0,以满足8长度的字节数组</param>
        /// <returns></returns>
        public static double ToDouble(this IEnumerable<byte> bytes, int startIndex)
        {
            return bytes.ToDouble(startIndex, _defaultAutoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为Double类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足Double转换所需字节8长度时,用于自动填充其值</param>
        /// <returns></returns>
        public static double ToDouble(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess)
        {
            return bytes.ToDouble(startIndex, autoApeendByteIfLengthLess, _defaultIsAppendToEnd);
        }

        /// <summary>
        /// byte数组转为Double类型
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足Double转换所需字节8长度时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足Double转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static double ToDouble(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            return bytes.ToNumber<double>(startIndex, autoApeendByteIfLengthLess, isAppendToEnd);
        }
        #endregion

        #region --> ToNumber<TNumber>()

        /// <summary>
        /// byte数组转为TNumber,当长度不足TNumber类型转换所需字节长度时,自动在最后填充零，以满足TNumber类型所需长度进行转换
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <returns></returns>
        public static TNumber ToNumer<TNumber>(this IEnumerable<byte> bytes) where TNumber : struct, IConvertible
        {
            return bytes.ToNumber<TNumber>(0);
        }

        /// <summary>
        /// byte数组转为TNumber,当长度不足TNumber类型转换所需字节长度时,自动在最后填充零，以满足TNumber类型所需长度进行转换
        /// </summary>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <returns></returns>
        public static TNumber ToNumber<TNumber>(this IEnumerable<byte> bytes, int startIndex) where TNumber : struct, IConvertible
        {
            return bytes.ToNumber<TNumber>(startIndex, 0);
        }

        /// <summary>
        /// byte数组转为TNumber,当长度不足TNumber类型转换所需字节长度时,自动在最后填充零，以满足TNumber类型所需长度进行转换
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足TNumber类型转换所需字节长度时,用于自动填充其值</param>
        /// <returns></returns>
        public static TNumber ToNumber<TNumber>(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess) where TNumber : struct, IConvertible
        {
            return bytes.ToNumber<TNumber>(startIndex, autoApeendByteIfLengthLess, true);
        }

        /// <summary>
        /// byte数组转为指定类型的TNumber对象数值
        /// </summary>
        /// <param name="bytes">指定等待转换的字节数组</param>
        /// <param name="startIndex">指定开始转换的数组下标</param>
        /// <param name="autoApeendByteIfLengthLess">当长度不足TNumber类型转换所需字节长度时,用于自动填充其值</param>
        /// <param name="isAppendToEnd">当长度不足TNumber类型转换所需字节长度时，指定补充在后面填充指定的字节,True:是,False:在前面填充</param>
        /// <returns></returns>
        public static TNumber ToNumber<TNumber>(this IEnumerable<byte> bytes, int startIndex, byte autoApeendByteIfLengthLess, bool isAppendToEnd) where TNumber : struct, IConvertible
        {
            if (bytes == null)
                throw new ArgumentNullException(string.Format("指定的转换数组参数不能为空,请确认"));

            byte[] _bytes = bytes.ToArray();
            object _object = default(TNumber);
            switch (typeof(TNumber).GetTypeCode())
            {
                case TypeCode.Char:
                    _object = BitConverter.ToChar(GetBytes(_bytes, startIndex, 2, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Int16:
                    _object = BitConverter.ToInt16(GetBytes(_bytes, startIndex, 2, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.UInt16:
                    _object = BitConverter.ToInt16(GetBytes(_bytes, startIndex, 2, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Int32:
                    _object = BitConverter.ToInt32(GetBytes(_bytes, startIndex, 4, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.UInt32:
                    _object = BitConverter.ToUInt32(GetBytes(_bytes, startIndex, 4, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Int64:
                    _object = BitConverter.ToUInt64(GetBytes(_bytes, startIndex, 8, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.UInt64:
                    _object = BitConverter.ToUInt64(GetBytes(_bytes, startIndex, 8, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Single:
                    _object = BitConverter.ToSingle(GetBytes(_bytes, startIndex, 4, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Double:
                    _object = BitConverter.ToDouble(GetBytes(_bytes, startIndex, 8, autoApeendByteIfLengthLess, isAppendToEnd), 0);
                    break;
                case TypeCode.Decimal:
                    _object = Convert.ToDecimal(BitConverter.ToDouble(GetBytes(_bytes, startIndex, 8, autoApeendByteIfLengthLess, isAppendToEnd), 0));
                    break;
                default:
                    throw new InvalidCastException("指定的TNumber类型不是一个有效的CSharp数值数据类型,有效类型必须是:{0}".JoinAndFormat("/",
                        "Char", "Int16", "UInt16", "Int32", "UInt32", "Int64", "UInt64", "Single", "Double", "Decimal"));
            }
            return (TNumber)_object;
        }
        #endregion

        #region help for (ToNumber<TNumber>()) of GetToBytes()

        private static byte[] GetBytes(byte[] bytes, int startIndex, int typeByteLen, byte autoApeendByteIfLengthLess, bool isAppendToEnd)
        {
            EnsureUtility.IsNotNull(bytes, "bytes,指定的转换字节数组长度不能是null,请确认");

            int byteLen = bytes.Length;
            byte[] _bytes = new byte[typeByteLen];
            List<byte> convertBytes = bytes.ToList();

            if (byteLen < typeByteLen)
            {
                for (int i = 0; i < typeByteLen - byteLen; i++)
                {
                    if (isAppendToEnd)
                    {
                        convertBytes.Add(autoApeendByteIfLengthLess);
                    }
                    else
                    {
                        convertBytes.Insert(0, autoApeendByteIfLengthLess);
                    }
                }
                Array.Copy(convertBytes.ToArray(), _bytes, typeByteLen);
            }
            else
            {
                Array.Copy(bytes, startIndex, _bytes, 0, typeByteLen);
            }
            return _bytes;
        }
        #endregion
    }
}
