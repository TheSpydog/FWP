#region Using Statements
using System;
#endregion

namespace Microsoft.Devices
{
    public class VibrateController
    {
		#region Public Static Properties

		public static VibrateController Default
		{
			get
			{
				if (DefaultInstance == null)
				{
					DefaultInstance = new VibrateController();
				}
				return DefaultInstance;
			}
		}

		#endregion

		#region Private Static Variables

		private static VibrateController DefaultInstance;

		#endregion

		#region Public Methods

		public void Start(TimeSpan duration)
		{
			if (duration.Seconds < 0 || duration.Seconds > 5)
			{
				throw new ArgumentException("Duration is greater than the 5 seconds or duration is negative.");
			}
		}

		public void Stop()
		{
			// no-op
		}

		#endregion
	}
}
