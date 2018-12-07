using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

		public string IconPath => @"C:\Users\igoro\Downloads\add.png";
	}
}
