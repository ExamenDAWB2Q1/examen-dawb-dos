using System;
using System.Collections.Generic;
using System.Text;

namespace examendawbdos.Models
{

    public class ItemC
    {

        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }

    }

    public class LinkC
    {

        public string rel { get; set; }

        public string href { get; set; }
    }

    public class ClientesResponse
    {
        public List<ItemC> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkC> links { get; set; }


    }

    


}
