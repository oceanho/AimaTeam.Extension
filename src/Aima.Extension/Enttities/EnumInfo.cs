using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AimaTeam.Common
{
    using Aima.Extension;
    using System.Reflection;

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
                throw new ArgumentException("参数enumType类型无效,请确认enumType参数的类型是一个合法的枚举。", innerException: null);
            this.enumType = enumType;

            EnumInfo<TValue> enumInfo;
            enumInfoList = new List<EnumInfo<TValue>>();
            foreach (var item in Enum.GetValues(enumType))
            {
                enumInfo = new EnumInfo<TValue>();
                enumInfo.Value = (TValue)item;
                enumInfo.Name = Enum.GetName(enumType, item);
#if COREFX
                enumInfo.CustomerAttributes = MemberInfoExtension4Attribute.GetAttributes(enumType.GetTypeInfo().AsType().GetField(enumInfo.Name),true).ToList();                
#else
                enumInfo.CustomerAttributes = MemberInfoExtension4Attribute.GetAttributes(enumType.GetField(enumInfo.Name), true).ToList();
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
        /// 获取指定类型
        /// </summary>
        public int Count
        {
            get
            {
                return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Count;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<EnumInfo<TValue>>)EnumInfoList).IsReadOnly;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(EnumInfo<TValue> item)
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(EnumInfo<TValue> item)
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Contains(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(EnumInfo<TValue>[] array, int arrayIndex)
        {
            ((ICollection<EnumInfo<TValue>>)EnumInfoList).CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<EnumInfo<TValue>> GetEnumerator()
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(EnumInfo<TValue> item)
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).Remove(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<EnumInfo<TValue>>)EnumInfoList).GetEnumerator();
        }
    }
}
