using BreakingBad.Models;
using BreakingBad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BreakingBad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class CharactersPage : ContentPage
    {

        private string LabelText = "SampleName";
        
    
        public CharactersPage()
        {
            InitializeComponent();
            BindingContext = new CharactersViewModel();
        }
       
        
        private void TapGestureRecognizer_Characters(object sender, EventArgs e)
        {

            Task DisplayInfo = DisplayAlert("Dane: ", $"{LabelText}", "OK");
            
        }
    }
}
