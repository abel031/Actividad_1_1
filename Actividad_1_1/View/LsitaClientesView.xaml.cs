using Actividad_1_1.ViewModel;
using Actividad_1_1.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Actividad_1_1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LsitaClientesView : ContentPage
    {
        ListaClientesViewModel vm;
        public LsitaClientesView()
        {
            InitializeComponent();
            vm = new ListaClientesViewModel();
            BindingContext = vm;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var detalle = new DetalleClienteView((Cliente)e.Item);
            await Navigation.PushAsync(detalle);

            ((ListView)sender).SelectedItem = null;
        }
    }
}
