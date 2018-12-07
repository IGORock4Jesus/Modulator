using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SIPModule
{
	public class Module : IModule
	{
		public string Name => "Телефон";

		public string Description => "Позволяет совершать званки из приложения.";

		public string IconPath => @"C:\Users\igoro\Downloads\IMG_20180710_200729.jpg";

		public List<ICallback> Callbacks => new List<ICallback> {
			new Callbacks.OpenClientCallback(),
			new Callbacks.QuickCallCallback()
		};

	}
}
