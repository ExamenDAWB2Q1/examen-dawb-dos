using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace examendawbdos.ViewModels
{
    public class ViewModelRegAutos : INotifyPropertyChanged
    {
        public ViewModelRegAutos() {

            crearAutos = new Command(async () =>
            {

                string url = "https://apex.oracle.com/pls/apex/d_app_web/venta_autos/venta_autos_deportivos";

                ConsumoServicios servicios = new ConsumoServicios(url);

                CrearAutoBody body = new CrearAutoBody()
                {

                    marca = marca,
                    modelo = modelo,
                    precio = precio
                };

                CrearDatosResponse response = await servicios.PostAsync<CrearDatosResponse>(body);

                if (response.mensaje == "true")
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

        string marca;

        public string Marca
        {

            get => marca;
            set
            {
                marca = value;
                var args = new PropertyChangedEventArgs(nameof(marca));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string modelo;

        public string Modelo
        {

            get => modelo;
            set
            {
                modelo = value;
                var args = new PropertyChangedEventArgs(nameof(modelo));
                PropertyChanged?.Invoke(this, args);
            }
        }

        int precio;

        public int Precio
        {

            get => precio;
            set
            {
                precio = value;
                var args = new PropertyChangedEventArgs(nameof(precio));
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

        public Command crearAutos{get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
