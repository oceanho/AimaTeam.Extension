
// Aima.Extension.MissingfromDNX
#if COREFX || DNX
using System;

namespace Aima.Extension.MissingfromDNX
{
    //
    // 摘要:
    //     指定属性或事件的说明。
    [AttributeUsage(AttributeTargets.All)]
    public class DescriptionAttribute : Attribute
    {
        private string _description;
        public static readonly DescriptionAttribute Default = default(DescriptionAttribute);

        public DescriptionAttribute()
            : this(string.Empty)
        { }
        public DescriptionAttribute(string description)
        {
            _description = description;
        }
        public virtual string Description
        {
            get
            {
                return _description;
            }
        }
        protected string DescriptionValue { get; set; }

        public override bool Equals(object obj)
        {
            return obj.Equals(this);
        }
        public override int GetHashCode()
        {
            return string.IsNullOrEmpty(Description)?"".GetHashCode():Description.GetHashCode();
        }
    }
}
#endif
