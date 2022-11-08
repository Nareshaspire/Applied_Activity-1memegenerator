using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memegenerator.Services
{
    public interface IWebClientService
    {

        Task<string> GetAsync(string url);

        Task<string> PostAsync(string url, string body, string type);

        Task<string> PutAsync(string url, string body, string type);
    }
}
