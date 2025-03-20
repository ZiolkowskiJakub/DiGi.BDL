using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static SubGroup SubGroup(this Enum @enum)
        {
            return CustomAttribute<SubGroup>(@enum);
        }
    }
}