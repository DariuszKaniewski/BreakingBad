using BreakingBad.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad.ViewModels
{
    public class DeathsViewModel : BaseViewModel
    {
        private Deaths[] _deaths;
        public DeathsViewModel()
        {
            Title = "Deaths";
        }
        public Deaths[] Deaths
        {
            get => _deaths;
            set=>SetProperty(ref _deaths, value);
        }
        public override void OnNavigatedTo()
        {
            LoadDeaths();
        }
        public override void OnNavigatedFrom()
        {
        }

        private async Task LoadDeaths()
        {
            try
            {
                IsBusy = true;

                var response = await ApiClient.GetAsync("https://breakingbadapi.com/api/deaths");

                if (response.IsSuccessStatusCode)
                {
                    Deaths = await response.Content.ReadAsAsync<Deaths[]>();
                }

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
