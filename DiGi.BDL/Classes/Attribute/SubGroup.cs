using DiGi.BDL.Constans;
using System;

namespace DiGi.BDL.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class SubGroup : Attribute
    {
        public string Id { get;}

        public string Name { get;}

        public SubGroup(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public SubGroup(string id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.SubGroup), id);
        }

    }
}
