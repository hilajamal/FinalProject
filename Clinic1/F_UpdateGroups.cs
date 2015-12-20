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
    public partial class F_UpdateGroups : Form
    {
        public Boolean handeled = false;
        public F_UpdateGroups()
        {
            InitializeComponent();
            AddCols();
        }



        private void AddCols()
        {

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col1.HeaderText = "תעודת זהות";
            col1.DataPropertyName = "ID";
            col1.Name = "ID";
            DgPatients.Columns.Add(col1);

            col2.HeaderText = "שם מלא";
            col2.DataPropertyName = "FullName";
            col2.Name = "FullName";
            DgPatients.Columns.Add(col2);


            // Group ID
            ClinicTableAdapters.GroupsTableAdapter daGroups = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dtGroups = daGroups.GetData();
            CmblGroupId.DataSource = dtGroups;
            CmblGroupId.AutoCompleteMode = AutoCompleteMode.Append;
            CmblGroupId.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblGroupId.DisplayMember = "GroupNumber";
            CmblGroupId.ValueMember = "GroupNumber";
            handeled = true;
            CmblGroupId.SelectedIndex = 0;


            //Group Name
            CmbGroupName.DataSource = dtGroups;
            CmbGroupName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupName.DisplayMember = "Name";
            CmbGroupName.ValueMember = "GroupNumber";
            handeled = true;
            CmbGroupName.SelectedIndex = 0;


            //PatientsID
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();
            CmblPatientId.DataSource = dtPatients;
            CmblPatientId.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientId.AutoCompleteSource = AutoCompleteSource.ListItems;

            CmblPatientId.DisplayMember = "ID";
            CmblPatientId.ValueMember = "ID";
            handeled = true;
            CmblPatientId.SelectedIndex = 0;

            //PatientsName
            CmbPatientName.DataSource = dtPatients;
            CmbPatientName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientName.DisplayMember = "FullName";
            CmbPatientName.ValueMember = "ID";
            handeled = true;
            CmbPatientName.SelectedIndex = 0;

            int group;
            group = Int32.Parse(CmblGroupId.SelectedValue.ToString());
            DgPatients.DataSource = daPatients.GetDataByPatientIDInnerJoinPatients(group);
            HideDgColumns();
            DgPatients.Refresh();
        }

        private void CmblGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int group;
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();

            group = Int32.Parse(CmblGroupId.SelectedValue.ToString());

            DgPatients.DataSource = daPatients.GetDataByPatientIDInnerJoinPatients(group);
            HideDgColumns();
            DgPatients.Refresh();
        }

        private void HideDgColumns()
        {
            DgPatients.Columns["FirstName"].Visible = false;
            DgPatients.Columns["LastName"].Visible = false;
            DgPatients.Columns["FatherName"].Visible = false;
            DgPatients.Columns["MotherName"].Visible = false;
            DgPatients.Columns["BirthDay"].Visible = false;
            DgPatients.Columns["BirhtCountry"].Visible = false;
            DgPatients.Columns["Gender"].Visible = false;
            DgPatients.Columns["FamilyStatus"].Visible = false;
            DgPatients.Columns["NumberOfChildren"].Visible = false;
            DgPatients.Columns["City"].Visible = false;
            DgPatients.Columns["Street"].Visible = false;
            DgPatients.Columns["StreetNumber"].Visible = false;
            DgPatients.Columns["StreetSign"].Visible = false;
            DgPatients.Columns["Apartment"].Visible = false;
            DgPatients.Columns["ZipCode"].Visible = false;
            DgPatients.Columns["Email"].Visible = false;
            DgPatients.Columns["PhoneHome"].Visible = false;
            DgPatients.Columns["PhoneCellular"].Visible = false;
            DgPatients.Columns["PhoneWork"].Visible = false;
            DgPatients.Columns["PhoneAnother"].Visible = false;
            DgPatients.Columns["PhoneContact"].Visible = false;
            DgPatients.Columns["MainTherapist"].Visible = false;
            DgPatients.Columns["SecondTherapist"].Visible = false;
            DgPatients.Columns["RecognizedAsDisabled"].Visible = false;
            DgPatients.Columns["RecognizedAtSocialSecurity"].Visible = false;
            DgPatients.Columns["InsurenceAuthority"].Visible = false;
            DgPatients.Columns["PaymentAuthority"].Visible = false;
            DgPatients.Columns["MotherClinic"].Visible = false;


        }

        private void BtnAddToGroup_Click(object sender, EventArgs e)
        {
            int group;

        
            group = Int32.Parse(CmblGroupId.SelectedValue.ToString());
            ClinicTableAdapters.GroupsTableAdapter daGroups = new ClinicTableAdapters.GroupsTableAdapter();
          
            ClinicTableAdapters.PatientsInGroupTableAdapter da = new ClinicTableAdapters.PatientsInGroupTableAdapter();
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();

            int patient = Int32.Parse(CmblPatientId.SelectedValue.ToString());
            Clinic.PatientsInGroupDataTable dt = da.GetDataByGroupAndPatiendID(group, patient);
            if (dt.Rows.Count > 0)
                MessageBox.Show("מטופל כבר שייך לקבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
                da.Insert(patient, group, 0, 0);

            DgPatients.DataSource = daPatients.GetDataByPatientIDInnerJoinPatients(group);
            HideDgColumns();
            DgPatients.Refresh();


        }

   
    }
}
