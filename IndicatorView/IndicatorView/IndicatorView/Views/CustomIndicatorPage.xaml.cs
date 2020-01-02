using IndicatorView.ViewModels;
using Xamarin.Forms.Xaml;

namespace IndicatorView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomIndicatorPage
    {
        public CustomIndicatorPage()
        {
            InitializeComponent();
            BindingContext = new AnimalPageViewModel();
        }
    }
}