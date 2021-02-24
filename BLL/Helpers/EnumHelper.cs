using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace BLL.Helpers
{
    public class EnumHelper<T> where T : struct, IConvertible
    {
        public static IEnumerable<string> GetEnumDisplayNameList<TValue>()
            where TValue : struct, IConvertible
        {
            var enumDisplayNames = new List<string>();
            var displayNames = typeof(TValue).GetCustomAttributes<DisplayAttribute>().Select(da => da.Name);

            foreach (var name in displayNames)
            {
                enumDisplayNames.Add(name);
            }

            return enumDisplayNames;
        }
    }
}
