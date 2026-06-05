using DiGi.BDL.Interfaces;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a collection of navigation links typically used for pagination in response objects.
    /// </summary>
    public class Links : IResponseObject
    {
        /// <summary>
        /// Gets or sets the URI for the first page of results.
        /// </summary>
        public string? first { get; set; }

        /// <summary>
        /// Gets or sets the URI for the current page of results.
        /// </summary>
        public string? self { get; set; }

        /// <summary>
        /// Gets or sets the URI for the next page of results.
        /// </summary>
        public string? next { get; set; }

        /// <summary>
        /// Gets or sets the URI for the last page of results.
        /// </summary>
        public string? last { get; set; }
    }
}
