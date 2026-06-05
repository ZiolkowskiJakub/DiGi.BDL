using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a data model containing yearly values associated with a specific unit.
    /// </summary>
    public class UnitYearlyValues : IBDLObject
    {
        /// <summary>
        /// Gets or sets the unique identifier of the unit.
        /// </summary>
        public string? unitId { get; set; }

        /// <summary>
        /// Gets or sets the name of the unit.
        /// </summary>
        public string? unitName { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the aggregate group.
        /// </summary>
        public int aggregateId { get; set; }

        /// <summary>
        /// Gets or sets the list of yearly value results associated with the unit.
        /// </summary>
        public List<YearlyValues>? results { get; set; }
    }
}
