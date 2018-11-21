using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunity
{
	class ClubCommittee
	{
		private int counter = 0;
		private Member[] members = new Member[100];
		public void addMember(Member m)
		{
			if (counter < members.Length)
			{
				members[counter] = new Member();
				members[counter] = m;
				counter++;
			}
			else
			{
				Console.WriteLine("Out Of Limit");
			}
		}
		public void GetAllDEtails()
		{
			for (int i = 0;  members[i]!=null; i++) {
				members[i].show();
			}
		}
	}
}
