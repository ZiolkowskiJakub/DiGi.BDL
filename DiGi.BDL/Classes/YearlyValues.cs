using DiGi.BDL.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a set of yearly values associated with a specific measurement unit and identifier.
    /// </summary>
    public class YearlyValues : IResultObject
    {
        /// <summary>
        /// Gets or sets the unique identifier for the yearly values record.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the measurement unit used for these values.
        /// </summary>
        public int measureUnitId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the yearly values were last updated.
        /// </summary>
        public DateTime lastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the list of individual yearly value entries.
        /// </summary>
        public List<YearlyValue>? values { get; set; }
    }
}
