/*
 *
 *   Copyright © 2015-2115 AimaTeam
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

namespace Aima.Extension.Utilities
{
    /// <summary>
    /// Exception的创建类
    /// </summary>
    internal sealed class ExceptionUtility
    {
        /// <summary>
        /// 创建一个指定Exception类型的Exception对象
        /// </summary>
        /// <typeparam name="TExceptionType">Exception对象或子对象</typeparam>
        /// <param name="message">消息</param>
        /// <returns></returns>
        internal static TExceptionType Create<TExceptionType>(string message) where TExceptionType : Exception
        {
            return (TExceptionType)Activator.CreateInstance(typeof(TExceptionType), new object[] { message });
        }

        /// <summary>
        /// 创建一个指定Exception类型的Exception对象
        /// </summary>
        /// <typeparam name="TExceptionType">Exception对象或子对象</typeparam>
        /// /// <param name="message">消息</param>
        /// <param name="innerException">异常消息</param>
        /// <returns></returns>
        internal static TExceptionType Create<TExceptionType>(string message, Exception innerException) where TExceptionType : Exception
        {
            return (TExceptionType)Activator.CreateInstance(typeof(TExceptionType), new object[] { message, innerException });
        }
    }
}
