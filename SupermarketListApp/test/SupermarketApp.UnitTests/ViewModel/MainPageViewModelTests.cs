using System;
using NUnit.Framework;
using SupermarketListApp.ViewModels;

namespace SupermarketApp.UnitTests.ViewModel
{
    public class MainPageViewModelTests
    {
        [Test]
        public void Test()
        {
            var viewModel = new MainPageViewModel();

            Assert.AreEqual("Hello World!", viewModel.MainLabel);
        }
    }
}
