﻿using MobileClient.ViewModels;

namespace Vahti.Mobile.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptionsSortingPage : ContentPage
    {
        public OptionsSortingPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.OptionsSorting;
        }
    }
}