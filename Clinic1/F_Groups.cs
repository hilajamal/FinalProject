using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic1
{
    public partial class F_Groups : Form
    {
        public F_Groups()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {

            F_AddNewGroup group = new F_AddNewGroup();
            group.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_UpdateGroups update = new F_UpdateGroups();
            update.Show();
        }

        private void BtnAddToGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
