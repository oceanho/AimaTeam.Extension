
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
    /// 
    /// </summary>
    /// <typeparam name="TTreeElement"></typeparam>
    /// <typeparam name="TTreeDataElement">树形节点上的数据对象</typeparam>
    public class EmptyIntegerIdTree<TTreeElement, TTreeDataElement> : AbstractTree<int, TTreeElement, TTreeDataElement>
        where TTreeDataElement : class, new()
        where TTreeElement : EmptyIntegerIdTree<TTreeElement, TTreeDataElement>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataCollection"></param>
        public EmptyIntegerIdTree(IEnumerable<TTreeDataElement> dataCollection) : base(dataCollection)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public override Type DataType
        {
            get
            {
                return typeof(TTreeDataElement);
            }
        }
    }
    /// <summary>
    /// 定义一个实现了继承并实现了AbstractTree抽象类,树节点的ID为int类型的树形结构对象类
    /// </summary>
    public class EmptyIntegerIdTree : AbstractTree<int, EmptyIntegerIdTree>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        public override void DeleteChildrenTree(Func<EmptyIntegerIdTree, bool> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idValue"></param>
        public override void DeleteChildrenTree(int idValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        public override void DeleteSiblingTree(Func<EmptyIntegerIdTree, bool> predicate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idValue"></param>
        public override void DeleteSiblingTree(int idValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeElement"></param>
        public override void NewChildrenTree(EmptyIntegerIdTree treeElement)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeElement"></param>
        public override void NewSiblingTree(EmptyIntegerIdTree treeElement)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 实现TreeType树形对象去实现
        /// </summary>
        public override Type DataType
        {
            get
            {
                return GetType();
            }
        }
    }
}
