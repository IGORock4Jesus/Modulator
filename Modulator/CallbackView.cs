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

	}
}