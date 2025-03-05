using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    public class Links : IResponseObject
    {
        public string first { get; set; }

        public string self { get; set; }

        public string next { get; set; }

        public string last { get; set; }
    }
}
