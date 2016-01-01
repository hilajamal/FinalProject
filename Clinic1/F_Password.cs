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
    public partial class F_Password : Form
    {

                        public F_Password()
        {
            InitializeComponent();
            setComboBox();
            txtPassword.Focus();
        }

        public void setComboBox()
        {
            // Workers
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbWorker.DataSource = dtWorkers;
            CmbWorker.SelectedIndex = 0;
            CmbWorker.AutoCompleteMode = AutoCompleteMode.Append;
            CmbWorker.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbWorker.DisplayMember = "FullName";
            CmbWorker.ValueMember = "ID";
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
                MessageBox.Show("יש להזין סיסמה");
            else
            {
                ClinicTableAdapters.WorkersTableAdapter da = new ClinicTableAdapters.WorkersTableAdapter();
                int id = Int32.Parse(CmbWorker.SelectedValue.ToString());
                Clinic.WorkersDataTable dt = da.GetDataByIDAndPassword(id, txtPassword.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("סיסמה שגויה");
                else
                {

                   Globals.ConnectedUserID = Int32.Parse(dt.Rows[0]["ID"].ToString());
                   Globals.ConnectedUserPermission = Int32.Parse(dt.Rows[0]["Permission"].ToString());
                   Globals.ConnectedUserName = dt.Rows[0]["FullName"].ToString();

                    this.Hide();
                    F_MainForm main = new F_MainForm();
                    main.Show();

                }

            }
      
        
        
        
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            BtnLogIn.PerformClick();
        }
    }
}
