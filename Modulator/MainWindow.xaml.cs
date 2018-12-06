using BaseModule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modulator
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private View view;

		class View : BaseView
		{
			ObservableCollection<ModuleView> modules = new ObservableCollection<ModuleView>();
			public ObservableCollection<ModuleView> Modules
			{
				get => modules;
				set
				{
					if (modules != value)
					{
						modules = value;
						RaisePropertyChanged(nameof(Modules));
					}
				}
			}
		}
		public MainWindow()
		{
			InitializeComponent();

			DataContext = view = new View();
		}

		private void ModuleMenu_Click(object sender, RoutedEventArgs e)
		{

		}

		private void CallbackMenu_Click(object sender, RoutedEventArgs e)
		{
			if (!(sender is FrameworkElement frameworkElement)) return;
			if (!(frameworkElement.DataContext is CallbackView callbackView)) return;

			callbackView.Callback.Action();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			view.Modules.Clear();
			LoadModules();
			LoadModules();

			foreach (var path in view.Modules.Select(w=>w.IconPath))
			{
				Debug.WriteLine($"Down test = {path}");
			}
		}

		private void LoadModules()
		{
			// открываем папку Modules - и загружаем все имеющиеся сборки
			var workingDirectory = Directory.GetCurrentDirectory();
			var filenames = Directory.EnumerateFiles("Modules", "*.dll", SearchOption.TopDirectoryOnly);
			foreach (var filename in filenames)
			{
				var assembly = Assembly.LoadFile(System.IO.Path.Combine(workingDirectory, filename));
				var list = assembly.GetTypes().Where((w) =>
				{
					var t = w.GetTypeInfo();
					if (t.ImplementedInterfaces.Count() != 0)
						if (t.ImplementedInterfaces.FirstOrDefault(i => i.Name == nameof(IModule)) != null)
							return true;
					return false;
				});

				foreach (var @class in list)
				{
					var obj = (BaseModule.IModule)Activator.CreateInstance(@class);

					Debug.WriteLine($"ImageSource={obj.IconPath}");

					view.Modules.Add(new ModuleView
					{
						Name = obj.Name,
						Description = obj.Description,
						IconPath = obj.IconPath,
						Module = obj,
						Callbacks = new ObservableCollection<CallbackView>(obj.Callbacks.Select(w => new CallbackView
						{
							Name = w.Name,
							Callback = w
						}))
					});
				}
			}
		}
	}
}
