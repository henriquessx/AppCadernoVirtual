using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Primeiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialPrimeiro : ContentPage
    {
        public InicialPrimeiro()
        {
            InitializeComponent();
        }

        private void BtnPortugues_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesPrimeiro());
        }

        private void BtnIngles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesPrimerio());
        }

        private void BtnGeografia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaPrimeiro());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaPrimeiro());
        }

        private void BtnFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaPrimeiro());
        }

        private void BtnQuimica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaPrimeiro());
        }

        private void BtnBiologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaPrimeiro());
        }

        private void BtnFilosofia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaPrimeiro());
        }

        private void BtnEducacaoFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaPrimeiro());
        }

        private void BtnArtes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArtesPrimeiro());
        }

        private void BtnProgramacaoWeb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgramacaoWebPrimeiro());
        }

        private void BtnAnalise_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnalisePrimeiro());
        }

        private void BtnDesignDigital_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesingPrimeiro());
        }

        private void BtnFundamentosInformatica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FundamentosInformaticaPrimeiro());
        }

        private void BtnAlgoritmos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlgoritmosPrimeiro());
        }

        private void BtnBancoDeDados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BancodeDadosPrimeiro());
        }
    }
}