using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        ServiceReference1.Service1Client cliente;
        public Class1()
        {
            cliente = new ServiceReference1.Service1Client();
           
        }

        public string[] Sesion(string email,string password)
        {
            
            Task.Factory.StartNew(() =>
            {
                string[] vars= cliente.inicioSesion(email, password);
            }).Wait();
            //return cliente.inicioSesion(email, password);
           // return cliente.inicioSesion(email,password);
        }
    }
}
