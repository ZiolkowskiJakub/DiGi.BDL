using DiGi.BDL.Classes;
using System;

namespace DiGi.BDL
{
    public static partial class Query
    {
        public static Category Category(this Enum @enum)
        {
            return CustomAttribute<Category>(@enum);
        }
    }
}