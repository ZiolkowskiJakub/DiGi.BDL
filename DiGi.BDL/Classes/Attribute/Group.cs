using DiGi.BDL.Constans;
using System;

namespace DiGi.BDL.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class Group : Attribute
    {
        public string Id { get;}

        public string Name { get;}

        public Group(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Group(string id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.Group), id);
        }

    }
}
