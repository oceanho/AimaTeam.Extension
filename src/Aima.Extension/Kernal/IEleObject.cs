
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

namespace Aima.Extension.Kernal
{
    /// <summary>
    /// 定义一个需要对对象实现增加、删除、修改、读取操作的接口对象
    /// </summary>
    public interface IEleObject<TElement> : ICollection<TElement>, IDisposable
    {
        /// <summary>
        /// 定义一个表示在指定位置插入一个对象的方法
        /// </summary>
        /// <param name="index">插入索引,0开始</param>
        /// <param name="element">TElement对象</param>
        void Insert(int index, TElement element);

        /// <summary>
        /// 定义一个表示移除指定位置元素的方法
        /// </summary>
        /// <param name="index">指定移除的索引</param>
        void Remove(int index);
        

        /// <summary>
        /// 定义一个移除满足predicate断言TElement对象的方法
        /// </summary>
        /// <param name="predicate"></param>
        void Remove(Func<TElement, bool> predicate);
        

        /// <summary>
        /// 定义一个表示根据索引获取TElement对象的方法
        /// </summary>
        /// <param name="index">索引号,0开始</param>
        /// <returns></returns>
        TElement Get(int index);

        /// <summary>
        /// 定义获取满足predicate断言的一个TElement的方法
        /// </summary>
        /// <param name="predicate">predicate断言</param>
        /// <returns></returns>
        TElement Get(Func<TElement, bool> predicate);

        /// <summary>
        /// 定义获取全部TElement方法
        /// </summary>
        /// <returns></returns>
        IEnumerable<TElement> GetAll();

        /// <summary>
        /// 定义获取满足predicate断言的全部TElement的方法
        /// </summary>
        /// <param name="predicate">predicate断言</param>
        /// <returns></returns>
        IEnumerable<TElement> GetList(Func<TElement, bool> predicate);

        /// <summary>
        /// 定义一个方法，该方法用于实现对自定义对象的资源释放管理
        /// </summary>
        /// <param name="isDisponseing">资源是否释放中</param>
        void Disponse(bool isDisponseing);
    }
}
