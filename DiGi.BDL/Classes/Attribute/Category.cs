using DiGi.BDL.Constans;
using System;

namespace DiGi.BDL.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class Category : Attribute
    {
        public string Id { get;}

        public string Name { get;}

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(string id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.Category), id);
        }
    }
}
