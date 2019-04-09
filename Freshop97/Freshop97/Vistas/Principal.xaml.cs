using Freshop97.Modelos;
using Plugin.Connectivity;
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
	public partial class Principal : ContentPage
	{
        public List<MenuItems> MenuList
        {
            get;
            set;
        }
        string[] usuario;
        //string[] producto;

		public Principal (string[] usuario)
		{
			InitializeComponent ();
            this.usuario = usuario;
            //sesion.Text = "Usuario: " + usuario[1];

            //await Task.Run(()=> { DisplayAlert("","Hola que hace","ok"); });
            string status = CrossConnectivity.Current.IsConnected ? "Conectado" : "Desconectado";
            if (status == "Conectado")
            {
                try
                {
                    var servicio = DependencyService.Get<IService1>();

                    var p1 = servicio.Productos(1);
                    var p2 = servicio.Productos(2);
                    var p3 = servicio.Productos(3);
                    var p4 = servicio.Productos(4);

                    MenuList = new List<MenuItems>();
                    MenuList.Add(new MenuItems() { ID = "0", Title = p1[0], Icon = "Logo.jpg", Precio = p1[3] });
                    MenuList.Add(new MenuItems() { ID = "1", Title = p2[0], Icon = "Logo.jpg", Precio = p2[3] });
                    MenuList.Add(new MenuItems() { ID = "2", Title = p3[0], Icon = "Logo.jpg", Precio = p3[3] });
                    MenuList.Add(new MenuItems() { ID = "3", Title = p4[0], Icon = "Logo.jpg", Precio = p4[3] });
                    Lista.ItemsSource = MenuList;
                }
                catch (Exception es)
                {
                    DisplayAlert("Conexion", "Error de conexion", "OK");
                }
            }
            else
            {
                DisplayAlert("Internet", "Necesitar estar conectado a internet", "OK");
            }
        
        }

        private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {//aqui se le asigna a la segunda pagina de añadir al carrito
            
            var item = (MenuItems)e.SelectedItem;
            if (item != null)
            {
                cardImage.Source= item.Icon;
                lbl1.Text = item.Title;
                lbl2.Text = item.Precio;
                lbl3.Text = item.ID;
                Rotate();
                Lista.SelectedItem = null;
            }
        }

        private bool ShowDetails = false;
        public async void Rotate()
        {
            var cardToShow = ShowDetails ? card : details;
            var cardToHide = ShowDetails ? details : card;

            cardToShow.HasShadow = false;
            cardToHide.HasShadow = false;

            await cardToHide.RotateYTo(90, 125, Easing.Linear);
            cardToHide.IsVisible = false;

            cardToShow.RotationY = -90;
            cardToShow.IsVisible = true;

            await cardToShow.RotateYTo(0, 125, Easing.SpringOut);
            cardToShow.HasShadow = true;
            cardToHide.HasShadow = true;

            ShowDetails = !ShowDetails;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Rotate();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {//carrito
            if (string.IsNullOrEmpty(cantidad.Text))
            {
                cantidad.TextColor = Color.Red;
            }
            else
            {
                cantidad.TextColor = Color.Black;
                bool existe = false;
                int pos = 0;
                if (Menu.CarritoFreshop == null)
                {

                }
                else
                {
                    for (int i = 0; i < Menu.CarritoFreshop.Count; i++)
                    {
                        if (Menu.CarritoFreshop[i].ID == lbl3.Text)
                        {
                            existe = true;
                            pos = i;
                            break;
                        }
                    }
                }

                if (existe == true)
                {
                    Menu.CarritoFreshop[pos].Cantidad = Menu.CarritoFreshop[pos].Cantidad + int.Parse(cantidad.Text);
                    Rotate();
                    cantidad.Text = "";
                }
                else
                {
                    Menu.CarritoFreshop.Add(new Carro { ID = lbl3.Text, Producto = lbl1.Text, Precio = lbl2.Text, Cantidad = cantidad.Text });
                    Rotate();
                    cantidad.Text = "";
                }
            }
        }
    }
}