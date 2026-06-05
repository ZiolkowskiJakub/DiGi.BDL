namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Represents the response object for unit-related queries, including pagination details.
    /// </summary>
    public class UnitsResponse : Response<Unit>
    {
        /// <summary>
        /// Gets or sets the current page number of the results.
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// Gets or sets the number of items per page.
        /// </summary>
        public int pageSize { get; set; }
    }
}
