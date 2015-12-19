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
    public partial class F_Workers : Form
    {
        public F_Workers()
        {
            InitializeComponent();
            AddCols();
            fillDataTable();
        }

        public void fillDataTable()
        {
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetData();
            DgWorkers.DataSource = dtWorkers;

        }
        public void AddCols()
        {
            DgWorkers.AutoGenerateColumns = false;
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewTextBoxColumn();
            var col4 = new DataGridViewCheckBoxColumn();
           
            col1.HeaderText = "מספר עובד";
            col1.DataPropertyName = "ID";
            col1.Name = "WorkerNumber";
            DgWorkers.Columns.Add(col1);

            col2.HeaderText = "שם פרטי";
            col2.DataPropertyName = "FirstName";
            col2.Name = "FirstName";
            DgWorkers.Columns.Add(col2);

            col3.HeaderText = "שם משפחה";
            col3.DataPropertyName = "LastName";
            col3.Name = "LastName";
            DgWorkers.Columns.Add(col3);

            col4.HeaderText = "פעיל";
            col4.DataPropertyName = "Active";
            col4.Name = "Active";
            DgWorkers.Columns.Add(col4);

        }

        private void BtnAddNewWorker_Click(object sender, EventArgs e)
        {
            BtnAddNewWorker.Visible = false;
            DgWorkers.Visible = false;
            BtnExitNoSave.Visible = true;
            BtnSave.Visible = true;
            BtnPermissions.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            String fullname = TxtFirstName.Text + " " + TxtLastName.Text;
            Clinic.WorkersDataTable workerCheck = new Clinic.WorkersDataTable();
            workerCheck = daWorkers.GetDataByID(Int32.Parse(TxtID.Text));
            if (workerCheck.Rows.Count == 0) {
            daWorkers.Insert(Int32.Parse(TxtID.Text), TxtFirstName.Text, TxtLastName.Text, 0, true, fullname);
            BtnAddNewWorker.Visible = true;
            BtnPermissions.Visible = true;
            workerCheck = daWorkers.GetData();
            DgWorkers.DataSource = workerCheck;
            DgWorkers.Refresh();
            DgWorkers.Visible = true;
            BtnExitNoSave.Visible = false;
            BtnSave.Visible = false;
                
            }
            else
                MessageBox.Show("עובד עם תעודת זהות זו כבר קיים במערכת.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

        }

        private void BtnExitNoSave_Click(object sender, EventArgs e)
        {
            DgWorkers.Visible = true;
            BtnAddNewWorker.Visible = true;
            BtnPermissions.Visible = true;
            BtnExitNoSave.Visible = false;
            BtnSave.Visible = false;

        }
    }
}
