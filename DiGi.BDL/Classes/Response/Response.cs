using DiGi.BDL.Interfaces;
using System.Collections.Generic;

namespace DiGi.BDL.Classes
{
    public abstract class Response<TResultObject> : IResponseObject where TResultObject : IResultObject
    {
        public int totalRecords { get; set; }

        public List<TResultObject> results { get; set; }

        public Links links { get; set; }
    }
}
