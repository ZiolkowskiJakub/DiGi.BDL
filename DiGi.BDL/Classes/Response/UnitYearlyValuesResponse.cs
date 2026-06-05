namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a response containing yearly values for a specific unit.
    /// </summary>
    public class UnitYearlyValuesResponse : Response<YearlyValues>
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
        /// Gets or sets the identifier of the aggregate associated with these values.
        /// </summary>
        public int aggregateId { get; set; }
    }
}
