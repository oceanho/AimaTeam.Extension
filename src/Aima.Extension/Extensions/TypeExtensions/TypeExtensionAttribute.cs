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
using System.Collections.Generic;
using System.ComponentModel;


namespace Aima.Extension
{
    /// <summary>
    /// System.Type -> Attribute标记常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class TypeExtensionAttribute
    {
        /// <summary>
        /// 获取某个类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组
        /// </summary>
        /// <typeparam name="TAttribute">指定的Attribute类型</typeparam>
        /// <param name="typesrc">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns>类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组</returns>
        public static TAttribute[] GetAttributes<TAttribute>(this Type typesrc, bool inherit) where TAttribute : Attribute
        {
            List<TAttribute> attrList = new List<TAttribute>();

#if COREFX
            IEnumerable<System.Attribute> attributes = typesrc.GetTypeInfo().GetCustomAttributes(typeof(TAttribute), inherit);
#else
            object[] attributes = typesrc.GetCustomAttributes(typeof(TAttribute), inherit);
#endif
            foreach (var itemAttr in attributes)
            {
                attrList.Add((TAttribute)itemAttr);
            }
            return attrList.ToArray();
        }

        /// <summary>
        /// 获取某个类型的DescriptionAttribute标记集合列表（搜索此成员的继承链查找，即可以搜索到此类型集成的类,实现的接口上的DescriptionAttribute标记）
        /// </summary>
        /// <param name="typesrc">指定的获取TAttribute的对象类型</param>
        /// <returns></returns>
        public static DescriptionAttribute[] GetDescriptionAttributes(this Type typesrc)
        {
            return typesrc.GetDescriptionAttributes(true);
        }

        /// <summary>
        /// 通过指定inherit获取某个类型的DescriptionAttribute标记集合列表
        /// </summary>
        /// <param name="typesrc">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns></returns>
        public static DescriptionAttribute[] GetDescriptionAttributes(this Type typesrc, bool inherit)
        {
            return typesrc.GetAttributes<DescriptionAttribute>(inherit);
        }
    }
}
