using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapsModule.Callbacks
{
	class AddObjectCallback : ICallback
	{
		public string Name => "Добавить объект на карту";

		public Action Action => () =>
		{
			if (MessageBox.Show("Казпочта Уштерек", "Добавление объекта", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
				MessageBox.Show("Объект успешно добавлен");
			else
				MessageBox.Show("Операция отменена");
		};
	}
}
