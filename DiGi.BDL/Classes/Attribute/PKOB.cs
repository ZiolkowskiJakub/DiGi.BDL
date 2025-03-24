using System;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class PKOB : Attribute
    {
        public HashSet<short> Ids { get;}

        public PKOB(short id)
        {
            Ids = new HashSet<short> { id };
        }

        public PKOB(IEnumerable<short> ids)
        {
            if(ids != null)
            {
                Ids = new HashSet<short>(ids);
            }
        }

        public PKOB(short[] ids)
        {
            if (ids != null)
            {
                Ids = new HashSet<short>(ids);
            }
        }

        public PKOB(short from, short to)
        {
            Ids = new HashSet<short>();
            for(short i= from; i <= to; i++)
            {
                Ids.Add(i);
            }
        }
    }
}
