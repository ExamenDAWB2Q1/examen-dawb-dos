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

            NuevoAuto = new Command(() =>
            {
                var pagina = new ViewAutos();
                Application.Current.MainPage.Navigation.PushAsync(pagina);  
            });

            NuevoCliente = new Command(() =>
            {
                var pagina = new ViewClientes();
                Application.Current.MainPage.Navigation.PushAsync(pagina);
            });


        }
        public Command NuevoCliente { get; }
        public Command NuevoAuto { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
