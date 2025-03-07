using DiGi.BDL.Classes;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        public static async Task<List<Unit>> Units(int pageSize = 100)
        {
            HttpClient httpClient = new HttpClient();

            string url = string.Format("{0}/{1}?format=json", Constans.Url.EndPoint, Constans.Url.Id.Units);

            List<JsonObject> jsonObjects = await JsonObjects(url, pageSize);
            if(jsonObjects == null)
            {
                return null;
            }

            List<Unit> result = new List<Unit>();
            foreach(JsonObject jsonObject in jsonObjects)
            {
                UnitsResponse unitsResponse = JsonSerializer.Deserialize<UnitsResponse>(jsonObject);
                if(unitsResponse == null)
                {
                    continue;
                }

                result.AddRange(unitsResponse.results);
            }

            return result;
        }
    }
}