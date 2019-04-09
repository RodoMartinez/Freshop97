using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Freshop97.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfil : ContentPage
	{
        public Perfil ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Error", "No soportado", "OK");
                }
                var file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null)
                {
                    return;
                }

                var xs= ImageSource.FromStream(() => file.GetStream());
                imagen.Source = xs;
                //ImageSource.FromFile(xs);
                //en.Text = ImageSource.FromStream(() => file.GetStream()).ToString();
            }
            catch(Exception ews)
            {

            }
        }
    }
}