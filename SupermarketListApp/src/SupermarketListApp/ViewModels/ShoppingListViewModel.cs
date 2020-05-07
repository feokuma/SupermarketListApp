using System;
using System.Collections.Generic;
using System.Windows.Input;
using MvvmHelpers;
using Prism.Commands;
using SupermarketListApp.Common;
using SupermarketListApp.Models;

namespace SupermarketListApp.ViewModels
{
    public class ShoppingListViewModel
    {
        public ICommand NavigateToSearchItemCommand { get; private set; }
        public ObservableRangeCollection<ProductItem> ListItems { get; set; }
        public ShoppingListViewModel()
        {
            NavigateToSearchItemCommand = new DelegateCommand(NavigateToSearchItem);

            ListItems = new ObservableRangeCollection<ProductItem>();
            ListItems.AddRange(new [] {
                new ProductItem
                {
                    Image = "bread.png",
                    Description = "Pão",
                },
                new ProductItem
                {
                    Image = "cheese.png",
                    Description = "Queijo"
                },
                new ProductItem
                {
                    Image = "milk_bottle.png",
                    Description = "Leite"
                },
                new ProductItem
                {
                    Image =  "ingredients.png",
                    Description = "Feira",
                },
                new ProductItem
                {
                    Image = "throat",
                    Description = "Detergente"
                },
                new ProductItem
                {
                    Image = "wash_machine",
                    Description = "Sabão em pó"
                }
            });
        }

        private void NavigateToSearchItem()
        {
            System.Diagnostics.Debug.WriteLine("O floating button foi acionado");
        }
    }
}
