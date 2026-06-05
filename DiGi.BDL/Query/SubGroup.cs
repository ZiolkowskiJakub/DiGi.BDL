using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the SubGroup attribute associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to evaluate.</param>
        /// <returns>The <see cref="SubGroup"/> attribute if it exists; otherwise, null.</returns>
        public static SubGroup? SubGroup(this Enum? @enum)
        {
            return CustomAttribute<SubGroup>(@enum);
        }
    }
}
