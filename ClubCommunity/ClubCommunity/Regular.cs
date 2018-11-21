using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunity
{
	class Regular : Member
	{
		private bool status;

		public bool Status
		{
			set
			{
				this.status = value;
			}
			get
			{
				return this.status;
			}
		}
		public Regular(string name, string address, bool status) : base(name, address)
		{
			this.Status = status;
		}

		public override void show()
		{
			Console.WriteLine("------------------o-------------------");
			Console.WriteLine("Name: {0}", this.Name);
			Console.WriteLine("Address: {0}", this.Address);
			Console.WriteLine("Status: {0}", this.Status);
			Console.WriteLine("------------------o-------------------");
		}
	}
}
