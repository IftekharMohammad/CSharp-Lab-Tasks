using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Assignment___1
{
	class Employee
	{
		private string id;
		private string name;
		private string designation;

		public string ID
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
		public string Designation
		{
			set
			{
				this.designation = value;
			}
			get
			{
				return this.designation;
			}
		}
	}
}
