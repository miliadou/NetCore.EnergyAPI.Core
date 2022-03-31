using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Implementation
{
    public static class HttpExtensions
    {
        public static StringContent GetHttpContent(this object newExtReq)
        {
            string stringBody = JsonConvert.SerializeObject(newExtReq);
            var content = new StringContent(stringBody, Encoding.UTF8, "application/json");
            return content;        
        }

        public static void PrepareHeaders(this HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("energyApi");
            client.DefaultRequestHeaders.Connection.ParseAdd("keep-alive");
            //client.DefaultRequestHeaders.Host = client.BaseAddress.GetLeftPart(UriPartial.Authority).Split("//")[1];
        }

        public static async Task<T> ExecPost<T>(this HttpClient client, string path, StringContent httpContent )
        {
            try
            {
                T response;
                using (var resp = await client.PostAsync(path, httpContent))
                {
                    string data = await resp.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<T>(data);
                }
                return response;
            }
            catch (Exception ex)
            {
                //logger.LogError(ex.Message);
                throw ex;
            }
        }

        public static async Task<T> ExecGet<T>(this HttpClient client, string path)
        {
            try
            {
                T response;
                using (var resp = await client.GetAsync(path))
                {
                    string data = await resp.EnsureSuccessStatusCode().Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<T>(data);
                }
                return response;
            }
            catch (Exception ex)
            {
                //logger.LogError(ex.Message);
                throw ex;
            }
        }
    }
}
