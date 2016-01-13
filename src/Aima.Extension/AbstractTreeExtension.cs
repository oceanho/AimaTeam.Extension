
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

using System.Collections.Generic;

#if Net20
using Aima.Extension.Net20.Missfrom;
#else
using System.Linq;
#endif
namespace Aima.Extension
{
    using Util;
    using Kernal.Tree;
    using Kernal.Tree.Impl;

    /// <summary>
    /// AbstractTree树形结构操作而定义的扩展方法静态类
    /// </summary>
    public static partial class AbstractTreeExtension
    {
        /// <summary>
        /// 获取一个树形结构的中父级Id等于参数id的所有子树对象
        /// </summary>
        /// <typeparam name="IdType">节点类型</typeparam>
        /// <param name="treeSource">树结构的数据</param>
        /// <param name="id">树Id号</param>
        public static IEnumerable<ITree<IdType>> GetChildren<IdType>(this ITree<IdType> treeSource, IdType id)
        {
            foreach (var item in treeSource.Children)
            {
                if (item.ParentID.Equals(id))
                {
                    yield return item;
                }
            }
            yield break;
        }

        /// <summary>
        /// 获取一个树形结构的中父级Id等于参数id的所有子树TElement对象
        /// </summary>
        /// <typeparam name="IdType">节点类型</typeparam>
        /// <typeparam name="TTreeElement">ITree&lt;IdType&gt;具体实现对象</typeparam>
        /// <param name="treeSource">树结构的数据</param>
        /// <param name="id">树Id号</param>
        /// <returns></returns>
        public static IEnumerable<TTreeElement> GetChildren<IdType, TTreeElement>(this ITree<IdType> treeSource, IdType id) where TTreeElement : ITree<IdType>
        {
            foreach (var item in treeSource.Children)
            {
                if (item.ParentID.Equals(id))
                {
                    yield return (TTreeElement)item;
                }
            }
            yield break;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="IdType"></typeparam>
        /// <typeparam name="TDataElement"></typeparam>
        /// <param name="foreachHandler"></param>
        /// <param name="treeSource"></param>
#if Net20
        public static void ForEach<IdType,TDataElement>(this ITree<IdType,TDataElement> treeSource,Net20.Missfrom.Action<ITree<IdType, TDataElement>> foreachHandler)
#else
        public static void ForEach<IdType, TDataElement>(this ITree<IdType, TDataElement> treeSource, System.Action<ITree<IdType, TDataElement>> foreachHandler)
#endif
        {
            Ensure.IsNotNull(treeSource, "treeSource");
            //if (foreachHandler(treeSource)) return;
            //foreach (var item in treeSource.GetChildren<IdType, TDataElement>(treeSource.ID))
            //{
            //    if (foreachHandler(item)) return;
            //    if (item.Children.Count() > 0)
            //    {
            //        if (RecursionEachTree(item, foreachHandler)) return;
            //    }
            //}
        }

        #region private Herper Methods

        /// <summary>
        /// 递归遍历所有的树
        /// </summary>
        /// <typeparam name="IdType">树的ID类型</typeparam>
        /// <typeparam name="TreeElement">继承并且实现了AbstractTree的树对象</typeparam>
        /// <param name="treeSource"></param>
        /// <param name="eachHandler"></param>
        /// <returns></returns>
#if Net20
        private static bool RecursionEachTree<IdType, TreeElement>(AbstractTree<IdType, TreeElement> treeSource, Func<AbstractTree<IdType, TreeElement>, bool> eachHandler) where TreeElement : AbstractTree<IdType, TreeElement>
#else
        private static bool RecursionEachTree<IdType, TreeElement>(AbstractTree<IdType, TreeElement> treeSource, System.Func<AbstractTree<IdType, TreeElement>, bool> eachHandler) where TreeElement : AbstractTree<IdType, TreeElement>
#endif
        {
            Ensure.IsNotNull(treeSource, "treeSource");
            if (eachHandler(treeSource)) return true;
            foreach (var item in treeSource.GetChildren<IdType, TreeElement>(treeSource.ID))
            {
                if (eachHandler(item)) return true;
                if (item.Children.Count() > 0)
                {
                    if (!RecursionEachTree(treeSource, eachHandler))
                    {
                        return false;
                    }
                }
            }

            // 遍历完,Return True
            return true;
        }
#endregion
    }
}
