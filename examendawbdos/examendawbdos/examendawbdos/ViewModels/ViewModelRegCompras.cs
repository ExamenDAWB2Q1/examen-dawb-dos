using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace examendawbdos.ViewModels
{
    public class ViewModelRegCompras : INotifyPropertyChanged
    {

        public ViewModelRegCompras()
        {

            crearCompras = new Command(async () => {

                string url = "https://apex.oracle.com/pls/apex/d_app_web/COMPRAS/COMPRAS_CLIENTES";

                ConsumoServicios servicios = new ConsumoServicios(url);

                CrearCompraBody body = new CrearCompraBody()
                {
                    
                    id_carro = id_carro,
                    id_cliente = id_cliente,
                    monto_total = monto_total
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

        string id_carro;

        public string Id_carro
        {

            get => id_carro;
            set
            {
                id_carro = value;
                var args = new PropertyChangedEventArgs(nameof(Id_carro));
                PropertyChanged?.Invoke(this, args);
            }
        }


        string id_cliente;

        public string Id_cliente
        {

            get => id_cliente;
            set
            {
                id_cliente = value;
                var args = new PropertyChangedEventArgs(nameof(Id_cliente));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string monto_total;

        public string Monto_total
        {

            get => monto_total;
            set
            {
                monto_total = value;
                var args = new PropertyChangedEventArgs(nameof(Monto_total));
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

        public Command crearCompras { get; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
