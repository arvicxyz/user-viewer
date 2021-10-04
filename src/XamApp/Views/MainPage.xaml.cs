﻿using System.ComponentModel;
using System.Threading.Tasks;
using XamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Toolbar.Padding = new Thickness(0, App.StatusBarHeight, 0, 0);
        }

        protected override async void OnAppearing()
        {
            await Task.Run(async () =>
            {
                await ((MainPageViewModel)BindingContext).Init();
            });
        }
    }
}
