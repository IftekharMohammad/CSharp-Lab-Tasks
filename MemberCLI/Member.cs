using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubC
{
    abstract class Member
    {
        private string name;
        private string address;

        public string Name {
            set {
                this.name = value;
            }
            get {
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

        public Member(string name, string address) {
            this.Name = name;
            this.Address = address;
        }

        public abstract string[] show();
    }
}
