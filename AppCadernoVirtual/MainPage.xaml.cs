using AppCadernoVirtual.Primeiro;
using AppCadernoVirtual.Segundo;
using AppCadernoVirtual.Terceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Void é uma função
        private void BtnPrimeiro_Clicked(object sender, EventArgs e)
        {
            // Quando a função acontecer (quando clicar no botão), vai enviar a tela "InicialPrimeiro" para a navegação
            Navigation.PushAsync(new InicialPrimeiro());
        }

        private void BtnSegundo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialSegundo());
        }

        private void BtnTerceiro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InicialTerceiro());
        }
    }
}
