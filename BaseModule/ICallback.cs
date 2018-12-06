using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModule
{
	public interface ICallback
	{
		string Name { get; }
		Action Action { get; }
	}
}
