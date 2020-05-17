using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using SupermarketListApp.ViewModels;
using SupermarketListApp.Views;
using Xamarin.Forms;

namespace SupermarketListApp
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) :base(initializer)
        {
            Device.SetFlags(new[] { "" });
        }

        /// Called when the PrismApplication has completed it's initialization process.
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"NavigationPage/ShoppingListView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ShoppingListView, ShoppingListViewModel>();
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
