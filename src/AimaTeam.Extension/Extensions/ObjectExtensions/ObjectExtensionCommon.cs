/*
 *
 *   Copyright © 2015-Presents AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
  
 *   QQ Group：139849106
 *   Web Site：https://www.aimateam.org
 *   
 *   Licensed to the AimaTeam Open Source under one or more agreements.
 *   The AimaTeam Open Source licenses this file to you under the MIT license. 
 *   
 *   The MIT License
 *   
 *   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 *   documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
 *   the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
 *   to permit persons to whom the Software is furnished to do so, subject to the following conditions:　　
 *   The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 *   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
 *   THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 *   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 *   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 */

namespace AimaTeam.Extension
{
    /// <summary>
    /// Object类型常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class ObjectExtensionCommon
    {
        /// <summary>
        /// 验证对象是否为空引用。如果是空引用，返回True，不是返回False
        /// 注：针对String类型的数据，加入IsNullOrEmpty()方法进行了校验
        /// </summary>
        /// <param name="objSrc">指定校验的object对象</param>
        /// <returns></returns>
        public static bool IsNullReference(this object objSrc)
        {
            if (objSrc != null)
            {
                if (objSrc.GetType() == typeof(string))
                {
                    return objSrc.ToString().IsNullOrEmpty2();
                }
                return false;
            }
            return true;
        }
    }
}
