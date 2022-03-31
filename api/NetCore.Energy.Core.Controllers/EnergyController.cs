using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore.Energy.Core.Interfaces;
using NetCore.Energy.Core.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public partial class EnergyController : ControllerBase
    {
        private readonly IEnergyService _energyService;

        public EnergyController(ILogger<EnergyController> logger,
            IEnergyService energyService)
        {
            _energyService = energyService;
        }       

        [HttpPost("firstRoute")]
        public async Task<List<Package>> GetPackageData(GetPackageDataRequest request)
        {           
            return await _energyService.GetPackageData(request);           
        }
    }
}
