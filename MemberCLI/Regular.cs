using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubC
{
    class Regular:Member
    {
        private string status;

        public string Status
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
        public Regular(string name, string address, string status) : base(name, address) {
            this.Status = status;
        }
        
        public override string[] show()
        {
            string[] ret = new string[] { this.Name, this.Address, this.Status };

            return ret;
        }
    }
}
