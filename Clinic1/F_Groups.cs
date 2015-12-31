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
        public Boolean handeled = false;
        public F_Groups()
        {
            InitializeComponent();
            setGroupNumber();
            AddCols();

        }

        private void AddCols()
        {
            DgPatientsUpdate.AutoGenerateColumns = false;
            DgPatientsAdd.AutoGenerateColumns = false;
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();
           
            //PatientsID
            CmblPatientIdAdd.DataSource = dtPatients;
            CmblPatientIdAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientIdAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblPatientIdAdd.DisplayMember = "ID";
            CmblPatientIdAdd.ValueMember = "ID";
            CmblPatientIdAdd.SelectedIndex = 0;

            cmbPatientIDUpdate.DataSource = dtPatients;
            cmbPatientIDUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            cmbPatientIDUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatientIDUpdate.DisplayMember = "ID";
            cmbPatientIDUpdate.ValueMember = "ID";
            cmbPatientIDUpdate.SelectedIndex = 0;

            //PatientsName
            CmbPatientNameAdd.DataSource = dtPatients;
            CmbPatientNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameAdd.DisplayMember = "FullName";
            CmbPatientNameAdd.ValueMember = "ID";
            CmbPatientNameAdd.SelectedIndex = 0;

            cmbPatientNameUpdate.DataSource = dtPatients;
            cmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            cmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatientNameUpdate.DisplayMember = "FullName";
            cmbPatientNameUpdate.ValueMember = "ID";
            cmbPatientNameUpdate.SelectedIndex = 0;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col1.HeaderText = "תעודת זהות";
            col1.DataPropertyName = "ID";
            col1.Name = "ID";
            DgPatientsAdd.Columns.Add(col1);
   
            col2.HeaderText = "שם מלא";
            col2.DataPropertyName = "FullName";
            col2.Name = "FullName";
            DgPatientsAdd.Columns.Add(col2);


            col3.HeaderText = "תעודת זהות";
            col3.DataPropertyName = "ID";
            col3.Name = "ID";
            DgPatientsUpdate.Columns.Add(col3);

            col4.HeaderText = "שם מלא";
            col4.DataPropertyName = "FullName";
            col4.Name = "FullName";
            DgPatientsUpdate.Columns.Add(col4);


            ClinicTableAdapters.GroupsTableAdapter daGroups = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dtGroups = daGroups.GetData();
            CmbGroupIdUpdate.DataSource = dtGroups;
            CmbGroupIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupIdUpdate.DisplayMember = "GroupNumber";
            CmbGroupIdUpdate.ValueMember = "GroupNumber";
            handeled = true;
            CmbGroupIdUpdate.SelectedIndex = 0;
            DgPatientsUpdate.DataSource = daPatients.GetDataByPatientIDInnerJoinPatients(Int32.Parse(CmbGroupIdUpdate.SelectedValue.ToString()));
            DgPatientsUpdate.Refresh();

            //Group Name
            CmbGroupNameUpdate.DataSource = dtGroups;
            CmbGroupNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupNameUpdate.DisplayMember = "Name";
            CmbGroupNameUpdate.ValueMember = "GroupNumber";
            handeled = true;
            CmbGroupNameUpdate.SelectedIndex = 0;

                       
        }

        private void setGroupNumber()
        {
            ClinicTableAdapters.GroupsTableAdapter da = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dt = da.GetData();
            int number = 0;

            if (dt.Rows.Count == 0)
                txtGroupNumberAdd.Text = "1";
            else
            {
                number = dt.Rows.Count + 1;
                txtGroupNumberAdd.Text = number.ToString();
            }

                
        }

        private void BtnAddToGroupAdd_Click(object sender, EventArgs e)
        {
            int group;

            if (txtGroupNameAdd.Text == string.Empty)
            {
                MessageBox.Show("יש לבחור שם קבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();

            group = Int32.Parse(txtGroupNumberAdd.Text);
            int patient = Int32.Parse(CmblPatientIdAdd.SelectedValue.ToString());
            string patientStr = CmblPatientIdAdd.SelectedValue.ToString();
            foreach (DataGridViewRow row in DgPatientsAdd.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == patientStr)
                {
                    MessageBox.Show("מטופל כבר שייך לקבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            int index = this.DgPatientsAdd.Rows.Count;
            string fullname = daPatients.GetFullNameByID((int)CmblPatientIdAdd.SelectedValue);

            DgPatientsAdd.Rows.Add(CmblPatientIdAdd.SelectedValue, fullname);
                    DgPatientsAdd.Refresh();
        }





        private void btnSaveNewGroup_Click(object sender, EventArgs e)
        
            {
                Clinic1.ClinicTableAdapters.GroupsTableAdapter daGroups = new Clinic1.ClinicTableAdapters.GroupsTableAdapter();
                Clinic1.ClinicTableAdapters.PatientsInGroupTableAdapter daPatientsGroups = new Clinic1.ClinicTableAdapters.PatientsInGroupTableAdapter();

                if (txtGroupNameAdd.Text == string.Empty)
                    MessageBox.Show("יש להזין שם קבוצה");

                else
                {

                    Clinic.GroupsDataTable dt = daGroups.GetDataByGroupID(Int32.Parse(txtGroupNumberAdd.Text));


                    if (dt.Count == 0)
                    {
                        daGroups.Insert(txtGroupNameAdd.Text, null, null, Int32.Parse(txtGroupNumberAdd.Text));
                        foreach (DataGridViewRow row in DgPatientsAdd.Rows)
                        daPatientsGroups.Insert(Int32.Parse(row.Cells["ID"].Value.ToString()), Int32.Parse(txtGroupNumberAdd.Text));

                        MessageBox.Show("קבוצה נוצרה בהצלחה");
                    }
                    else
                        MessageBox.Show("קבוצה כבר קיימת");


                }


            
        }

        private void CmblGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clinic1.ClinicTableAdapters.PatientsTableAdapter daGroups = new Clinic1.ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dt = daGroups.GetDataByPatientIDInnerJoinPatients(Int32.Parse(CmbGroupIdUpdate.SelectedValue.ToString()));
            DgPatientsUpdate.DataSource = dt;
        }


        private void btnAddToGroupUpdate_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.PatientsInGroupTableAdapter da = new ClinicTableAdapters.PatientsInGroupTableAdapter();
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();

            int patient = Int32.Parse(cmbPatientIDUpdate.SelectedValue.ToString());
            int group = Int32.Parse(CmbGroupIdUpdate.SelectedValue.ToString());

            string patientStr = cmbPatientIDUpdate.SelectedValue.ToString();
            foreach (DataGridViewRow row in DgPatientsUpdate.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == patientStr)
                {
                    MessageBox.Show("מטופל כבר שייך לקבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            da.Insert(patient, group);
            Clinic.PatientsDataTable dt = daPatients.GetDataByPatientIDInnerJoinPatients(Int32.Parse(CmbGroupIdUpdate.SelectedValue.ToString()));
            DgPatientsUpdate.DataSource = dt;
     
        }

        private void btnRemoveFromGroup_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.PatientsInGroupTableAdapter da = new ClinicTableAdapters.PatientsInGroupTableAdapter();

            if (DgPatientsUpdate.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("האם ברצונך להסיר מהקבוצה?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int selectedrowindex = DgPatientsUpdate.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = DgPatientsUpdate.Rows[selectedrowindex];

                    string a = Convert.ToString(selectedRow.Cells["ID"].Value);
                    int ID = Int32.Parse(a);
                    int group =(int) CmbGroupIdUpdate.SelectedValue;

                    da.DeleteQuery(ID, group);
                    Clinic1.ClinicTableAdapters.PatientsTableAdapter daGroups = new Clinic1.ClinicTableAdapters.PatientsTableAdapter();
                    Clinic.PatientsDataTable dt = daGroups.GetDataByPatientIDInnerJoinPatients(Int32.Parse(CmbGroupIdUpdate.SelectedValue.ToString()));
                    DgPatientsUpdate.DataSource = dt;

                }
            }

            else
            {
                MessageBox.Show("יש לבחור מטופל להסרה מהקבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            
        }

        private void TabGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.GroupsTableAdapter da = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dt = da.GetData();
            CmbGroupNameUpdate.DataSource = dt;
            CmbGroupIdUpdate.DataSource = dt;
        }

   
    }
}
