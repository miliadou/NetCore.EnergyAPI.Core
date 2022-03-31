using NetCore.Energy.Core.Interfaces;
using NetCore.Energy.Core.Types;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Implementation
{
    public partial class EnergyService : IEnergyService
    {
        private HttpClient _httpClient;
        private IHttpClientService _httpClientService;

        private readonly IHttpClientFactory _httpClientFactory;
        public EnergyService(IHttpClientFactory httpClientFactory, HttpClient httpClient, IHttpClientService httpClientService)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClient;
            _httpClientService = httpClientService;
        }

       public async Task<List<Package>> GetPackageData(GetPackageDataRequest request)
       {
            try
            {
                var data = await _httpClientService.Get<List<Package>>("test", "http://localhost:8080/john");
                var result = new List<Package>();
                foreach (var item in data)
                {
                    item.Processed = true;
                }
                return data;
            }
            catch (Exception ex)
            {
                //logger.LogError(ex.Message);
                throw ex;
            }
       }
    }
}
