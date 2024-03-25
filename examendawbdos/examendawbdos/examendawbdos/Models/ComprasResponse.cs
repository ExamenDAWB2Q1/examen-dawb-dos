using System;
using System.Collections.Generic;
using System.Text;

namespace examendawbdos.Models
{

    public class ItemCC
    {

        public int id_compra { get; set; }
        public int id_carro { get; set; }
        public string id_cliente { get; set; }
        public string monto_total { get; set; }

    }

    public class LinkCC
    {

        public string rel { get; set; }

        public string href { get; set; }
    }

    public class ComprasResponse
    {
        public List<ItemCC> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkC> links { get; set; }


    }




}
