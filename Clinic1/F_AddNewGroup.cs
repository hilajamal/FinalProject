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
    public partial class F_AddNewGroup : Form
    {
        public Boolean handeled = false;
        public F_AddNewGroup()
        {
            InitializeComponent();
            setGroupNumber();
            AddCols();
        }

        private void AddCols()
        {

        

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


            //col5.HeaderText = "פעיל";
            //col5.DataPropertyName = "Active";
            //col5.Name = "Active";
            //DgPatients.Columns.Add(col5);

            //DgPatients.Columns["FullName"].Visible = false;



        }

        private void setGroupNumber()
        {
            ClinicTableAdapters.GroupsTableAdapter da = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dt = da.GetData();
            int number = 0;

            if (dt.Rows.Count == 0)
                txtGroupNumber.Text = "1";
            else
            {
                number = dt.Rows.Count + 1;
                txtGroupNumber.Text = number.ToString();
            }

                
        }

        private void BtnAddToGroup_Click(object sender, EventArgs e)
        {
            int group;

            if (txtGroupName.Text == string.Empty)
            {
                MessageBox.Show("יש לבחור שם קבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            ClinicTableAdapters.PatientsInGroupTableAdapter da = new ClinicTableAdapters.PatientsInGroupTableAdapter();
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();

            group = Int32.Parse(txtGroupNumber.Text);
            int patient = Int32.Parse(CmblPatientId.SelectedValue.ToString());
            Clinic.PatientsInGroupDataTable dt = da.GetDataByGroupAndPatiendID(group,patient);
            if (dt.Rows.Count > 0)
                MessageBox.Show("מטופל כבר שייך לקבוצה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
                da.Insert(patient,group);

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

          private void btnSaveGroup_Click(object sender, EventArgs e)
        {
              Clinic1.ClinicTableAdapters.GroupsTableAdapter daGroups = new Clinic1.ClinicTableAdapters.GroupsTableAdapter();
               Clinic1.ClinicTableAdapters.PatientsInGroupTableAdapter daPatientsGroups = new Clinic1.ClinicTableAdapters.PatientsInGroupTableAdapter();

              if(txtGroupName.Text == string.Empty)
                  MessageBox.Show("יש להזין שם קבוצה");

              else
              {
                 
                      daGroups.Insert(txtGroupName.Text, null, null, Int32.Parse(txtGroupNumber.Text));
                      foreach (Clinic.PatientsRow row  in DgPatients.Rows)
                          daPatientsGroups.Insert(row.ID,Int32.Parse(txtGroupNumber.Text));
                     
                  MessageBox.Show("קבוצה נוצרה בהצלחה");

              }


        }
    }
}
