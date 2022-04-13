using BreakingBad.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad.ViewModels
{
    public class EpisodesViewModel: BaseViewModel
    {
        private Episodes[] _episodes;

        public EpisodesViewModel()
        {
            Title = "Episodes";
        }
        public Episodes[] Episodes
        {
            get => _episodes;
            set => SetProperty(ref _episodes, value);
        }
        public override void OnNavigatedTo()
        {
            LoadEpisodes();
        }
        public override void OnNavigatedFrom()
        {
        }
        private async Task LoadEpisodes()
        {
            try
            {
                IsBusy = true;

                var response = await ApiClient.GetAsync("https://breakingbadapi.com/api/episodes");

                if (response.IsSuccessStatusCode)
                {
                    Episodes = await response.Content.ReadAsAsync<Episodes[]>();
                }

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
        }
    }


    
}
