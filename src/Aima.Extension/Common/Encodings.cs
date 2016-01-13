
using System.Text;
namespace Aima.Extension.Common
{
    internal class Encodings
    {
#if COREFX
        internal static readonly Encoding _defaultEncoding = Encoding.GetEncoding("utf-8");
#else
        internal static readonly Encoding _defaultEncoding = Encoding.GetEncoding(0);
#endif
        internal static readonly Encoding _utf8 = Encoding.UTF8;
        internal static readonly Encoding _unicode = Encoding.Unicode;
        internal static readonly Encoding _ascii = Encoding.GetEncoding("ascii");
        internal static readonly Encoding _gbk = Encoding.GetEncoding("gbk");
        internal static readonly Encoding _gb2312 = Encoding.GetEncoding("gb2312");
    }
}
