﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetCore.Energy.Core.Types
{
    [DataContract]
    public class GetDBDataRequest
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
