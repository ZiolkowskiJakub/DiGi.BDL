using System;
using System.Collections.Generic;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the name associated with a specific identifier for a given type from its field dictionary.
        /// </summary>
        /// <param name="type">The type to query.</param>
        /// <param name="id">The identifier of the field whose name is being requested.</param>
        /// <returns>The string representation of the found value, or null if the type is null, the id is empty, or the value is not found.</returns>
        public static string? Name(this Type? type, string? id)
        {
            if (type == null || string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            Dictionary<string, object> dictionary = FieldDictionary(type);
            if (dictionary == null)
            {
                return null;
            }

            if (!dictionary.TryGetValue(id!, out object result))
            {
                return null;
            }

            return result?.ToString();
        }
    }
}
