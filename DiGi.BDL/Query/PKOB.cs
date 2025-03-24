using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static PKOB PKOB(this Enum @enum)
        {
            return CustomAttribute<PKOB>(@enum);
        }
    }
}