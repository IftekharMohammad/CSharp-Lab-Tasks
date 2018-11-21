using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Airport
	{
		private int id;
		private string name;
		private Coordinate location;

		public int ID
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id;
			}
		}
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}
		public Coordinate Location
		{
			set
			{
				this.location = value;
			}
			get
			{
				return this.location;
			}
		}
	}
}
