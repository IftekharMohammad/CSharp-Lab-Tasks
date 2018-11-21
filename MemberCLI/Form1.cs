using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubC
{
    public partial class MainWindow : Form
    {
        ClubCommittee c = new ClubCommittee();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //radioButtonActive.AutoCheck =true;
            //radioButtonInactive.AutoCheck =true;
            
            if (radioButtonActive.Checked == false && radioButtonInactive.Checked == false)
            {
                string name = textBoxName.Text;
                string address = textBoxAddress.Text;
                string position = comboBoxPosition.SelectedItem.ToString();
                Member m = new Executive(name, address, position);
                c.addMember(m);
            }
            else {
                string name = textBoxName.Text;
                string address = textBoxAddress.Text;
                string status="";
                if (radioButtonActive.Checked == true)
                {
                    status = radioButtonActive.Text;
                }
                else if (radioButtonInactive.Checked == true) {
                    status = radioButtonInactive.Text;
                }
                Member m = new Executive(name, address, status);
                c.addMember(m);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            c.displayMember();
        }
    }
}
