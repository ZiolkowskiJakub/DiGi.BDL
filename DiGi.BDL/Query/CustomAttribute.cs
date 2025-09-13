using System;
using System.Reflection;

namespace DiGi.BDL
{
    public static partial class Query
    {
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