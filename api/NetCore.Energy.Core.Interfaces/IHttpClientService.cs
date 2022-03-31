using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Energy.Core.Interfaces
{
    public interface IHttpClientService
    {
        Task<T> Post<T>(string client, string path, object request);

        Task<T> Get<T>(string client, string path);

    }
}
