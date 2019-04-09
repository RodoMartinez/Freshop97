using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Freshop97.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contacto : ContentPage
	{
        string[] usuario;
		public Contacto (string[] user)
		{
			InitializeComponent ();
            this.usuario = user;
		}

        public void lottiex(string xsd)
        {
            lottie.Animation = xsd;
            lottie.Play();
        }

        public bool valida(string correo1)
        {
            bool correcto=false;
            if (correcto == false)
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(correo1))
                    correcto = true;
                else
                    correcto = false;
            }
            return correcto;
            //if (correcto == true)
            //{
            //    string[] host = (correo1.Split('@'));
            //    string hostname = host[1];
            //    if (host[1].ToLower()=="gmail.com")
            //    {
            //        IPHostEntry IPhst = Dns.GetHostEntry("smtp." + hostname);
            //        IPEndPoint endPt = new IPEndPoint(IPhst.AddressList[0], 587);
            //        Socket s = new Socket(endPt.AddressFamily,
            //        SocketType.Stream, ProtocolType.Tcp);
            //        s.Connect(endPt);
            //        return true;
            //    }
            //    else
            //    {
            //        if (host[1].ToLower()=="hotmail.com")
            //        {
            //            IPHostEntry IPhst = Dns.GetHostEntry("smtp.live.com");
            //            IPEndPoint endPt = new IPEndPoint(IPhst.AddressList[0], 25);
            //            Socket s = new Socket(endPt.AddressFamily,
            //            SocketType.Stream, ProtocolType.Tcp);
            //            s.Connect(endPt);
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {//al usuario que se registre que se verifique su gmail para enviar respuesta
            Response.Text = "Enviando...";
            bool xs= false;
            if (string.IsNullOrEmpty(correo.Text) || string.IsNullOrEmpty(asunto.Text) || string.IsNullOrEmpty(mensaje.Text))
            {
               // await DisplayAlert("Informacion", "Para brindarle un mejor servicio relleno todos los campos", "OK");
                Response.Text = "Para brindarle un mejor servicio relleno todos los campos";
                lottiex("error.json");
            }
            else
            {
                try
                {
                    xs = valida(correo.Text);
                }
                catch (Exception wew) { //await DisplayAlert("Error", "Correo no valido", "OK");
                    Response.Text = "Correo no valido";
                    lottiex("error.json");
                }
                if (xs == true)
                {
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.To.Add("xxsmookeerxx@gmail.com");//aquien va dirigido
                    mail.Subject = asunto.Text;//asunto
                    mail.SubjectEncoding = System.Text.Encoding.UTF8; //
                                                                      // mail.Bcc.Add("xxsmookeerxx@gmail.com");// copia del msg a quien se le envia
                    mail.Body = mensaje.Text + " Mensaje del usuario: " + " " + usuario[0] + ": " + usuario[1] + " " + usuario[2] + " " + usuario[3] + " Correo: " + correo.Text;
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.From = new System.Net.Mail.MailAddress("escanorr3@gmail.com");
                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("escanorr3@gmail.com", "posetela25");
                    //gmail
                    cliente.Port = 587;
                    //hotmail
                    //cliente.Port = 25;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    //cliente.Host = "smtp.live.com";
                    try
                    {
                        cliente.Send(mail);
                        correo.Text = "";
                        asunto.Text = "";
                        mensaje.Text = "";
                      //  await DisplayAlert("Informacion","Mensaje enviado","OK");
                        Response.Text = "Mensaje enviado";
                        lottiex("enviado.json");
                    }
                    catch (Exception es)
                    {
                       // await DisplayAlert("Error", "Error al enviar", "OK");
                        Response.Text = "Error al enviar";
                        lottiex("error.json");
                    }
                }
                else
                {
                    //await DisplayAlert("Error", "Solo hotmail.com,gmail.com", "OK");
                    Response.Text = "Correo no valido";
                    lottiex("error.json");
                }
            }
        }
    }
}