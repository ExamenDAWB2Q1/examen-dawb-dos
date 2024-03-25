using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examendawbdos.Views
{

    public class ViewCrearCompraFlyoutMenuItem
    {
        public ViewCrearCompraFlyoutMenuItem()
        {
            TargetType = typeof(ViewCrearCompraFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}