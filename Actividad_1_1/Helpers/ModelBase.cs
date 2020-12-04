using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Actividad_1_1.Helpers
{
    public class ModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
	}
}
