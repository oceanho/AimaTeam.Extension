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

namespace Aima.Extension
{
    /// <summary>
    /// Object类型常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class ObjectExtensionCopyPaste
    {
        /// <summary>
        /// 复制一个对象
        /// </summary>
        /// <typeparam name="TSrcType"></typeparam>
        /// <param name="src"></param>
        /// <returns></returns>
        public static TSrcType Copy<TSrcType>(this TSrcType src) where TSrcType : class, new()
        {
            var sp = new object();
            throw new System.NotImplementedException();
            // return default(TSrcType);
        }

        /// <summary>
        /// 复制一个对象
        /// </summary>
        /// <typeparam name="TSrcType"></typeparam>
        /// <typeparam name="TDestType"></typeparam>
        /// <param name="src"></param>
        /// <returns></returns>
        public static TDestType CopyTo<TSrcType, TDestType>(this TSrcType src)
            where TSrcType : class, new()
            where TDestType : class, new()
        {
            var sp = new object();
            throw new System.NotImplementedException();
            // return default(TSrcType);
        }
    }
}
