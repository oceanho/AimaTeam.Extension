/*
 *
 *   Copyright © 2015-2115 AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
 *   mail：opensource@aimateam.org 
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

using System;
using System.Collections.Generic;
using System.Linq;
namespace Aima.Extension
{
    /// <summary>
    /// Numeric与字节数组常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class NumericExtensionBytesParser
    {
        /// <summary>
        /// 将指定的实现了IConvertible接口的Numeric对象转换为字节数组
        /// </summary>
        /// <param name="convertible">实现了IConvertible接口的Numeric对象</param>
        /// <returns></returns>
        public static IEnumerable<byte> ToBytes(this IConvertible convertible)
        {
            switch (convertible.GetType().GetTypeCode())
            {
                case TypeCode.Char:
                    return BitConverter.GetBytes((char)convertible);
                case TypeCode.Int16:
                    return BitConverter.GetBytes((int)convertible);
                case TypeCode.UInt16:
                    return BitConverter.GetBytes((uint)convertible);
                case TypeCode.Int32:
                    return BitConverter.GetBytes((int)convertible);
                case TypeCode.UInt32:
                    return BitConverter.GetBytes((uint)convertible);
                case TypeCode.Int64:
                    return BitConverter.GetBytes((long)convertible);
                case TypeCode.UInt64:
                    return BitConverter.GetBytes((ulong)convertible);
                case TypeCode.Single:
                    return BitConverter.GetBytes((float)convertible);
                case TypeCode.Double:
                    return BitConverter.GetBytes((double)convertible);
                default:
                    throw new InvalidCastException("指定的convertible类型不是一个有效的CSharp数值数据类型,有效类型必须是:{0}".JoinFormat("/",
                        "Char", "Int16", "UInt16", "Int32", "UInt32", "Int64", "UInt64", "Single", "Double"));
            }
        }

        /// <summary>
        /// 将指定的实现了IConvertible接口的Numeric对象转换为字节数组
        /// </summary>
        /// <param name="convertible">实现了IConvertible接口的Numeric对象</param>
        /// <returns></returns>
        public static byte[] ToBytesArray(this IConvertible convertible)
        {
            return convertible.ToBytes().ToArray();
        }

        /// <summary>
        /// 将指定的实现了IConvertible接口的Numeric对象转换为字节数组
        /// </summary>
        /// <param name="convertible">实现了IConvertible接口的Numeric对象</param>
        /// <returns></returns>
        public static List<byte> ToBytesList(this IConvertible convertible)
        {
            return convertible.ToBytes().ToList();
        }
    }
}
