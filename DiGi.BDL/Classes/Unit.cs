using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a unit entity that implements the IResultObject interface.
    /// </summary>
    public class Unit : IResultObject
    {
        /// <summary>
        /// Gets or sets the unique identifier of the unit.
        /// </summary>
        public string? id { get; set; }

        /// <summary>
        /// Gets or sets the name of the unit.
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// Gets or sets the level associated with the unit.
        /// </summary>
        public short level { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the unit has an associated description.
        /// </summary>
        public bool hasDescription { get; set; }
    }
}
