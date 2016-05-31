
/***************************************************************
*
*   AimaTeam开源项目（版权所有：copyright@aimaTeam.com）       
*   Dear,我们真心希望您可以为我们保留的版权信息,o(∩_∩)o 
----------------------------------------------------------------
*   作   者：Mr.Hai
*   日   期：2015/12/8 1:37:34
*   博   客：https://hehai.aimateam.com
*   说   明：
----------------------------------------------------------------
*
*   官方QQ群号：139849106
*   官方  网站：https://www.aimateam.com
****************************************************************/

using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;


namespace Aima.Extension
{
    /// <summary>
    /// System.Type -> Attribute标记常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class AttributeProvider4Common
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
