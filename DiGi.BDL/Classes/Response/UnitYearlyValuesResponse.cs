using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    public class UnitYearlyValuesResponse : Response<YearlyValues>
    {
        public string unitId { get; set; }

        public string unitName { get; set; }

        public int aggregateId { get; set; }
    }
}
