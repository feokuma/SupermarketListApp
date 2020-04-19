using System;
using System.Collections.Generic;
using SupermarketListApp.Interfaces;
using SupermarketListApp.Views.TitleViews;
using Xamarin.Forms;

namespace SupermarketListApp.Views
{
    public partial class ShoppingListView : ContentPage, IDynamicTitle
    {
        private View _title;
        public ShoppingListView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new ShoppingListTitleView();

            return _title;
        }
    }
}
