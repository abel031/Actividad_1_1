using Actividad_1_1.ViewModel;
using Actividad_1_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Actividad_1_1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleClienteView : ContentPage
    {
        private DetalleClienteViewModel vm;
        private Telefono selec;
        public DetalleClienteView(Cliente cli)
        {
            InitializeComponent();
            vm = new DetalleClienteViewModel();
            vm.Cliente = cli;
            vm.loadTel();
            BindingContext = vm;
        }

        private void Add(object sender, EventArgs e)
        {
            Telefono sel = new Telefono { Numero = tlf.Text };
            vm.add(sel);
        }

        private void Del(object sender, EventArgs e)
        {
            vm.elimina(selec);
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selec = (Telefono)e.Item;
        }
    }
}