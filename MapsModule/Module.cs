using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsModule
{
	public class Module : IModule
	{
		public string Name => "Карта";

		public string Description => "Карты Яндекс вам в помощь";

		public string IconPath => @"C:\Users\IGORo\Downloads\yamaps.png";

		public List<ICallback> Callbacks => new List<ICallback>{
			new Callbacks.AddObjectCallback(),
			new Callbacks.ClearCallback()
		};
	}
}
