using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Freshop97.Vistas;
using Xamarin.Forms;
using Uri = Android.Net.Uri;

[assembly: Dependency(typeof(Freshop97.Droid.Service))]
namespace Freshop97.Droid
{
    public class Service : IService1
    {
        public string[] Sesion(string email, string contraseña)
        {
            Servicio1.Service1 service = new Servicio1.Service1();
            return service.inicioSesion(email, contraseña);
        }

        public string[] Productos(int idx)
        {
            Servicio1.Service1 service = new Servicio1.Service1();
            return service.consultaDatosPantalon(idx,true);
        }
    }
}