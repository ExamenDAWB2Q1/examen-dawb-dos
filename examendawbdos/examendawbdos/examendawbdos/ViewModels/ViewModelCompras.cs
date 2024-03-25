using examendawbdos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace examendawbdos.ViewModels
{
    public class ViewModelCompras
    {
        public ViewModelCompras()
        {

            getDatos();
        }
        private async void getDatos()
        {

            string url = "https://apex.oracle.com/pls/apex/d_app_web/COMPRAS/COMPRAS_CLIENTES";

            ConsumoServicios servicios = new ConsumoServicios(url);
            var response = await servicios.Get<ComprasResponse>();

            foreach (ItemCC x in response.items)
            {

                ItemCC temp = new ItemCC()
                {
                    id_compra = x.id_compra,
                    id_carro = x.id_carro,
                    id_cliente = x.id_cliente,
                    monto_total = x.monto_total
                };

                ListaCompras.Add(temp);
            }

        }
        public ObservableCollection<ItemCC> ListaCompras { get; set; } = new ObservableCollection<ItemCC>();
    }
}