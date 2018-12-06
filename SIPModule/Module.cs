using BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPModule
{
	public class Module : IModule
	{
		public string Name => "Телефон";

		public string Description => "Позволяет совершать званки из приложения.";

		public string IconPath => @"C:\Users\IGORo\Downloads\phone.png";

		public List<ICallback> Callbacks => new List<ICallback> {
			new Callbacks.OpenClientCallback(),
			new Callbacks.QuickCallCallback()
		};
	}
}
