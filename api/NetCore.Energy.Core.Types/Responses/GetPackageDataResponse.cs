using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetCore.Energy.Core.Types
{
    [DataContract]
    public class GetPackageDataResponse
    {
        [DataMember(Name = "packages")]
        public List<Package> Packages { get; set; }
    }
}
