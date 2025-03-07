using DiGi.BDL.Classes;
using DiGi.BDL.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        public static async Task<UnitYearlyValues> UnitYearlyValues(string unitId, IEnumerable<Variable> variables, IEnumerable<int> years, int pageSize = 100)
        {
            if(string.IsNullOrWhiteSpace(unitId) || variables == null || variables.Count() == 0 || years == null || years.Count() == 0)
            {
                return null;
            }

            HttpClient httpClient = new HttpClient();

            string url = string.Format("{0}/data/by-unit/{1}?format=json", Constans.Url.EndPoint, unitId);

            foreach(Variable variable in variables)
            {
                url += string.Format("&var-id={0}", (int)variable);
            }

            foreach (int year in years)
            {
                url += string.Format("&year={0}", year);
            }

            List<JsonObject> jsonObjects = await JsonObjects(url, pageSize);
            if(jsonObjects == null)
            {
                return null;
            }

            UnitYearlyValues result = null;

            foreach (JsonObject jsonObject in jsonObjects)
            {
                UnitYearlyValues unitYearlyValues = JsonSerializer.Deserialize<UnitYearlyValues>(jsonObject);
                if(unitYearlyValues == null)
                {
                    continue;
                }

                if(result == null)
                {
                    result = unitYearlyValues;
                }
                else
                {
                    result.results.AddRange(unitYearlyValues.results);
                }
            }

            return result;
        }
    }
}