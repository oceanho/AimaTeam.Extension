
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
using System.Collections.Generic;


namespace Aima.Extension.Kernal.Tree
{
    /// <summary>
    /// 定义一个表示树形结构
    /// </summary>
    public interface ITree : IDisposable
    {
        /// <summary>
        /// 定义一个属性,该树形表示树形结构上节点的数据类型
        /// </summary>
        Type DataType { get; }
    }

    /// <summary>
    /// 定义一个表示树形结构的接口对象
    /// </summary>
    public interface ITree<IdType> : ITree
    {
        /// <summary>
        /// 定义一个树形接口主键ID
        /// </summary>
        IdType ID { get; }

        /// <summary>
        /// 定义一个树形结构父节ID
        /// </summary>
        IdType ParentID { get; }

        /// <summary>
        /// 定义一个树形结构的子节点集合
        /// </summary>
        IEnumerable<ITree<IdType>> Children { get; }
    }

    /// <summary>
    /// 定义一个表示树形结构并且树节点包含指定类型数据的树形接口对象
    /// </summary>
    /// <typeparam name="IdType">Id类型</typeparam>
    /// <typeparam name="TDataElement">数据类型</typeparam>
    public interface ITree<IdType, TDataElement> : ITree<IdType>, IEnumerable<TDataElement>
    {
    }
}