using System;
using System.Runtime.Serialization;

namespace NetCore.Energy.Core.Types
{
    [DataContract]
    public class Package
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "accountNumber")]
        public Guid AccountNumber { get; set; }

        [DataMember(Name = "destination")]
        public string Destination { get; set; }

        [DataMember(Name = "origin")]
        public string Origin { get; set; }

        [DataMember(Name = "weight")]
        public double Weight { get; set; }

        [DataMember(Name = "units")]
        public double Units { get; set; }

        [DataMember(Name = "statusCode")]
        public int StatusCode { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }
    }
}
