using BreakingBad.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BreakingBad.Views;

namespace BreakingBad.ViewModels
{
    public  class CharactersViewModel : BaseViewModel
    {
        private Characters[] _characters;


        public CharactersViewModel()
        {
            Title = "Characters";
        }
        
        public Characters[] Characters
        {
            get => _characters;
            set => SetProperty(ref _characters, value);
        }

        public override void OnNavigatedTo()
        {
            LoadCharacters();
        }

        

        public override void OnNavigatedFrom()
        {
        }
        private async Task LoadCharacters()
        {
            try
            {
                IsBusy = true;

                var response = await ApiClient.GetAsync("https://breakingbadapi.com/api/characters");

                if (response.IsSuccessStatusCode)
                {
                    Characters = await response.Content.ReadAsAsync<Characters[]>();
                    
                }

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
