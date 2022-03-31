using NetCore.Energy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Implementation
{
    public class HttpClientService: IHttpClientService
    {
        private HttpClient _httpClient;
        private readonly IHttpClientFactory _httpClientFactory;
        private static readonly HttpClient client = new HttpClient();

        public HttpClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = new HttpClient();
        }

        public async Task<T> Post<T>(string client, string path, object request)
        {
            _httpClient = _httpClientFactory.CreateClient(client);
            var httpContent = request.GetHttpContent();
            _httpClient.PrepareHeaders();

            return await _httpClient.ExecPost<T>(path, httpContent);
        }

        public async Task<T> Get<T>(string client, string path)
        {
            _httpClient = _httpClientFactory.CreateClient(client);
            _httpClient.PrepareHeaders();

            return await _httpClient.ExecGet<T>(path);
        }
    }
}
