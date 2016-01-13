
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
namespace Aima.Extension.Kernal.Tree.Impl
{
    /// <summary>
    /// 定义一个实现了ITree接口的抽象类
    /// </summary>
    /// <typeparam name="IdType">树形结构的主键数据类型</typeparam>
    /// <typeparam name="TTreeElement">树形结构的数据对象</typeparam>
    public abstract class AbstractTree<IdType, TTreeElement> : ITree<IdType> where TTreeElement : ITree<IdType>
    {
        private IdType _id;
        private IdType _parentId;
        private IEnumerable<TTreeElement> _childCollection;

        private static readonly IdType _defaultIdType = default(IdType);

        /// <summary>
        /// 创建一个ITree接口的抽象类AbstractTree实例
        /// </summary>
        public AbstractTree() : this(_defaultIdType, _defaultIdType, null)
        {

        }

        /// <summary>
        /// 创建一个ITree接口的抽象类AbstractTree实例
        /// </summary>
        /// <param name="id">节点ID号</param>
        public AbstractTree(IdType id) : this(id, _defaultIdType, null)
        {

        }

        /// <summary>
        /// 创建一个ITree接口的抽象类AbstractTree实例
        /// </summary>
        /// <param name="id">当前节点ID</param>
        /// <param name="parentId">父级节点ID号</param>
        public AbstractTree(IdType id, IdType parentId)
            : this(id, parentId, null)
        {
        }

        /// <summary>
        /// 创建一个ITree接口的抽象类AbstractTree实例
        /// </summary>
        /// <param name="id">当前节点ID</param>
        /// <param name="parentId">父级节点ID号</param>
        /// <param name="childCollection">子级节点集合对象</param>
        public AbstractTree(IdType id, IdType parentId, IEnumerable<TTreeElement> childCollection)
        {
            _id = id;
            _parentId = parentId;
            _childCollection = childCollection;
        }

        /// <summary>
        /// 当前节点的ID号
        /// </summary>
        public virtual IdType ID
        {
            get { return _id; }
            internal set { _id = value; }
        }

        /// <summary>
        /// 当前节点父节点的ID号
        /// </summary>
        public virtual IdType ParentID
        {
            get { return _parentId; }
            internal set { _parentId = value; }
        }

        /// <summary>
        /// 子级节点集合对象
        /// </summary>
        public virtual IEnumerable<ITree<IdType>> Children
        {
            get { return _childCollection as IEnumerable<ITree<IdType>>; }
        }

        /// <summary>
        /// 抽象属性类型,让具体的树形对象去实现它,因为这里的定义并不知道树上的数据对象
        /// </summary>
        public abstract Type DataType
        {
            get;
        }

        /// <summary>
        /// 定义一个用于创建一个同级的TreeElement树树节点对象
        /// </summary>
        /// <param name="treeElement">TreeElement类型的树对象</param>
        public virtual void NewSiblingTree(TTreeElement treeElement)
        {

        }

        /// <summary>
        /// 定义一个用于移除同级树形结构中,同级节点下ID等于idValue的节点
        /// </summary>
        /// <param name="idValue">同级节点ID的值</param>
        public virtual void DeleteSiblingTree(IdType idValue)
        {

        }

        /// <summary>
        /// 定义一个用于移除同级树形结构中,同级节点下满足条件断言predicate的所有节点
        /// </summary>
        /// <param name="predicate">条件断言predicate</param>
        public virtual void DeleteSiblingTree(Func<TTreeElement, bool> predicate)
        {

        }

        /// <summary>
        /// 定义一个用于创建一个子级的TreeElement树节点对象
        /// </summary>
        /// <param name="treeElement">TreeElement类型的树对象</param>
        public virtual void NewChildrenTree(TTreeElement treeElement)
        {

        }

        /// <summary>
        /// 定义一个用于移除当前树形结构中,子级节点下ID等于idValue的节点
        /// </summary>
        /// <param name="idValue">子级节点ID的值</param>
        public virtual void DeleteChildrenTree(IdType idValue)
        {

        }

        /// <summary>
        /// 定义一个用于移除子级树形结构中,子级节点下满足条件断言predicate的所有节点
        /// </summary>
        /// <param name="predicate">条件断言predicate</param>
        public virtual void DeleteChildrenTree(Func<TTreeElement, bool> predicate)
        {

        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        /// <summary>
        /// 释放未托管的资源
        /// </summary>
        /// <param name="disposing">资源是否释放中</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                    _childCollection = null;
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~AbstractTree() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        /// <summary>
        /// 将清理代码放入以上 Dispose(bool disposing)
        /// </summary>
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}