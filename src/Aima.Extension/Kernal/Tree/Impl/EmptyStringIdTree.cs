
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

namespace Aima.Extension.Kernal.Tree.Impl
{
    /// <summary>
    /// 定义一个实现了继承并实现了AbstractTree抽象类,树节点的ID为string类型的树形结构对象类
    /// </summary>
    public class EmptyStringIdTree : AbstractTree<string, EmptyStringIdTree>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        public override void DeleteChildrenTree(Func<EmptyStringIdTree, bool> predicate)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idValue"></param>
        public override void DeleteChildrenTree(string idValue)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        public override void DeleteSiblingTree(Func<EmptyStringIdTree, bool> predicate)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idValue"></param>
        public override void DeleteSiblingTree(string idValue)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeElement"></param>
        public override void NewChildrenTree(EmptyStringIdTree treeElement)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeElement"></param>
        public override void NewSiblingTree(EmptyStringIdTree treeElement)
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
