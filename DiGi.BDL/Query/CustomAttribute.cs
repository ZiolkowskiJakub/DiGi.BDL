using System;
using System.Reflection;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the specified attribute from the field of the provided enumeration value.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="enum">The enumeration value to inspect.</param>
        /// <returns>The requested attribute if found; otherwise, null.</returns>
        public static TAttribute? CustomAttribute<TAttribute>(this Enum? @enum) where TAttribute : Attribute
        {
            FieldInfo? fieldInfo = @enum?.GetType().GetField(@enum.ToString());
            if (fieldInfo == null)
            {
                return null;
            }

            return Attribute.GetCustomAttribute(fieldInfo, typeof(TAttribute)) as TAttribute;
        }
    }
}
