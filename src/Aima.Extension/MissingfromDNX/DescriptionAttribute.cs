
#if COREFX

namespace System.ComponentModel {
    /// <summary>
    /// 定义一个表示描述信息的Attribute
    /// </summary>
    public sealed class DescriptionAttribute : Attribute {

        /// <summary>
        /// 初始化 <see cref="DescriptionAttribute"/> 
        /// </summary>
        /// <param name="description">描述信息</param>
        public DescriptionAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// 获取 <see cref="DescriptionAttribute"/> 的描述信息
        /// </summary>
        public string Description {get;private set;}
    }
}

#endif
