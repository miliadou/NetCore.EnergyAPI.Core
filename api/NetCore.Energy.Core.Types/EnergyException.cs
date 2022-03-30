using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Energy.Core.Types
{
    public class EnergyException : Exception
    {

        public string Code { get; set; }
        public EnergyException() : base() { }
        public EnergyException(string msg) : base(msg) { }

        public EnergyException(string code, string msg)
            : base(msg)
        {
            this.Code = code;
        }

        public static EnergyException EmptyRequest = new EnergyException("01", "Request is null");
    }
}
