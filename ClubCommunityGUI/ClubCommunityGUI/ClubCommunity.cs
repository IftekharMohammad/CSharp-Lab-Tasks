using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCommunityGUI
{
    class ClubCommittee
    {
        private int counter = 0;
        private Member[] members = new Member[2];
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
        public Member[] GetAllDEtails()
        {
            return members;
        }
    }
}
