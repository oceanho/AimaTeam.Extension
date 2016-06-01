using Aima.Extension.Utilities;
using Aima.Extension.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Aima.Extension
{
    /// <summary>
    /// Numeric与字节数组常用转换操作而定义的扩展方法静态类
    /// </summary>
    public static partial class NumericExtension4BytesParser
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
