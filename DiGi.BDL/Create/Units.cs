using DiGi.BDL.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DiGi.BDL
{
    public static partial class Create
    {
        public static async Task<List<Unit>> Units(int pageSize = 100)
        {
            HttpClient httpClient = new HttpClient();

            string url = string.Format("{0}/{1}?format=json&page-size={2}", Constans.Url.EndPoint, Constans.Url.Id.Units, pageSize);

            List<Unit> result = new List<Unit>();

            try
            {
                JsonObject jsonObject;

                do
                {
                    jsonObject = null;

                    if(!string.IsNullOrWhiteSpace(url))
                    {
                        string json = await httpClient.GetStringAsync(url);
                        if (!string.IsNullOrWhiteSpace(json))
                        {
                            url = null;

                            jsonObject = JsonNode.Parse(json)?.AsObject();
                            if (jsonObject != null)
                            {
                                Response<Unit> response = Response<Unit>(jsonObject);
                                if(response != null)
                                {
                                    if(url != response.links.last)
                                    {
                                        url = response.links.next;
                                    }

                                    if (response.results != null)
                                    {
                                        result.AddRange(response.results);
                                    }
                                }
                            }
                        }
                    }
                }
                while (jsonObject != null);

                
            }
            catch (Exception ex)
            {
                return null;
            }


            return result;
        }
    }
}