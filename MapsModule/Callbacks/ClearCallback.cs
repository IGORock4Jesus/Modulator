using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapsModule.Callbacks
{
	class ClearCallback : ICallback
	{
		public string Name => "Очистить карту";

		public Action Action => () => MessageBox.Show("Карта очищена");

		public string IconPath => null;
	}
}
