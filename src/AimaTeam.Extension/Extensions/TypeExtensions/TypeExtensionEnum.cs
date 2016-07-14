/*
 *
 *   Copyright © 2015-Presents AimaTeam
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

namespace AimaTeam.Extension
{
    /// <summary>
    /// System.Type -> Enum常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class TypeExtensionEnum
    {
        /// <summary>
        /// 获取枚举对象的键/值集合以及Attribute附加属性信息,参数必须是枚举Type,否则会抛出 <see cref="ArgumentException"/>
        /// </summary>
        /// <typeparam name="TEnumValue">指定枚举没的枚举值的。net数据类型</typeparam>
        /// <param name="enumType">指定的枚举类型（通常使用typeof(XXX)指定）,此参数必须是任意的枚举类型</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static EnumInfoCollection<TEnumValue> GetEnumInfoCollection<TEnumValue>(this Type enumType)
        {
            return new EnumInfoCollection<TEnumValue>(enumType);
        }
    }
}
