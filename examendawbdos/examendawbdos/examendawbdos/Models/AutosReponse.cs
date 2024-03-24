using System;
using System.Collections.Generic;
using System.Text;

namespace examendawbdos.Models
{

    public class Item { 
    
        public int id_carro { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public int precio { get; set; }

    }

    public class Link {
    
        public string rel { get; set; }

        public string href { get; set; }
    }

    public class AutosReponse
    {
        public List<Item> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<Link> links { get; set; }
    }
}
