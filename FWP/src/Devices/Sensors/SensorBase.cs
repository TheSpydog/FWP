#region Using Statements
using System;
#endregion

namespace Microsoft.Devices.Sensors
{
	public abstract class SensorBase<TSensorReading> : IDisposable
		where TSensorReading : ISensorReading
	{
		#region Public Properties

		public TSensorReading CurrentValue
		{
			get;
		}

		public bool IsDataValid
		{
			get;
		}

		public TimeSpan TimeBetweenUpdates
		{
			get
			{
				return INTERNAL_timeBetweenUpdates;
			}

			set
			{
				INTERNAL_timeBetweenUpdates = value;
			}
		}

		#endregion

		#region Private Variables

		private TimeSpan INTERNAL_timeBetweenUpdates = TimeSpan.FromMilliseconds(2);

		#endregion

		#region Destructor

		~SensorBase()
		{

		}

		#endregion

		#region Public Events

		public event EventHandler<SensorReadingEventArgs<TSensorReading>> CurrentValueChanged;

		#endregion

		#region Public Methods

		public void Dispose()
		{

		}

		public virtual void Start()
		{

		}

		public virtual void Stop()
		{

		}

		#endregion
	}
}
