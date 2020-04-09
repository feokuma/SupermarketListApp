using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace SupermarketListApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public string MainLabel { get; private set; }

        public MainPageViewModel()
        {
            MainLabel = "Hello World";
        }
    }
}
