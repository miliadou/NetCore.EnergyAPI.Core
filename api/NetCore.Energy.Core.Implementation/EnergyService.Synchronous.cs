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
        private IHttpClientService _httpClientService;
      
        public EnergyService(IHttpClientService httpClientService)
        {          
            _httpClientService = httpClientService;
        }

       public async Task<GetPackageDataResponse> GetWSDataAsync(GetPackageDataRequest request)
       {
            try
            {
                var data = await _httpClientService.Get<List<Package>>("test", "http://localhost:8080/john");
                var result = new List<Package>();
                foreach (var item in data)
                {
                    item.Processed = true;
                }
                return new GetPackageDataResponse
                { 
                    Packages = data
                };
            }
            catch (Exception ex)
            {
                //logger.LogError(ex.Message);
                throw ex;
            }
       }

        public async Task<GetDBDataResponse> GetDBDataAsync(GetDBDataRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
