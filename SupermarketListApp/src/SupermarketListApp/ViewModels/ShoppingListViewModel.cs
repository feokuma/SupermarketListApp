using System;
using System.Windows.Input;
using Prism.Commands;

namespace SupermarketListApp.ViewModels
{
    public class ShoppingListViewModel
    {
        public ICommand NavigateToSearchItemCommand { get; private set; } 
        public ShoppingListViewModel()
        {
            NavigateToSearchItemCommand = new DelegateCommand(NavigateToSearchItem);
        }

        private void NavigateToSearchItem()
        {
            System.Diagnostics.Debug.WriteLine("O floating button foi acionado");
        }
    }
}
