﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketListApp.Interfaces;
using Xamarin.Forms;

namespace SupermarketListApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            Children.Add(new ShoppingListView());
            if (Device.RuntimePlatform == Device.iOS)
                Children.Add(new SearchItemView());
            Children.Add(new AboutView());
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (CurrentPage is IDynamicTitle page)
            {
                NavigationPage.SetTitleView(this, page.GetTitle());
                NavigationPage.SetHasNavigationBar(this, true);
                return;
            }

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
