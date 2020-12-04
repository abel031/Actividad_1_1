using Actividad_1_1.Helpers;
using Actividad_1_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Actividad_1_1.ViewModel
{
    public class DetalleClienteViewModel : ViewModelBase
    {
        private Cliente _Cliente { get; set; }
        public Cliente Cliente
        {
            get { return _Cliente; }
            set
            {
                _Cliente = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Telefono> _telefonos;
        public ObservableCollection<Telefono> telefonos
        {
            get { return _telefonos; }
            set
            {
                _telefonos = value;
                OnPropertyChanged();
            }
        }

        public DetalleClienteViewModel()
        {

        }

        public void elimina(Telefono sel)
        {
            telefonos.Remove(sel);
            OnPropertyChanged("telefonos");
        }

        public void add(Telefono sel)
        {
            telefonos.Add(sel);
            OnPropertyChanged("telefonos");
        }

        public void loadTel()
        {
            _telefonos = new ObservableCollection<Telefono>(_Cliente.Telefonos);
        }
    }
}
