using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace examendawbdos.ViewModels
{
    public class ViewModelRegCliente : INotifyPropertyChanged
    {

        public ViewModelRegCliente() {

            crearCliente = new Command( async () => {

                string url = "https://apex.oracle.com/pls/apex/d_app_web/TBL_CLIENTES/CLIENTES";

                ConsumoServicios servicios = new ConsumoServicios(url);

                CrearClienteBody body = new CrearClienteBody() {
                
                    nombre = nombre,
                    correo = correo
                };

                CrearDatosResponse response = await servicios.PostAsync<CrearDatosResponse>(body);

                if (response.mensaje == "Creación Exitosa")
                {
                    var pagina = new MainPage();
                    Application.Current.MainPage.Navigation.PushAsync(pagina);

                }
                else
                {
                    Result = response.mensaje;
                }

            });

        }

        string nombre;

        public string Nombre
        {

            get => nombre;
            set
            {
                nombre = value;
                var args = new PropertyChangedEventArgs(nameof(Nombre));
                PropertyChanged?.Invoke(this, args);
            }
        }


        string correo;

        public string Correo
        {

            get => correo;
            set
            {
                correo = value;
                var args = new PropertyChangedEventArgs(nameof(correo));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string result;

        public string Result
        {

            get => result;
            set
            {
                result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command crearCliente { get; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
