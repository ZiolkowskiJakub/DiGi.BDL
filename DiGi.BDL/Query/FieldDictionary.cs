using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static Dictionary<string, object> FieldDictionary(this Type type)
        {
            return type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(x => x.IsLiteral && !x.IsInitOnly).ToDictionary(x => x.Name, fi => fi.GetValue(null));
        }
    }
}