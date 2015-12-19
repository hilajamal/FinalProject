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
    public partial class F_Contacts : Form
    {
        public Boolean handeled = false;




        public F_Contacts()
        {
            InitializeComponent();
            setComboBox();
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

            // Relations
            ClinicTableAdapters.RelationsTableAdapter daRelations = new ClinicTableAdapters.RelationsTableAdapter();
            Clinic.RelationsDataTable dtRelations = daRelations.GetData();
            CmbRelationship.DataSource = dtRelations;
            CmbRelationship.SelectedIndex = 0;
            CmbRelationship.AutoCompleteMode = AutoCompleteMode.Append;
            CmbRelationship.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbRelationship.DisplayMember = "Name";
            CmbRelationship.ValueMember = "ID";

            // Contact Type
            ClinicTableAdapters.ContactsTypeTableAdapter daContactsType = new ClinicTableAdapters.ContactsTypeTableAdapter();
            Clinic.ContactsTypeDataTable dtContactsType = daContactsType.GetData();
            CmbContactType.DataSource = dtContactsType;
            CmbContactType.SelectedIndex = 0;
            CmbContactType.AutoCompleteMode = AutoCompleteMode.Append;
            CmbContactType.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbContactType.DisplayMember = "Name";
            CmbContactType.ValueMember = "ID";

            HourPicker.Format = DateTimePickerFormat.Time;
            HourPicker.ShowUpDown = true;
            HourPicker.CustomFormat = "HH:mm";
    }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String hour = HourPicker.Value.ToString("HH:mm");
            DateTime hours = DateTime.ParseExact(hour, "HH:mm",System.Globalization.CultureInfo.InvariantCulture);

            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            da.Insert(Int32.Parse(CmbContactType.SelectedValue.ToString()), Int32.Parse(CmblPatientId.SelectedValue.ToString()), Int32.Parse(CmbWorker.SelectedValue.ToString()), TxtContactFirstName.Text, TxtContactLastName.Text, TxtContactPersonType.Text, Int32.Parse(CmbRelationship.SelectedValue.ToString()), TxtContents.Text, TxtRemarks.Text, Calendar.SelectionRange.Start,hours);
            this.Close();
        }

   
      }
}
