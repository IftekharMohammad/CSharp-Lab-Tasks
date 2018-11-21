using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Flight
	{
		 private int id;
		 private string name;
		 private int capacity;
		 private Employee pilot;
		 private Airport from;
		 private Airport to;
		 private Schedule departure;
		 private Schedule arrival;		public int ID
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
		}		public int Capacity {
			set
			{
				this.capacity = value;
			}
			get
			{
				return this.capacity;
			}
		}		public Employee Pilot
		{
			set
			{
				this.pilot = value;
			}
			get
			{
				return this.pilot;
			}
		}
		public Airport From
		{
			set
			{
				this.from = value;
			}
			get
			{
				return this.from;
			}
		}
		public Airport To
		{
			set
			{
				this.to = value;
			}
			get
			{
				return this.to;
			}
		}
		public Schedule Departure
		{
			set
			{
				this.departure = value;
			}
			get
			{
				return this.departure;
			}
		}
		public Schedule Arrival
		{
			set
			{
				this.arrival = value;
			}
			get
			{
				return this.arrival;
			}
		}
	}
}
