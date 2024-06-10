using CoinFlipper.ViewModel;

namespace CoinFlipper.View
{
    public partial class CoinView1 : ContentPage
    {
        public CoinView1()
        {
            InitializeComponent();
            BindingContext = new CoinViewModel();
        }
    }
}
