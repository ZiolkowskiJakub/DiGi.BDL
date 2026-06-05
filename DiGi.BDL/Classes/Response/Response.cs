using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents a generic base response object that encapsulates result data and metadata.
    /// </summary>
    /// <typeparam name="TResultObject">The type of the result object, which must implement <see cref="IResultObject"/>.</typeparam>
    public abstract class Response<TResultObject> : IResponseObject where TResultObject : IResultObject
    {
        /// <summary>
        /// Gets or sets the total number of records available.
        /// </summary>
        public int totalRecords { get; set; }

        /// <summary>
        /// Gets or sets the list of result objects contained in the response.
        /// </summary>
        public List<TResultObject>? results { get; set; }

        /// <summary>
        /// Gets or sets the navigation links associated with the response.
        /// </summary>
        public Links? links { get; set; }
    }
}
