using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the PKOB custom attribute associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to evaluate.</param>
        /// <returns>The PKOB attribute if found; otherwise, null.</returns>
        public static PKOB? PKOB(this Enum? @enum)
        {
            return CustomAttribute<PKOB>(@enum);
        }
    }
}
