using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    public class Response<TResultObject> : IResponseObject where TResultObject : IResultObject
    {
        public int totalRecords { get; set; }

        public int page { get; set; }

        public int pageSize { get; set; }

        public Links links { get; set; }

        public List<TResultObject> results { get; set; }
    }
}
