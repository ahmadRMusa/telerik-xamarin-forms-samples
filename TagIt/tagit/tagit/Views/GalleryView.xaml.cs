﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tagit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryView : ContentView
    {
        public GalleryView()
        {
            InitializeComponent();

            var viewModel = App.ViewModel.Gallery;
            viewModel.Initialize();
            BindingContext = viewModel;
        }
    }
}