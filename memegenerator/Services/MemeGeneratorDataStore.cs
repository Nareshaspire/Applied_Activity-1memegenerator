using memegenerator.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memegenerator.Services
{
    public class MemeGeneratorDataStore : IMemeGeneratorDataStore<Meme>
    {

        //   url https://api.imgflip.com/get_memes

        private static string API => "https://api.imgflip.com/get_memes";

        async Task<IEnumerable<Meme>> IMemeGeneratorDataStore<Meme>.GetMemeListAsync()
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync(API);

            var memes = MemeBuilder(json);

            return memes;
        }

        private List<Meme> MemeBuilder(string json)
        {

            APIResponse response = JsonConvert.DeserializeObject<APIResponse>(json);
            return response.Data.Memes;
        }

    }
}