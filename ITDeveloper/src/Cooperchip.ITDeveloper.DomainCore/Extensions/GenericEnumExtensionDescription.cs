using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.DomainCore.Extentions
{
    public static class GenericEnumExtensionDescription
    {
        public static string ObterDescricao(this Enum _enum)
        {
            Type generEnumType = _enum.GetType();
            MemberInfo[] memberInfo = generEnumType.GetMember(_enum.ToString());

            if(memberInfo.Length <= 0)
            {
                return _enum.ToString();
            }

            var attribs = memberInfo[0].
                GetCustomAttributes(typeof(DescriptionAttribute), false);


            return attribs.Any() ? ((DescriptionAttribute)attribs.ElementAt(0)).Description : _enum.ToString();
        }
    }
}
