using System;
using System.Collections.Generic;
using System.Text;
using Actividad_1_1.Helpers;

namespace Actividad_1_1.Model
{
    public class Cliente : ModelBase
    {
        private string _Nombre { get; set; }
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged();
            }
        }

        private string _Apellido1 { get; set; }
        public string Apellido1 {
            get { return _Apellido1; }
            set
            {
                _Apellido1 = value;
                OnPropertyChanged();
            }
        }
        private string _Apellido2 { get; set; }
        public string Apellido2
        {
            get { return _Apellido2; }
            set
            {
                _Apellido2 = value;
                OnPropertyChanged();
            }
        }
        private string _DNI { get; set; }
        public string DNI {
            get { return _DNI; }
            set
            {
                _DNI = value;
                OnPropertyChanged();
            }
        }
        public List<Telefono> Telefonos { get; set; }
    }
}
