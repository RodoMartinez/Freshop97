﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/historial", ReplyAction="http://tempuri.org/IService1/historialResponse")]
        System.Data.DataTable historial(int idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/historial", ReplyAction="http://tempuri.org/IService1/historialResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> historialAsync(int idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultaDatosPantalon", ReplyAction="http://tempuri.org/IService1/consultaDatosPantalonResponse")]
        string[] consultaDatosPantalon(int idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultaDatosPantalon", ReplyAction="http://tempuri.org/IService1/consultaDatosPantalonResponse")]
        System.Threading.Tasks.Task<string[]> consultaDatosPantalonAsync(int idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transaccion", ReplyAction="http://tempuri.org/IService1/transaccionResponse")]
        string transaccion(int id_usuario, int id_producto, string id_empresa, string date, int cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transaccion", ReplyAction="http://tempuri.org/IService1/transaccionResponse")]
        System.Threading.Tasks.Task<string> transaccionAsync(int id_usuario, int id_producto, string id_empresa, string date, int cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultaProducto", ReplyAction="http://tempuri.org/IService1/consultaProductoResponse")]
        int[] consultaProducto(int categoria, string tipo_s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/consultaProducto", ReplyAction="http://tempuri.org/IService1/consultaProductoResponse")]
        System.Threading.Tasks.Task<int[]> consultaProductoAsync(int categoria, string tipo_s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inicioSesion", ReplyAction="http://tempuri.org/IService1/inicioSesionResponse")]
        string[] inicioSesion(string email, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/inicioSesion", ReplyAction="http://tempuri.org/IService1/inicioSesionResponse")]
        System.Threading.Tasks.Task<string[]> inicioSesionAsync(string email, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registrarUsuario", ReplyAction="http://tempuri.org/IService1/registrarUsuarioResponse")]
        string registrarUsuario(string nom, string ap, string am, string tel, string email, string contraseña, string edo, string ciudad, string colonia, string calle, string nm, string cp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/registrarUsuario", ReplyAction="http://tempuri.org/IService1/registrarUsuarioResponse")]
        System.Threading.Tasks.Task<string> registrarUsuarioAsync(string nom, string ap, string am, string tel, string email, string contraseña, string edo, string ciudad, string colonia, string calle, string nm, string cp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClassLibrary1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClassLibrary1.ServiceReference1.IService1>, ClassLibrary1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable historial(int idx) {
            return base.Channel.historial(idx);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> historialAsync(int idx) {
            return base.Channel.historialAsync(idx);
        }
        
        public string[] consultaDatosPantalon(int idx) {
            return base.Channel.consultaDatosPantalon(idx);
        }
        
        public System.Threading.Tasks.Task<string[]> consultaDatosPantalonAsync(int idx) {
            return base.Channel.consultaDatosPantalonAsync(idx);
        }
        
        public string transaccion(int id_usuario, int id_producto, string id_empresa, string date, int cantidad) {
            return base.Channel.transaccion(id_usuario, id_producto, id_empresa, date, cantidad);
        }
        
        public System.Threading.Tasks.Task<string> transaccionAsync(int id_usuario, int id_producto, string id_empresa, string date, int cantidad) {
            return base.Channel.transaccionAsync(id_usuario, id_producto, id_empresa, date, cantidad);
        }
        
        public int[] consultaProducto(int categoria, string tipo_s) {
            return base.Channel.consultaProducto(categoria, tipo_s);
        }
        
        public System.Threading.Tasks.Task<int[]> consultaProductoAsync(int categoria, string tipo_s) {
            return base.Channel.consultaProductoAsync(categoria, tipo_s);
        }
        
        public string[] inicioSesion(string email, string contraseña) {
            return base.Channel.inicioSesion(email, contraseña);
        }
        
        public System.Threading.Tasks.Task<string[]> inicioSesionAsync(string email, string contraseña) {
            return base.Channel.inicioSesionAsync(email, contraseña);
        }
        
        public string registrarUsuario(string nom, string ap, string am, string tel, string email, string contraseña, string edo, string ciudad, string colonia, string calle, string nm, string cp) {
            return base.Channel.registrarUsuario(nom, ap, am, tel, email, contraseña, edo, ciudad, colonia, calle, nm, cp);
        }
        
        public System.Threading.Tasks.Task<string> registrarUsuarioAsync(string nom, string ap, string am, string tel, string email, string contraseña, string edo, string ciudad, string colonia, string calle, string nm, string cp) {
            return base.Channel.registrarUsuarioAsync(nom, ap, am, tel, email, contraseña, edo, ciudad, colonia, calle, nm, cp);
        }
    }
}
