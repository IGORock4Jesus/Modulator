using System.Windows.Controls;

namespace Modulator
{
	internal class CallbackView : BaseView
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

		BaseModule.ICallback callback;
		public BaseModule.ICallback Callback
		{
			get => callback;
			set
			{
				if (callback != value)
				{
					callback = value;
					RaisePropertyChanged(nameof(Callback));
				}
			}
		}

		Image icon;
		public Image Icon
		{
			get => icon;
			set
			{
				if (icon != value)
				{
					icon = value;
					RaisePropertyChanged(nameof(Icon));
				}
			}
		}

		//string iconPath;
		//public string IconPath
		//{
		//	get => iconPath;
		//	set
		//	{
		//		if (iconPath != value)
		//		{
		//			iconPath = value;
		//			RaisePropertyChanged(nameof(IconPath));
		//		}
		//	}
		//}

	}
}