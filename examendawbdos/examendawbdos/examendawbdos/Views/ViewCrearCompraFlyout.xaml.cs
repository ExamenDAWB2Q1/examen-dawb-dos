using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace examendawbdos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCrearCompraFlyout : ContentPage
    {
        public ListView ListView;

        public ViewCrearCompraFlyout()
        {
            InitializeComponent();

            BindingContext = new ViewCrearCompraFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class ViewCrearCompraFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ViewCrearCompraFlyoutMenuItem> MenuItems { get; set; }
            
            public ViewCrearCompraFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ViewCrearCompraFlyoutMenuItem>(new[]
                {
                    new ViewCrearCompraFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ViewCrearCompraFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ViewCrearCompraFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ViewCrearCompraFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ViewCrearCompraFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}