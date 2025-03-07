using DiGi.BDL.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    public class YearlyValues : IResultObject
    {
        public int id { get; set; }

        public int measureUnitId { get; set; }

        public DateTime lastUpdate { get; set; }

        public List<YearlyValue> values { get; set; }
    }
}
