using SupermarketListApp.Interfaces;
using SupermarketListApp.Views.TitleViews;
using Xamarin.Forms;

namespace SupermarketListApp.Views
{
    public partial class AboutView : ContentPage, IDynamicTitle
    {
        private View _title;
        public AboutView()
        {
            InitializeComponent();
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new AboutTitleView();

            return _title;
        }
    }
}
