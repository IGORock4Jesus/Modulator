using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SIPModule.Callbacks
{
	class QuickCallCallback : ICallback
	{
		public string Name => "Быстрый вызов";

		public Action Action => () => MessageBox.Show("Производится звонок в службу спасения");
	}
}
