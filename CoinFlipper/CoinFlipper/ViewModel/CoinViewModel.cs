using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipper.Models;


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


        public void Jogar()
        {
            Coin coin = new Coin();
            coin.Jogar();

            //Restultado = Escolha == LadoSorteado ? "Parabéns, você acertou" : "Você perdeu"
            if(Escolha == coin.LadoSorteado)
            {
                Resultado = "Você ganhou";
            } else
            {
                Resultado = "Você perdeu";
            }
        }
    }
}
