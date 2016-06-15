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
using System.ComponentModel;
using System.Collections.Generic;

namespace AimaTeam.Extension
{
    /// <summary>
    /// MemberInfo （FiledInfo / PropertyInfo）等实现了 ICustomAttributeProvider接口的Attribute操作而定义的扩展方法静态类
    /// </summary>
    public static partial class MemberInfoExtensionAttribute
    {
        /// <summary>
        /// 获取某个类型的TAttribute属性集合列表,没有指定的Attribute类型,返回 MemberInfo 上所有的Attribute
        /// </summary>
        /// <param name="memberInfo">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns>类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组</returns>
        public static IEnumerable<Attribute> GetAttributes(this System.Reflection.MemberInfo memberInfo, bool inherit)
        {
#if COREFX
            foreach (var itemAttr in System.Reflection.CustomAttributeExtensions.GetCustomAttributes(memberInfo,inherit))
#else
            foreach (var itemAttr in memberInfo.GetCustomAttributes(inherit))
#endif
            {
                yield return (Attribute)itemAttr;
            }
            yield break;
        }

        /// <summary>
        /// 获取某个类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组
        /// </summary>
        /// <typeparam name="TAttribute">指定的Attribute类型</typeparam>
        /// <param name="memberInfo">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns>类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组</returns>
        public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this System.Reflection.MemberInfo memberInfo, bool inherit) where TAttribute : Attribute
        {
#if COREFX
            foreach (var itemAttr in System.Reflection.CustomAttributeExtensions.GetCustomAttributes(memberInfo,inherit))
#else
            foreach (var itemAttr in memberInfo.GetCustomAttributes(typeof(TAttribute), inherit))
#endif
            {
                yield return (TAttribute)itemAttr;
            }
            yield break;
        }

        /// <summary>
        /// 获取某个类型的DescriptionAttribute标记集合列表（搜索此成员的继承链查找，即可以搜索到此类型集成的类,实现的接口上的DescriptionAttribute标记）
        /// </summary>
        /// <param name="memberInfo">指定的获取TAttribute的对象类型</param>
        /// <returns></returns>
        public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(this System.Reflection.MemberInfo memberInfo)
        {
            return memberInfo.GetDescriptionAttributes(true);
        }

        /// <summary>
        /// 通过指定inherit获取某个类型的DescriptionAttribute标记集合列表
        /// </summary>
        /// <param name="memberInfo">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns></returns>
        public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(this System.Reflection.MemberInfo memberInfo, bool inherit)
        {
            return memberInfo.GetAttributes<DescriptionAttribute>(inherit);
        }
    }
}
