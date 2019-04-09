using Freshop97.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Freshop97.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        string[] usuario;
        public static List<Carro> CarritoFreshop = new List<Carro>();
		public Menu (string[] args)
		{
			InitializeComponent ();
            this.usuario = args;
            var page = new Principal(args);
            Contenido.Content = page.Content;
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var page = new Principal(usuario);
            Contenido.Content = page.Content;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var page = new CarritoCompras();//enviar usuario
            Contenido.Content = page.Content;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            var page = new Contacto(usuario);
            Contenido.Content = page.Content;
        }
        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            var page = new Perfil();
            Contenido.Content = page.Content;
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Alerta!", "¿Desea cerrar sesion?", "Si", "Cancelar");
            if (result)
            {
                Freshop97.App.Current.MainPage = new Login();
            }
        }
    }
}