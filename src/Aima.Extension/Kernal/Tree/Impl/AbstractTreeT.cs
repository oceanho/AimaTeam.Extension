
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
using System.Collections.Generic;namespace Aima.Extension.Kernal.Tree.Impl
{
    /// <summary>
    /// 定义一个包含具体数据绑定对象DataElement的树形结构的抽象类
    /// </summary>
    /// <typeparam name="IdType">树主ID类型</typeparam>
    /// <typeparam name="TreeElement">树实现类型</typeparam>
    /// <typeparam name="TDataElement">树节点绑定数据类型</typeparam>
    public abstract class AbstractTree<IdType, TreeElement, TDataElement> : AbstractTree<IdType, TreeElement>, ITree<IdType, TDataElement>
        where TDataElement : class, new()
        where TreeElement : ITree<IdType, TDataElement>
    {
        internal IEnumerable<TDataElement> _dataElementCollection;

        /// <summary>
        /// 定义一个包含具体数据绑定对象DataElement的树形结构的抽象类
        /// </summary>
        /// <param name="dataElementCollection"></param>
        public AbstractTree(IEnumerable<TDataElement> dataElementCollection)
        {
            _dataElementCollection = dataElementCollection;
        }

        /// <summary>
        /// 获取表示当前树节点上的TDataElement数据集合
        /// </summary>
        public virtual IEnumerable<TDataElement> DataElementCollection
        {
            get { return _dataElementCollection; }
        }

        /// <summary>
        /// 抽象一个表示创建树形对象并且执行绑定操作的方法
        /// </summary>
        /// <param name="bindHandler">当执行绑定时委托方法</param>
        public virtual void Bind(Func<IEnumerable<TDataElement>, TreeElement> bindHandler)
        {

        }

        /// <summary>
        /// 实现树上的数据Enumerator
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerator<TDataElement> GetEnumerator()
        {
            return _dataElementCollection.GetEnumerator();
        }


        /// <summary>
        /// 实现树上的数据Enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dataElementCollection.GetEnumerator();
        }
    }
}