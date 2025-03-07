using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    public class UnitYearlyValues : IBDLObject
    {
        public string unitId { get; set; }

        public string unitName { get; set; }

        public int aggregateId { get; set; }

        public List<YearlyValues> results { get; set; }
    }
}
