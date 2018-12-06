﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModule
{
    public interface IModule
    {
		string Name { get; }
		string Description { get; }
		string IconPath { get; }
		List<ICallback> Callbacks { get; }
	}
}
