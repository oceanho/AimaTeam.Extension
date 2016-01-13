/***************************************************************
*
*   AimaTeam开源项目（版权所有：copyright@aimaTeam.com）       
*   尽管它开源,我们真心希望您可以为我们保留的版权信息，谢谢
----------------------------------------------------------------
*   作   者：Hai he
*   日   期：$time$
*   博   客：https://hehai.aimateam.com
*   说   明：
----------------------------------------------------------------
*
*   官方QQ群号：139849106
*   官方  网站：https://www.aimateam.com
***************************************************************/

using System;


namespace Aima.Extension.Delegates
{
    internal sealed class DelegateStaticConvertMethods<TOut>
    {
        internal static Func<string, TOut> ChangeTypeAsEnumFromString = new Func<string, TOut>((inObj) => { return (TOut)Enum.Parse(typeof(TOut), inObj); });
        internal static Func<string, TOut> ChangeTypeFromString = new Func<string, TOut>((inObj) => { return (TOut)Convert.ChangeType(inObj, typeof(TOut)); });
    }
}
