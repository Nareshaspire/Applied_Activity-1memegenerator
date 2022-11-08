using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memegenerator.Services
{
    public class WebClientService : IWebClientService
    {
        public WebClientService()
        {
        }

        public async Task<string> GetAsync(string uri)
        {
            try
            {
                HttpClient client;
                client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uri);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public Task<string> PostAsync(string url, string body, string type)
        {
            throw new NotImplementedException();
        }

        public Task<string> PutAsync(string url, string body, string type)
        {
            throw new NotImplementedException();
        }
    }
}

