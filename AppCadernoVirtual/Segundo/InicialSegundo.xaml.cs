using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialSegundo : ContentPage
    {
        public InicialSegundo()
        {
            InitializeComponent();
        }

        private void BtnSociologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaSegundo());
        }

        private void BtnEducacaoFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaSegundo());
        }

        private void BtnPortugues_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesSegundo());
        }

        private void BtnIngles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesSegundo());
        }

        private void BtnGeografia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaSegundo());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaSegundo());
        }

        private void BtnFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaSegundo());
        }

        private void BtnQuimica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaSegundo());
        }

        private void BtnBiologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaSegundo());

        }

        private void BtnFilosofia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaSegundo());

        }

        private void BtnEtica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EticaSegundo());

        }

        private void BtnProgWeb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgWebSegundo());

        }

        private void BtnBancoDados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BancodeDadosSegundo());

        }

        private void BtnProgMobile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgMobileSegundo());

        }

        private void BtnDesenvolvimento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesenvolvimentoSegundo());

        }

       
        private void BtnQualidade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualidadeSegundo());

        }

        private void BtnSistemasEmbarcados_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SistemasEmbarcadosSegundo());

        }
    }
}