using MvvmHelpers.Commands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memegenerator.Services;
using memegenerator.Model;

namespace memegenerator.ViewModel
{
    internal class MemeGeneratorViewModel
    {
        public IMemeGeneratorDataStore<Meme> DataStore => DependencyService.Get<IMemeGeneratorDataStore<Meme>>();
        public ObservableRangeCollection<Meme> memes { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public MemeGeneratorViewModel()
        {
            memes = new ObservableRangeCollection<Meme>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var meme = await DataStore.GetMemeListAsync();

            memes.AddRange(meme);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}
