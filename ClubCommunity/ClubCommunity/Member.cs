using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunity
{
	class Member
	{
		private string name;
		private string address;

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

		public string Address
		{
			set
			{
				this.address = value;
			}
			get
			{
				return this.address;
			}
		}
		public Member()
		{
		}
		public Member(string name, string address)
		{
			this.Name = name;
			this.Address = address;
		}

		public virtual void show()
		{
			Console.WriteLine("------------------o-------------------");
			Console.WriteLine("Name: {0}", this.Name);
			Console.WriteLine("Address: {0}", this.Address);
			Console.WriteLine("------------------o-------------------");
		}
	}
}
