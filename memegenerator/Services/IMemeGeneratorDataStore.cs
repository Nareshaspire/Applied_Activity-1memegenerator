using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memegenerator.Services
{
       public interface IMemeGeneratorDataStore<Meme>
    {
       Task<IEnumerable<Meme>> GetMemeListAsync();
    }
}
