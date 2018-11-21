using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Schedule
	{
		private int hour;
		private int minute;

		public int Hour
		{
			set
			{
				this.hour = value;
			}
			get
			{
				return this.hour;
			}
		}
		public int Minute
		{
			set
			{
				this.minute = value;
			}
			get
			{
				return this.minute;
			}
		}
	}
}
