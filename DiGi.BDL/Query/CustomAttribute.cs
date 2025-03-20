using System;
using System.Reflection;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static TAttribute CustomAttribute<TAttribute>(this Enum @enum) where TAttribute : Attribute
        {
            FieldInfo field = @enum.GetType().GetField(@enum.ToString());

            if (field == null)
            {
                return null;
            }

            return Attribute.GetCustomAttribute(field, typeof(TAttribute)) as TAttribute;
        }
    }
}