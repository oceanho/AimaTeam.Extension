
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
    /// 定义一个实现了继承并实现了AbstractTree抽象类,树节点的ID为long类型的树形结构对象类
    /// </summary>
    public class EmptyInteger64IdTree<TTreeElement, TTreeDataElement> : AbstractTree<int, TTreeElement, TTreeDataElement>
        where TTreeDataElement : class, new()
        where TTreeElement : EmptyInteger64IdTree<TTreeElement, TTreeDataElement>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataCollection"></param>
        public EmptyInteger64IdTree(IEnumerable<TTreeDataElement> dataCollection) : base(dataCollection)
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
}
