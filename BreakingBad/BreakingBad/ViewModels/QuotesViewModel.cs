using BreakingBad.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad.ViewModels
{
    public class QuotesViewModel : BaseViewModel
    {
        private Quotes[] _quotes;
        public Quotes[] Quotes
        {
            get => _quotes;
            set => SetProperty(ref _quotes, value);
        }
        public QuotesViewModel()
        {
            Title = "Quotes;";
        }
        public override void OnNavigatedTo()
        {
            LoadQuotes();
        }
        public override void OnNavigatedFrom()
        {
        }

        private async Task LoadQuotes()
        {
            try
            {
                IsBusy = true;

                var response = await ApiClient.GetAsync("https://breakingbadapi.com/api/quotes");

                if (response.IsSuccessStatusCode)
                {
                    Quotes = await response.Content.ReadAsAsync<Quotes[]>();
                }

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
