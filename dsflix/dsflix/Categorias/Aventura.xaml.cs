using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dsflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        private ImageSource btnAladdin_Source;

        public Aventura()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlixApp.Img.etecflix.png");

            btnAladdin_Source = ImageSource.FromResource("EtecFlixApp.Posters.aladdin.jpg");
            btnCapitaMarvel.Source = ImageSource.FromResource("EtecFlixApp.Posters.CapitaMarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("EtecFlixApp.Posters.PanteraNegra.jpg");
            btnShazam.Source = ImageSource.FromResource("EtecFlixApp.Posters.Shazam.jpg");
        }

        private async void btnCapitaMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.CapitaMarvel());
            }catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }
        private async void btnPanteraNegra_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.PanteraNegra());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops. ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }
        private async void btnShazam_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Shazam());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
            
        }
        private async void btnAladdin_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aladdin());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }
    }
}