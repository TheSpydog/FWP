using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Devices.Sensors
{
	public sealed class Accelerometer : SensorBase<AccelerometerReading>
	{
		#region Public Static Properties

		public static bool IsSupported
		{
			get
			{
				//TODO: Actually detect an accelerometer
				return false;
			}

			internal set
			{
				// lol
			}
		}

		#endregion

		#region Private Static Variables

		private static int InstanceCount;

		#endregion

		#region Public Variables

		public SensorState State
		{
			get;
			private set;
		}

		#endregion

		#region Constructor

		public Accelerometer()
		{
			if (InstanceCount >= 10)
			{
				SensorFailedException exception = new SensorFailedException();
			}

			InstanceCount += 1;
		}

		#endregion

		#region Public Events

		[Obsolete("use CurrentValueChanged")]
		public event EventHandler<AccelerometerReadingEventArgs> ReadingChanged;

		#endregion

		#region Public Methods

		public void Dispose()
		{

		}

		public override void Start()
		{
			//TODO: Throw exceptions
		}

		public override void Stop()
		{
			//TODO: Throw exceptions
		}

		#endregion
	}
}
