using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunity
{
	class Program
	{
		static void Main(string[] args)
		{
			Executive e = new Executive("ABC", "Banani", "Secretary");

			Regular r = new Regular("XYZ", "Uttara", true);

			ClubCommittee cc = new ClubCommittee();
			cc.addMember(e);
			cc.addMember(r);
			cc.GetAllDEtails();

		}
	}
}
