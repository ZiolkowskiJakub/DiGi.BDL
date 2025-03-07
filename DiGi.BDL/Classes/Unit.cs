using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    public class Unit : IResultObject
    {
        public string id { get; set; }

        public string name { get; set; }

        public short level { get; set; }

        public bool hasDescription { get; set; }
    }
}
