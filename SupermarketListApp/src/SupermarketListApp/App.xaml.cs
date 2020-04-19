﻿using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Navigation;
using SupermarketListApp.ViewModels;
using SupermarketListApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SupermarketListApp
{
    public partial class App : PrismApplication
    {
        public App() : base(null) { }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(nameof(MainPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ShoppingListView, ShoppingListViewModel>();
            containerRegistry.RegisterForNavigation<AboutView, AboutViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}