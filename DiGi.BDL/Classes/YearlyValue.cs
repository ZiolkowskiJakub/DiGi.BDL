using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    public class YearlyValue : IBDLObject
    {
        public string year { get; set; }

        public double val { get; set; }

        public int attrId { get; set; }
    }
}
