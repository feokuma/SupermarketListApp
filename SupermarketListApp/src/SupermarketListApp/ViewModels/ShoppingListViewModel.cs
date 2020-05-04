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
                    Image = FontIcons.Food,
                    Description = "Pão",
                },
                new ProductItem
                {
                    Image = FontIcons.Food,
                    Description = "Queijo"
                },
                new ProductItem
                {
                    Image = FontIcons.Glass,
                    Description = "Leite"
                },
                new ProductItem
                {
                    Image = FontIcons.Glass,
                    Description = "Água com gás",
                },
                new ProductItem
                {
                    Image = FontIcons.Trash,
                    Description = "Detergente"
                },
                new ProductItem
                {
                    Image = FontIcons.Trash,
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
