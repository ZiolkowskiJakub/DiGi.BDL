using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the Category attribute associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to query for the Category attribute.</param>
        /// <returns>The <see cref="Category"/> attribute if found; otherwise, null.</returns>
        public static Category? Category(this Enum? @enum)
        {
            return CustomAttribute<Category>(@enum);
        }
    }
}
