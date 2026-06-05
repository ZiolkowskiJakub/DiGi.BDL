using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the Group attribute associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to query for the Group attribute.</param>
        /// <returns>The Group attribute if found; otherwise, null.</returns>
        public static Group? Group(this Enum? @enum)
        {
            return CustomAttribute<Group>(@enum);
        }
    }
}
