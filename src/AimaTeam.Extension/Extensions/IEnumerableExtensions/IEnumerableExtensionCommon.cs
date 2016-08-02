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

using AimaTeam.Extension.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace AimaTeam.Extension
{
    /// <summary>
    /// <see cref="System.Collections.IEnumerable"/> 常用操作而定义的扩展方法静态类
    /// </summary>
    public static partial class IEnumerableExtensionCommon
    {
        /// <summary>
        /// 拷贝一份新的 <see cref="System.Collections.IEnumerable"/>&lt;T&gt;
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="enumerableSource"><see cref="System.Collections.IEnumerable"/>&lt;T&gt;源</param>
        /// <param name="startIndex">拷贝开始位置</param>
        /// <param name="length">拷贝长度</param>
        /// <returns></returns>
        public static IEnumerable<T> CopyNew<T>(this IEnumerable<T> enumerableSource,int startIndex,int length)
        {
            var mvIndex = 0;
            var maxMvIndex = startIndex + length - 1;
            // T[] tArray = new T[maxMvIndex];
            var enumerator = enumerableSource.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (mvIndex++ < startIndex)
                    continue;

                if (mvIndex > maxMvIndex )
                    break;
                yield return SerializeUtility.DeepCopy<T>(enumerator.Current);
                // yield return enumerator.Current;
                // tArray[mvIndex] = enumerator.Current;
                // mvIndex++;                
            }
            yield break;
            // return tArray;
        }
        /// <summary>
        /// 拷贝一份新的 <see cref="System.Collections.IEnumerable"/>&lt;T&gt;
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="enumerableSource"><see cref="System.Collections.IEnumerable"/>&lt;T&gt;源</param>
        /// <param name="startIndex">拷贝开始位置</param>
        /// <param name="endIndex">拷贝结束位置</param>
        /// <returns></returns>
        public static IEnumerable<T> CopyNew2<T>(this IEnumerable<T> enumerableSource, int startIndex, int endIndex)
        {
            var mvIndex = 0;
            // var maxMvIndex = startIndex + length - 1;
            // T[] tArray = new T[maxMvIndex];
            var enumerator = enumerableSource.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (mvIndex++ < startIndex)
                    continue;

                if (mvIndex > endIndex)
                    break;
                yield return SerializeUtility.DeepCopy<T>(enumerator.Current);
                // yield return enumerator.Current;
                // tArray[mvIndex] = enumerator.Current;
                // mvIndex++;                
            }
            yield break;
            // return tArray;
        }
    }
}
