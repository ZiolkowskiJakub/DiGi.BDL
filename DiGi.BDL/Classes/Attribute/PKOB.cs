using System;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class PKOB : Attribute
    {
        public HashSet<short>? Ids { get;}

        public PKOB(short id)
        {
            Ids = [id];
        }

        public PKOB(IEnumerable<short>? ids)
        {
            if(ids != null)
            {
                Ids = [.. ids];
            }
        }

        public PKOB(short[]? ids)
        {
            if (ids != null)
            {
                Ids = [.. ids];
            }
        }

        public PKOB(short from, short to)
        {
            Ids = [];
            for(short i= from; i <= to; i++)
            {
                Ids.Add(i);
            }
        }
    }
}
