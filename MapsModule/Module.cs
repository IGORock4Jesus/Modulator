using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MapsModule
{
	public class Module : IModule
	{
		public string Name => "Карта";

		public string Description => "Карты Яндекс вам в помощь";

		public string IconPath => @"C:\Users\igoro\Downloads\logo.jpg";

		public List<ICallback> Callbacks => new List<ICallback>{
			new Callbacks.AddObjectCallback(),
			new Callbacks.ClearCallback()
		};

		public Image Icon => new Image { Source = new BitmapImage(new Uri(@"C:\Users\igoro\Downloads\logo.jpg")) };
	}
}
