using IndicatorView.ViewModels;
using Xamarin.Forms.Xaml;

namespace IndicatorView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalPage
    {
        public AnimalPage()
        {
            InitializeComponent();
            BindingContext = new AnimalPageViewModel();
        }
    }
}