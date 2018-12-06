using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulator
{
	class BaseView : INotifyPropertyChanged
	{
		#region Systems

		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Чтоб элемент управления мог обновить значения свойства,
		/// вызовите данный метод при изменении свойства,
		/// и укажите в параметр 'info' название свойства.
		/// </summary>
		/// <param name="propertyName"></param>
		public void RaisePropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
