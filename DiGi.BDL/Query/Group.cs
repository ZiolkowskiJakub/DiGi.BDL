using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static Group Group(this Enum @enum)
        {
            return CustomAttribute<Group>(@enum);
        }
    }
}