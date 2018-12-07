using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SIPModule.Callbacks
{
	class OpenClientCallback : ICallback
	{
		public string Name => "Открыть клиента";

		public Action Action => () => MessageBox.Show("Клиент - телефон");

		public string IconPath => null;
	}
}
