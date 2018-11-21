using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Coordinate
	{
		private double longitude;
		private double latitude;

		public double Longitude
		{
			set
			{
				this.longitude = value;
			}
			get
			{
				return this.longitude;
			}
		}
		public double Latitude
		{
			set
			{
				this.latitude = value;
			}
			get
			{
				return this.latitude;
			}
		}
	}
}
