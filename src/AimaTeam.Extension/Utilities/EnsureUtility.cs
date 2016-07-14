/*
 *
 *   Copyright © 2015-Presents AimaTeam
 * 
 *   author：he hai
 *   time：2015/05/08
 *   mail：opensource@aimateam.org 
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

using System;
namespace AimaTeam.Extension.Utilities
{
    /// <summary>
    /// 断言工具
    /// </summary>
    internal sealed class EnsureUtility
    {        
        /// <summary>
        /// 断言一个对象不为空,为空抛出异常
        /// </summary>
        /// <param name="obj">断言的对象</param>
        /// <param name="argumentName">为空异常的参数名称</param>
        internal static void IsNotNull(object obj, string argumentName)
        {
            if (obj == null)
                throw ExceptionUtility.Create<ArgumentNullException>(argumentName);

            var type = obj.GetType();
            if (type == typeof(string))
            {
                if (StringExtensionCommon.IsNullOrEmpty2(obj.ToString()))
                    throw ExceptionUtility.Create<ArgumentNullException>(argumentName);
            }
        }
    }
}
