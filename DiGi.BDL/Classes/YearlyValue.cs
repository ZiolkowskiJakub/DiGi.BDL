using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a data object containing a value associated with a specific year and attribute identifier.
    /// </summary>
    public class YearlyValue : IBDLObject
    {
        /// <summary>
        /// Gets or sets the year string associated with the value.
        /// </summary>
        public string? year { get; set; }

        /// <summary>
        /// Gets or sets the numeric value for the specified year and attribute.
        /// </summary>
        public double val { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the attribute associated with this value.
        /// </summary>
        public int attrId { get; set; }
    }
}
