using DiGi.BDL.Classes;
using DiGi.BDL.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.BDL
{
    public static partial class Create
    {
        public static Response<T> Response<T>(JsonObject jsonObject) where T : IResultObject
        {
            if(jsonObject == null)
            {
                return null;
            }

            return null;
        }
    }
}
