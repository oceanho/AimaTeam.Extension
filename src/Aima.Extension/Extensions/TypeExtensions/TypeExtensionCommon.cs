/*
 *
 *   Copyright © 2015-2115 AimaTeam
 * 
 *   author：he hai
 *   time：2015/01/01 09:09:09
 *   mail：OpenSource@AimaTeam.com 
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.com
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
using System.Reflection;

#if COREFX
using System.Collections.Generic;
#endif

namespace Aima.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class TypeExtensionCommon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string Name(this Type type)
        {
#if COREFX
            return type.GetTypeInfo().Name;
#else
            return type.Name;
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsValueType(this Type type)
        {
#if COREFX
            return type.GetTypeInfo().IsValueType;
#else
            return type.IsValueType;
#endif
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsEnum(this Type type)
        {
#if COREFX
            return type.GetTypeInfo().IsEnum;
#else
            return type.IsEnum;
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsGenericType(this Type type)
        {
#if COREFX
            return type.GetTypeInfo().IsGenericType;
#else
            return type.IsGenericType;
#endif
        }

        /// <summary>
        /// 判断指定的 type 是否是一个接口对象
        /// </summary>
        /// <param name="type">指定的type类型</param>
        /// <returns></returns>
        public static bool IsInterface(this Type type)
        {
#if COREFX
            return type.GetTypeInfo().IsInterface;
#else
            return type.IsInterface;
#endif
        }
#if COREFX
        /// <summary>
        /// 获取指定的 type 上所有的特性Attribute
        /// </summary>
        /// <param name="type">指定的type类型</param>
        /// <param name="inherit">是否允许在继承的对象上搜索</param>
        /// <returns></returns>
        public static IEnumerable<Attribute> GetCustomAttributes(this Type type, bool inherit)
        {
            return type.GetTypeInfo().GetCustomAttributes(inherit);
        }

        /// <summary>
        /// 获取指定 type 的 <see cref="TypeCode" />
        /// </summary>
        /// <param name="type">指定的type类型</param>
        /// <returns></returns>
        public static TypeCode GetTypeCode(this Type type)
        {
            if (type == null) return TypeCode.Empty;
            TypeCode result;
            if (typeCodeLookup.TryGetValue(type, out result)) return result;

            if (type.IsEnum())
            {
                type = Enum.GetUnderlyingType(type);
                if (typeCodeLookup.TryGetValue(type, out result)) return result;
            }
            return TypeCode.Object;
        }

        /// <summary>
        /// 定义 CSharp Type 与 TypeCode映射关系字典
        /// </summary>
        internal static readonly Dictionary<Type, TypeCode> typeCodeLookup = new Dictionary<Type, TypeCode>
        {
            {typeof(bool), TypeCode.Boolean },
            {typeof(byte), TypeCode.Byte },
            {typeof(char), TypeCode.Char},
            {typeof(DateTime), TypeCode.DateTime},
            {typeof(decimal), TypeCode.Decimal},
            {typeof(double), TypeCode.Double },
            {typeof(short), TypeCode.Int16 },
            {typeof(int), TypeCode.Int32 },
            {typeof(long), TypeCode.Int64 },
            {typeof(object), TypeCode.Object},
            {typeof(sbyte), TypeCode.SByte },
            {typeof(float), TypeCode.Single },
            {typeof(string), TypeCode.String },
            {typeof(ushort), TypeCode.UInt16 },
            {typeof(uint), TypeCode.UInt32 },
            {typeof(ulong), TypeCode.UInt64 },
        };
#else
        /// <summary>
        /// 获取指定 type 的 <see cref="TypeCode" />
        /// </summary>
        /// <param name="type">指定的type类型</param>
        /// <returns></returns>
        public static TypeCode GetTypeCode(this Type type)
        {
            return Type.GetTypeCode(type);
        }
#endif
        /// <summary>
        /// 获取指定 type 的 公共（public修饰符）方法
        /// </summary>
        /// <param name="type">指定的type类型</param>
        /// <param name="name">指定的查找的方法名称</param>
        /// <param name="types">指定的type类型搜索列表</param>
        /// <returns></returns>
        public static MethodInfo GetPublicMethodInfo(this Type type, string name, Type[] types)
        {
#if COREFX
            var method = type.GetMethod(name, types);
            return (method != null && method.IsPublic && !method.IsStatic) ? method : null;
#else
            return type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public, null, types, null);
#endif
        }
    }
}
