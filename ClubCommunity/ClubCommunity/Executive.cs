using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunity
{
	class Executive : Member
	{
		private string position;

		public string Position
		{
			set
			{
				this.position = value;
			}
			get
			{
				return this.position;
			}
		}
		public Executive(string name, string address, string position) : base(name, address)
		{
			this.Position = position;
		}
		public override void show()
		{
			Console.WriteLine("------------------o-------------------");
			Console.WriteLine("Name: {0}",this.Name);
			Console.WriteLine("Address: {0}", this.Address);
			Console.WriteLine("Position: {0}", this.Position);
			Console.WriteLine("------------------o-------------------");
		}
	}
}
