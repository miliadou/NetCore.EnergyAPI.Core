using NetCore.Energy.Core.Interfaces;
using NetCore.Energy.Core.Types;
using System;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Implementation
{
    public partial class EnergyService : IEnergyService
    {

       public async Task<Package> GetPackageData(GetPackageDataRequest request)
       {
            if (request.Id == null) throw EnergyException.EmptyRequest;
            return new Package
            {
                Destination = "Package is not implemented"
            };
       }
    }
}
