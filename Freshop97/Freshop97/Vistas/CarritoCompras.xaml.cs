using Freshop97.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Freshop97.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarritoCompras : ContentPage
	{
        public List<Carro> MenuList
        {
            get;
            set;
        }
        public CarritoCompras ()
		{
			InitializeComponent ();

            Thread.MemoryBarrier();
            if (Menu.CarritoFreshop == null)
            {
                lbl.Text = "Carrito vacio";
            }
            else
            {
                lbl.Text = "Carrito";
                MenuList = new List<Carro>();
                for (int i = 0; i < Menu.CarritoFreshop.Count; i++)
                {
                    var p = Menu.CarritoFreshop[i];
                    MenuList.Add(new Carro() { Producto = p.Producto, ID=p.ID, Cantidad = p.Cantidad, Precio=p.Precio });
                }
                Lista.ItemsSource = MenuList;
            }
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Lista.SelectedItem = null;
            //await DisplayAlert("", "", "OK");
        }
    }
}