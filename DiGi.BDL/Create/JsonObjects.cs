using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        public static async Task<List<JsonObject>?> JsonObjects(string? url, int pageSize = 100)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            HttpClient httpClient = new();

            List<JsonObject>? result = [];

            try
            {
                string? url_Temp = string.Format("{0}&page-size={1}", url, pageSize);

                do
                {
                    using HttpRequestMessage request = new(HttpMethod.Get, url_Temp);
                    //request.Headers.Add("X-ClientId", "");

                    using HttpResponseMessage response = await httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        JsonObject? jsonObject = JsonSerializer.Deserialize<JsonObject>(json);

                        if (jsonObject != null)
                        {
                            result.Add(jsonObject);

                            url_Temp = null;

                            if (jsonObject.TryGetPropertyValue("links", out JsonNode? jsonNode) && jsonNode is JsonObject jsonObject_Temp)
                            {
                                if (jsonObject_Temp.TryGetPropertyValue("next", out jsonNode))
                                {
                                    url_Temp = jsonNode?.AsValue().GetValue<string>();
                                }
                            }

                            if (!string.IsNullOrWhiteSpace(url_Temp))
                            {
                                Thread.Sleep(100);
                            }
                        }
                    }
                }
                while (!string.IsNullOrWhiteSpace(url_Temp));
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}