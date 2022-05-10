using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual.Terceiro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicialTerceiro : ContentPage
    {
        public InicialTerceiro()
        {
            InitializeComponent();
        }

        private void BtnPortugues_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PortuguesTerceiro());
        }

        private void BtnIngles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InglesTerceiro());
        }

        private void BtnGeografia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeografiaTerceiro());
        }

        private void BtnBiologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BiologiaTerceiro());
        }

        private void BtnQuimica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuimicaTerceiro());
        }

        private void BtnFilosofia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilosofiaTerceiro());
        }

        private void BtnSociologia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SociologiaTerceiro());
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaTerceiro());
        }

        private void BtnFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FisicaTerceiro());
        }

        private void BtnEducacaoFisica_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EducacaoFisicaTerceiro());
        }

        private void BtnProgWeb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgWebTerceiro());
        }

        private void BtnProgMobile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProgMobileTerceiro());
        }

        private void BtnInternet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InternetTerceiro());
        }

        private void BtnTCC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TccTerceiro());
        }

        private void BtnQualidade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualidadeTerceiro());
        }
    }
}