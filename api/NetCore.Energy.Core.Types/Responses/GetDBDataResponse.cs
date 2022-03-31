using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetCore.Energy.Core.Types
{
    [DataContract]
    public class GetDBDataResponse
    {
        [DataMember(Name = "packages")]
        public List<Package> Packages { get; set; }
    }
}
