#region Using Statements
using System;
#endregion

namespace Microsoft.Devices.Sensors
{
	public interface ISensorReading
	{
		DateTimeOffset Timestamp { get; }
	}
}
