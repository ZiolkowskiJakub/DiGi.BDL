using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts a dictionary of field names and their corresponding values from the specified type, 
        /// filtering for public static literal fields that are not initialization-only.
        /// </summary>
        /// <param name="type">The type to extract fields from.</param>
        /// <returns>A dictionary containing the names and values of the filtered fields.</returns>
        public static Dictionary<string, object> FieldDictionary(this Type type)
        {
            return type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(x => x.IsLiteral && !x.IsInitOnly).ToDictionary(x => x.Name, fi => fi.GetValue(null));
        }
    }
}
