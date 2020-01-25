﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERMSCommon.SCADACommon
{
	public delegate void UpdatePointDelegate(PointType type, ushort pointAddres, ushort newValue);

	public interface IFunctionExecutor
	{
		void EnqueueCommand(IModbusFunction send);
		event UpdatePointDelegate UpdatePointEvent;
	}
}
