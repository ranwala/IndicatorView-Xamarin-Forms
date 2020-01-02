using System;
using Xamarin.Forms.Xaml;

namespace IndicatorView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void DefaultIndicator_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnimalPage(), true);
        }

        private async void CustomIndicatorButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomIndicatorPage(), true);
        }
    }
}