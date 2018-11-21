using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubC
{
    class ClubCommittee
    {
        private Member[] members = new Member[2];
        public void addMember(Member m) {
            int i = 0;
            while (members[i] != null) {
                if (members[i] == null) {
                    members[i] = m;
                }
                i++;
            }
        }
        public Member[] displayMember() {
            //for (int i = 0; i < members.Length; i++) {
             //  string[] arr = members[i].show();
              //  if(arr[2]==)
            //}
            return members;
        }
    }
}
