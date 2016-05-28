
#if COREFX

namespace System.ComponentModel {
    public sealed class DescriptionAttribute : Attribute {
        public DescriptionAttribute(string description)
        {
            Description = description;
        }
        public string Description {get;private set;}
    }
}
#endif
