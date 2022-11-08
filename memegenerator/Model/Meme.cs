using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memegenerator.Model
{
    public class Meme
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public Meme(string id, string name, string url)
        {
            Id = id;
            Name = name;
            Url = url;
        }
    }



    public class APIResponse
    {
        public Boolean Success { get; set; }
        public Data Data { get; set; }
        

        public APIResponse(Boolean success, Data data)
        {
            Success = success;
            Data = data;
           
        }
    }

    public class Data
    {
        public List<Meme> Memes { get; set; }

        public Data(List<Meme> memes)
        {
            Memes = memes;

        }

    }
}



