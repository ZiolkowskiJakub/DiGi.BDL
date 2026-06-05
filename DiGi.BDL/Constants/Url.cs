namespace DiGi.BDL.Constants
{
    /// <summary>
    /// Provides constant URL paths and endpoints for the BDL API.
    /// </summary>
    public static class Url
    {
        /// <summary>
        /// The base URL endpoint for the BDL API v1.
        /// </summary>
        public const string EndPoint = "https://bdl.stat.gov.pl/api/v1";

        /// <summary>
        /// Contains identifier constants used in API requests.
        /// </summary>
        public static class Id
        {
            /// <summary>
            /// Constant representing the units resource identifier.
            /// </summary>
            public const string Units = "units";

            /// <summary>
            /// Constant representing the variables resource identifier.
            /// </summary>
            public const string Variables = "variables";
        }
    }
}
