namespace CoinFlipper
{
    public partial class MainPage : ContentPage
    {
        int selectMoeda;
        String stringMoeda = String.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void moedaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringMoeda = (String)moedaSelect.SelectedItem;
            selectMoeda = moedaSelect.SelectedIndex;
        }

        private void moedaBtn_Clicked(object sender, EventArgs e)
        {
            Random rnd = new();
            int rand = rnd.Next(2);

            if (stringMoeda == string.Empty)
            {
                DisplayAlert("Cara ou coroa", "Selecione cara ou coroa para prosseguir", "ok");
            } else
            {
                if ( rand == selectMoeda)
                {
                    moedaOut.Text = "Acertou! " + stringMoeda;
                    imgOut.Source = stringMoeda + ".png";
                }
                else
                {
                    if (selectMoeda == 0)
                    {
                        imgOut.Source = "coroa.png";
                        moedaOut.Text = "Errou! Coroa";
                    } else
                    {
                        imgOut.Source = "cara.png";
                        moedaOut.Text = "Errou! Cara";
                    }
                }

            }

        }
    }
}
