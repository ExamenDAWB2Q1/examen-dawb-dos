using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace examendawbdos.ViewModels
{
    public class ViewModelAutos
    {
        public ViewModelAutos() {
        
            getDatos();
        }

        private async void getDatos() {

            string url = "https://apex.oracle.com/pls/apex/d_app_web/venta_autos/venta_autos_deportivos";

            ConsumoServicios servicios = new ConsumoServicios(url);
            var response = await servicios.Get<AutosReponse>();

            foreach (Item x in response.items) {

                Item temp = new Item()
                {
                    id_carro = x.id_carro,
                    marca = x.marca,
                    modelo = x.modelo,
                    precio = x.precio
                };

                ListaAutos.Add(temp);
            }

        }

        public ObservableCollection<Item> ListaAutos { get; set; } = new ObservableCollection<Item>();  

    }
}
