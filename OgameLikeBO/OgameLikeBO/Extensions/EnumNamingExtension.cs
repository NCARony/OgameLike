using OgameLikeBO.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO.Extensions
{
    public static class EnumNamingExtension
    {
        public static string GetName(this Enum val)
        {
            EnumNamingAttribute[] attributes = (EnumNamingAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(EnumNamingAttribute), false);
            return attributes.Length > 0 ? attributes[0].Name : string.Empty;
        }
    }
}
