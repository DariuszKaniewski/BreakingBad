﻿using BreakingBad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BreakingBad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeathsPage : ContentPage
    {
        public DeathsPage()
        {
            InitializeComponent();
            BindingContext = new DeathsViewModel();
        }
    }
}