using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace examendawbdos.ViewModels
{
    public class ViewModelClientes 
    {

        public ViewModelClientes() {

            getDatos();

        }

        private async void getDatos()
        {

            string url = "https://apex.oracle.com/pls/apex/d_app_web/TBL_CLIENTES/CLIENTES";

            ConsumoServicios servicios = new ConsumoServicios(url);
            var response = await servicios.Get<ClientesResponse>();

            foreach (ItemC x in response.items)
            {

                ItemC tempC = new ItemC()
                {
                    id_cliente = x.id_cliente,
                    nombre = x.nombre,
                    correo = x.correo,
                };

                ListaClientes.Add(tempC);
            }

        }

            public ObservableCollection<ItemC> ListaClientes { get; set; } = new ObservableCollection<ItemC>();

    }
}
