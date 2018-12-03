#region Using Statements
using System;
using Microsoft.Xna.Framework;
#endregion

namespace Microsoft.Devices.Sensors
{
	public struct AccelerometerReading : ISensorReading
	{
		#region Public Properties

		public Vector3 Acceleration
		{
			get;
			internal set;
		}

		public DateTimeOffset Timestamp
		{
			get;
			internal set;
		}

		#endregion
	}
}
