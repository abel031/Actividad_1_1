using Actividad_1_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activitat_1_1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void ClickedClientes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LsitaClientesView());
        }
    }
}