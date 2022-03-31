using NetCore.Energy.Core.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Interfaces
{
    public interface IEnergyService
    {
        Task<GetPackageDataResponse> GetWSDataAsync(GetPackageDataRequest request);

        Task<GetDBDataResponse> GetDBDataAsync(GetDBDataRequest request);
    }
}
