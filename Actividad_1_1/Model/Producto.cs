using System;
using System.Collections.Generic;
using System.Text;
using Actividad_1_1.Helpers;

namespace Actividad_1_1.Model
{
    public class Producto : ModelBase
    {
        private string _nombre;
        private double _pvp, _stock;
        private Iva _iva;
        public string Nombre {
            get { return _nombre; }
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }
        public double PVP {
            get { return _pvp; }
            set
            {
                _pvp = value;
                OnPropertyChanged();
            }
        }
        public Iva IVA {
            get { return _iva; }
            set
            {
                _iva = value;
                OnPropertyChanged();
            }
        }
        public double Stock {
            get { return _stock; }
            set
            {
                _stock = value;
                OnPropertyChanged();
            }
        }
    }
}
