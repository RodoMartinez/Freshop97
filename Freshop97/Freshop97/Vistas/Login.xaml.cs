using Plugin.Connectivity;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Freshop97.Vistas
{
    public interface IService1
    {
        string[] Sesion(string email, string contraseña);
        string[] Productos(int idx);
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        public Login ()
		{
			InitializeComponent ();
        }
        public void actividad(bool a)
        {
                indicator.IsVisible = a;
                indicator.IsRunning = a;
                indicator.IsEnabled = a;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            btnI.IsEnabled = false;
            //await Task.Run(()=> { DisplayAlert("","Hola que hace","ok"); });
            actividad(true);
            string status=CrossConnectivity.Current.IsConnected ? "Conectado" : "Desconectado";
            if (status == "Conectado")
            {
                actividad(true);
                try
                {
                    if (string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text))
                    {
                        actividad(false);
                        btnI.IsEnabled = true;
                        await DisplayAlert("Error", "Usuario y/o contraseña incorrecto", "OK");
                    }
                    else
                    {
                        var servicio = DependencyService.Get<IService1>();
                        var existe = servicio.Sesion(user.Text, pass.Text);
                        if (existe[0] == "No existe")
                        {
                            actividad(false);
                            btnI.IsEnabled = true;
                            await DisplayAlert("Informacion", "Usuario y/o contraseña incorrecto", "OK");
                        }
                        else
                        {
                            actividad(false);
                            await DisplayAlert("Informacion", "Inicio exitoso", "OK");
                            Application.Current.MainPage = new Menu(existe);
                        }
                    }
                }catch(Exception es)
                {
                    actividad(false);
                    btnI.IsEnabled = true;
                    await DisplayAlert("Conexion","Error de conexion","OK");
                }
            }
            else
            {
                actividad(false);
                await DisplayAlert("Internet","Necesitar estar conectado a internet","OK");
            }
        }
    }
}