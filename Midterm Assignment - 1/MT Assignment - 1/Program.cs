using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Program
	{
		static void Main(string[] args)
		{
			Coordinate c1 = new Coordinate();
			c1.Longitude = 23.69;
			c1.Latitude = 72.58;

			Coordinate c2 = new Coordinate();
			c2.Longitude = 73.18;
			c2.Latitude = 35.63;

			Schedule s1 = new Schedule();
			s1.Hour = 8;
			s1.Minute = 15;

			Schedule s2 = new Schedule();
			s2.Hour = 10;
			s2.Minute = 20;

			Employee e1 = new Employee();
			e1.Name = "Tony Stark";
			e1.ID = "AVNGR002";
			e1.Designation = "Senior Pilot";

			Airport a1 = new Airport();
			a1.Name = "NYC Airport";
			a1.ID = 701;
			a1.Location = c1;

			Airport a2 = new Airport();
			a2.Name = "LA Airport";
			a2.ID = 901;
			a2.Location = c2;

			Flight f1 = new Flight();
			f1.Name = "OOP2MTA";
			f1.ID = 707;
			f1.Capacity = 60;
			f1.Pilot = e1;
			f1.From = a1;
			f1.To = a2;
			f1.Departure = s1;
			f1.Arrival = s2;

			Console.WriteLine("Flight ID : {0}",f1.ID);
			Console.WriteLine("Flight Name : {0}", f1.Name);
			Console.WriteLine("Flight capacity : {0}", f1.Capacity);
			Console.WriteLine("Pilot Name :{0}", f1.Pilot.Name);
			Console.WriteLine("Pilot ID :{0}", f1.Pilot.ID);
			Console.WriteLine("Pilot Designation :{0}", f1.Pilot.Designation);
			Console.WriteLine("Airport From Name :{0}", f1.From.Name);
			Console.WriteLine("Airport From ID :{0}", f1.From.ID);
			Console.WriteLine("Airport From Longitude :{0}", f1.From.Location.Longitude);
			Console.WriteLine("Airport From Latitude  :{0}", f1.From.Location.Latitude);
			Console.WriteLine("Airport To Name :{0}", f1.To.Name);
			Console.WriteLine("Airport To ID :{0}", f1.To.ID);
			Console.WriteLine("Airport To Longitude :{0}", f1.To.Location.Longitude);
			Console.WriteLine("Airport To Latitude :{0}", f1.To.Location.Latitude);
			Console.WriteLine("Scheduled Departure at :{0}:{1}",f1.Departure.Hour, f1.Departure.Minute);
			Console.WriteLine("Scheduled Arrival at  :{0}:{1}", f1.Arrival.Hour, f1.Arrival.Minute);
		}
	}
}
