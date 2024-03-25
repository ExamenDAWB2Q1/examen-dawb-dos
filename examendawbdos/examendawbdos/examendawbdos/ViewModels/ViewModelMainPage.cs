using examendawbdos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace examendawbdos.ViewModels
{
    public class ViewModelMainPage : INotifyPropertyChanged
    {
        public ViewModelMainPage() {

            ListaAutos = new Command(() =>
            {
                var pagina = new ViewAutos();
                Application.Current.MainPage.Navigation.PushAsync(pagina);  
            });

            ListaClientes = new Command(() =>
            {
                var pagina = new ViewClientes();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });

            NuevaCompra = new Command(() =>
            {
                var pagina = new ViewCompras();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });

            CrearCliente = new Command(() => {

                var pagina = new ViewCrearClientes();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });

            CrearAutos = new Command(() => {
                var pagina = new ViewCrearAutos();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });

            CrearCompras = new Command(() => {
                var pagina = new ViewCrearCompraDetail();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });
        }

        public Command CrearAutos { get; }
        public Command ActualizarCliente { get; set; }
        public Command CrearCliente { get; }
        public Command ListaClientes { get; }
        public Command ListaAutos { get; }
        public Command NuevaCompra { get; }

        public Command CrearCompras { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
