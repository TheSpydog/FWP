using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Devices.Sensors
{
	public class SensorReadingEventArgs<T> : EventArgs
		where T : ISensorReading
	{
		#region Public Properties

		public T SensorReading
		{
			get;
			set;
		}

		#endregion

		#region Constructor

		public SensorReadingEventArgs()
		{
			//TODO: What goes here?
		}

		#endregion
	}
}
