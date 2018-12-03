#region Using Statements
using System;
#endregion

namespace Microsoft.Devices.Sensors
{
	public class AccelerometerReadingEventArgs : EventArgs
	{
		#region Public Properties

		public DateTimeOffset Timestamp
		{
			get;
			private set;
		}

		public double X
		{
			get;
		}

		public double Y
		{
			get;
		}

		public double Z
		{
			get;
		}

		#endregion
	}
}
