using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubCommunityGUI
{
    public partial class FormHome : Form
    {
        ClubCommittee cc = new ClubCommittee();
        public FormHome()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string status = "";

            if (radioButtonActive.Checked==false && radioButtonInactive.Checked==false)
            {
                string position = comboBoxPos.Text;
                Member m1 = new Executive(name,address,position);
                cc.addMember(m1);

            }
            else
            {
                if (radioButtonActive.Checked == true)
                    status = radioButtonActive.Text;
                else
                    status = radioButtonInactive.Text;
                Member m1 = new Executive(name, address, status);
                cc.addMember(m1);

            }
            

        }

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
           // radioButtonActive.Checked = true;
        }

        private void radioButtonInactive_CheckedChanged(object sender, EventArgs e)
        {
           // radioButtonInactive.Checked = true;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Member[] a= cc.GetAllDEtails();
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i].show()=="Active" || a[i].show() == "Inactive")
                {
                    labelNameReg.Text = a[i].Name;
                    labelNameReg.Visible = true;
                    labelAddressReg.Text = a[i].Address;
                    labelAddressReg.Visible = true;
                    labelStatusReg.Text = a[i].show();
                    labelStatusReg.Visible = true;
                }
                else
                {
                    labelNameExe.Text = a[i].Name;
                    labelNameExe.Visible = true;
                    labelAddressExe.Text = a[i].Address;
                    labelAddressExe.Visible = true;
                    labelPositionExe.Text = a[i].show();
                    labelPositionExe.Visible = true;
                }
                
            
        }
            
            
        }
    }
}
