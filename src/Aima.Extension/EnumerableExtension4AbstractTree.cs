
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
using System.Collections;
using System.Collections.Generic;

namespace Aima.Extension
{
    using Kernal.Tree;

    /// <summary>
    /// IEnumerable接口的实现类对树形菜单的操作而定义的扩展方法静态类
    /// </summary>
    public static partial class EnumerableExtension4ITree
    {
        /// <summary>
        /// IEnumerable对象转换为树形对象
        /// </summary>
        /// <typeparam name="TTreeElement">树形对象</typeparam>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static TTreeElement ToTree<TTreeElement>(this IEnumerable dataSource) where TTreeElement : ITree
        {
            return default(TTreeElement);
        }

        /// <summary>
        /// IEnumerable对象转换为树形对象
        /// </summary>
        /// <typeparam name="TTreeElement">树形对象</typeparam>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static IEnumerable<TTreeElement> ToTreeCollection<TTreeElement>(this IEnumerable dataSource) where TTreeElement : ITree
        {
            TTreeElement treeElement = (TTreeElement)Activator.CreateInstance(typeof(TTreeElement));
            List<TTreeElement> tTreeElementList = new List<TTreeElement>();

            var enumerator = dataSource.GetEnumerator();
            while (enumerator.MoveNext())
            {
                // enumerator.Current
            }

            throw new NotImplementedException();
        }

        ///// <summary>
        ///// IEnumerable对象转换为树形对象
        ///// </summary>
        ///// <typeparam name="TTreeElement">树形对象</typeparam>
        ///// <param name="dataSource"></param>
        ///// <returns></returns>
        //public static IEnumerable<TTreeElement> ToTreeCollection<TTreeElement>(this IEnumerable dataSource) where TTreeElement : ITree
        //{
        //    TTreeElement treeElement = (TTreeElement)Activator.CreateInstance(typeof(TTreeElement));
        //    List<TTreeElement> tTreeElementList = new List<TTreeElement>();

        //    var enumerator = dataSource.GetEnumerator();
        //    while (enumerator.MoveNext())
        //    {
        //        // treeElement.DataType
        //    }

        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// IEnumerable对象转换为树形对象
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static ITree ToTree<TSource>(this IEnumerable<TSource> dataSource)
        {
            return default(ITree);
        }

        /// <summary>
        /// IEnumerable对象转换为树形对象
        /// </summary>
        /// <typeparam name="TTreeElement">树形对象</typeparam>
        /// <typeparam name="TDataElement"></typeparam>
        /// <typeparam name="IdType"></typeparam>
        /// <param name="dataSource"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public static IEnumerable<TTreeElement> ToTrees<IdType, TTreeElement, TDataElement>(this IEnumerable<TDataElement> dataSource, IdType parentId) where TTreeElement : ITree<IdType, TDataElement>
        {
            return new List<TTreeElement>();
        }
    }
}
