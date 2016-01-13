
/***************************************************************
*
*   AimaTeam开源项目（版权所有：copyright@aimaTeam.com）       
*   尽管它开源,我们真心希望您可以为我们保留的版权信息，谢谢
----------------------------------------------------------------
*   作   者：Hai he
*   日   期：2015/12/8 1:37:34
*   博   客：https://hehai.aimateam.com
*   说   明：
----------------------------------------------------------------
*
*   官方QQ群号：139849106
*   官方  网站：https://www.aimateam.com
****************************************************************/

using System;

/* 项目“Aima.Extension..NET Platform 5.4”的未合并的更改
在此之前:
using System.Collections;
using System.Collections.Generic;
在此之后:
using System.Collections.Generic;
*/
using System.Collections.Generic;
using System.ComponentModel;



#if COREFX
using DescriptionAttribute = Aima.Extension.MissingfromDNX.DescriptionAttribute;
#endif
namespace Aima.Extension
{
    /// <summary>
    /// MemberInfo （FiledInfo / PropertyInfo）等实现了 ICustomAttributeProvider接口的Attribute操作而定义的扩展方法静态类
    /// </summary>
    public static partial class MemberInfoExtension4Attribute
    {
        /// <summary>
        /// 获取某个类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组
        /// </summary>
        /// <typeparam name="TAttribute">指定的Attribute类型</typeparam>
        /// <param name="memberInfo">指定的获取TAttribute的对象类型</param>
        /// <param name="inherit">搜索此成员的继承链以查找这些属性，则为 true；否则为 false。属性和事件中忽略此参数</param>
        /// <returns>类型的TAttribute属性集合列表,没有指定的Attribute类型,返回长度为零的TAttribute数组</returns>
        public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this System.Reflection.MemberInfo memberInfo, bool inherit) where TAttribute : Attribute
        {
            // List<TAttribute> attrList = new List<TAttribute>();
#if COREFX
            foreach (var itemAttr in System.Reflection.CustomAttributeExtensions.GetCustomAttributes(memberInfo,inherit))
#else
            foreach (var itemAttr in memberInfo.GetCustomAttributes(typeof(TAttribute), inherit))
#endif
            {
                yield return (TAttribute)itemAttr;
                // attrList.Add((TAttribute)itemAttr);
            }
            yield break;
            // return attrList.ToArray();
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
