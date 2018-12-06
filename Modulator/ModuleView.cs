using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulator
{
	class ModuleView : BaseView
	{

		string name;
		public string Name
		{
			get => name;
			set
			{
				if (name != value)
				{
					name = value;
					RaisePropertyChanged(nameof(Name));
				}
			}
		}

		string description;
		public string Description
		{
			get => description;
			set
			{
				if (description != value)
				{
					description = value;
					RaisePropertyChanged(nameof(Description));
				}
			}
		}

		string iconPath;
		public string IconPath
		{
			get => iconPath;
			set
			{
				if (iconPath != value)
				{
					iconPath = value;
					RaisePropertyChanged(nameof(IconPath));
				}
			}
		}


		ObservableCollection<CallbackView> callbacks=new ObservableCollection<CallbackView>();
		public ObservableCollection<CallbackView> Callbacks
		{
			get => callbacks;
			set
			{
				if (callbacks != value)
				{
					callbacks = value;
					RaisePropertyChanged(nameof(Callbacks));
				}
			}
		}

		BaseModule.IModule module;
		public BaseModule.IModule Module
		{
			get => module;
			set
			{
				if (module != value)
				{
					module = value;
					RaisePropertyChanged(nameof(Module));
				}
			}
		}


	}
}
