using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipper.Models;
using System.Windows.Input;



namespace CoinFlipper.ViewModel
{
    public partial class CoinViewModel: ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new RelayCommand(Jogar);
        }

        public void Jogar()
        {
            if (String.IsNullOrEmpty(Escolha)) {
                App.Current.MainPage.DisplayAlert("Cara ou coroa", "Selecione cara ou coroa para prosseguir", "ok");
            } else
            {
                Coin coin = new Coin();
                coin.Jogar();

                Resultado = Escolha == coin.LadoSorteado ? "Parabéns, você acertou" : "Você perdeu";

                Imagem = coin.LadoSorteado == "cara" ? "cara.png" : "coroa.png";
            }

            
        }
    }
}
