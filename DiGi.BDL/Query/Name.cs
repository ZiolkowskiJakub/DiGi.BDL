using System;
using System.Collections.Generic;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static string Name(this Type type, string id)
        {
            if(type == null || string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            Dictionary<string, object> dictionary = FieldDictionary(type);
            if(dictionary == null)
            {
                return null;
            }

            if(!dictionary.TryGetValue(id, out object result))
            {
                return null;
            }


            return result?.ToString();
        }
    }
}