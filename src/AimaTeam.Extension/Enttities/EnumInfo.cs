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

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#if COREFX
    /*
    GetTypeInfo()是一个扩展方法,包含在 System.Reflection.TypeExtension 类中
    .NET Core 需要通过 GetTypeInfo().AsType()才能获取到对象的 Type    
    */
    using System.Reflection;
#endif

namespace AimaTeam.Extension
{
    /// <summary>
    /// 定义一个表示枚举
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public class EnumInfo<TValue>
    {
        /// <summary>
        /// 获取或者设置枚举项 <see cref="EnumInfo{TValue}"/> 的键名称
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// 获取或者设置枚举项 <see cref="EnumInfo{TValue}"/> 的值信息
        /// </summary>
        public TValue Value
        {
            get; set;
        }

        /// <summary>
        /// 获取或者设置枚举项 <see cref="EnumInfo{TValue}"/> 的 <see cref="DescriptionAttribute"/> Attribute标记
        /// </summary>
        public DescriptionAttribute Descriptor
        {
            get; set;
        }

        /// <summary>
        /// 获取或者设置枚举项 <see cref="EnumInfo{TValue}"/> 所有自定义 <see cref="Attribute"/> 标记列表（包括 <see cref="DescriptionAttribute"/>）
        /// </summary>
        public List<Attribute> CustomerAttributes
        {
            get; set;
        }
    }

    /// <summary>
    /// 定义一个表示 枚举所有键/值对象 <see cref="EnumInfo{TValue}"/> 集合的Collection
    /// </summary>
    public class EnumInfoCollection<TValue> : ICollection<EnumInfo<TValue>>
    {
        private Type enumType;
        private List<EnumInfo<TValue>> enumInfoList;

        /// <summary>
        /// 初始化 <see cref="EnumInfoCollection{TValue}"/>
        /// </summary>
        /// <param name="enumType">指定的枚举类型（通常使用typeof(XXX)指定）,此参数必须是任意的枚举类型</param>
        public EnumInfoCollection(Type enumType)
        {
            if (!enumType.IsEnum())
                throw new ArgumentException("参数enumType类型:{0}无效,请确认参数enumType的类型是一个合法的枚举。".Format2(nameof(enumType)), innerException: null);
            this.enumType = enumType;

            EnumInfo<TValue> enumInfo;
            enumInfoList = new List<EnumInfo<TValue>>();
            foreach (var item in Enum.GetValues(enumType))
            {
                enumInfo = new EnumInfo<TValue>();
                enumInfo.Value = (TValue)item;
                enumInfo.Name = Enum.GetName(enumType, item);
#if COREFX
                enumInfo.CustomerAttributes = MemberInfoExtensionAttribute.GetAttributes(enumType.GetTypeInfo().AsType().GetField(enumInfo.Name),true).ToList();                
#else
                enumInfo.CustomerAttributes = MemberInfoExtensionAttribute.GetAttributes(enumType.GetField(enumInfo.Name), true).ToList();
#endif
                enumInfo.Descriptor = (DescriptionAttribute)enumInfo.CustomerAttributes.FirstOrDefault(p => p.GetType() == typeof(DescriptionAttribute));
                enumInfoList.Add(enumInfo);
            }
        }

        /// <summary>
        /// 获取此 <see cref="EnumInfoCollection{TValue}"/> 的枚举类型
        /// </summary>
        public Type EnumType
        {
            get
            {
                return enumType;
            }
        }

        /// <summary>
        /// 获取此 <see cref="EnumInfoCollection{TValue}"/> 的枚举键/值信息 <see cref="EnumInfo{TValue}"/> 列表
        /// </summary>
        public List<EnumInfo<TValue>> EnumInfoList
        {
            get
            {
                return enumInfoList;
            }
        }

        /// <summary>
        /// 获取元素个数
        /// </summary>
        public int Count
        {
            get
            {
                return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Count;
            }
        }

        /// <summary>
        /// 获取元素是否只读
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<EnumInfo<TValue>>)EnumInfoList).IsReadOnly;
            }
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="item"></param>
        public void Add(EnumInfo<TValue> item)
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).Add(item);
        }

        /// <summary>
        /// 清空所有元素
        /// </summary>
        public void Clear()
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).Clear();
        }

        /// <summary>
        /// 是否保护某个元素
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(EnumInfo<TValue> item)
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Contains(item);
        }

        /// <summary>
        /// 复制元素
        /// </summary>
        /// <param name="array">目标数组</param>
        /// <param name="arrayIndex">开始下标</param>
        public void CopyTo(EnumInfo<TValue>[] array, int arrayIndex)
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// 获取元素枚举器
        /// </summary>
        /// <returns></returns>
        public IEnumerator<EnumInfo<TValue>> GetEnumerator()
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).GetEnumerator();
        }

        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(EnumInfo<TValue> item)
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Remove(item);
        }

        /// <summary>
        /// 获取元素枚举器
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).GetEnumerator();
        }
    }
}