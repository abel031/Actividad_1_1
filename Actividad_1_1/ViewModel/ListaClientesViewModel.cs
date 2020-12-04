using Actividad_1_1.Helpers;
using Actividad_1_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Actividad_1_1.ViewModel
{
    class ListaClientesViewModel : ViewModelBase
    {
        private ObservableCollection<Cliente> _Clientes = new ObservableCollection<Cliente>(DB.ClientesDB);
        public ObservableCollection<Cliente> Clientes
        {
            get { return _Clientes; }
            set
            {
                _Clientes = value;
                OnPropertyChanged();
            }
        }




    }
}
