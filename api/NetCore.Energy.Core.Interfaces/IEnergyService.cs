using NetCore.Energy.Core.Types;
using System;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Interfaces
{
    public interface IEnergyService
    {
        Task<Package> GetPackageData(GetPackageDataRequest request);
    }
}
