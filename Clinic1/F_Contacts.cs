using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Clinic1
{
    public partial class F_Contacts : Form
    {
        public int OriginalID;

        public F_Contacts()
        {
            InitializeComponent();
            setComboBox();
        }


        public void setComboBox()
        {
            CmbHourUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbHourUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbHourUpdate.DisplayMember = "Hour";
            CmbHourUpdate.ValueMember = "Hour";

            CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDateUpdate.DisplayMember = "Date";
            CmbDateUpdate.ValueMember = "Date";

            CmbWorker.AutoCompleteMode = AutoCompleteMode.Append;
            CmbWorker.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbWorker.DisplayMember = "FullName";
            CmbWorker.ValueMember = "ID";


            CmbWorkerUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbWorkerUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbWorkerUpdate.DisplayMember = "FullName";
            CmbWorkerUpdate.ValueMember = "ID";

            CmbPatientName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientName.DisplayMember = "FullName";
            CmbPatientName.ValueMember = "ID";

            CmblPatientId.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientId.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblPatientId.DisplayMember = "ID";
            CmblPatientId.ValueMember = "ID";

            CmbPatientIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientIdUpdate.DisplayMember = "ID";
            CmbPatientIdUpdate.ValueMember = "ID";

            CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameUpdate.DisplayMember = "FullName";
            CmbPatientNameUpdate.ValueMember = "ID";

            // Workers
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbWorker.DataSource = dtWorkers;
            CmbWorkerUpdate.DataSource = daWorkers.GetDataByActiveWorkers();

            //PatientsIDAdd
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();
            CmblPatientId.DataSource = dtPatients;


            //PatientsNameAdd
            CmbPatientName.DataSource = dtPatients;
            CmblPatientId.SelectedIndex = 0;


            //PatientsIDUpdate
            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByPatientsWithContacts();

            CmbPatientIdUpdate.DataSource = dtPatientsUpdate;

            //PatientsNameUpdate
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;

            HourPickerAdd.Format = DateTimePickerFormat.Time;
            HourPickerAdd.ShowUpDown = true;
            HourPickerAdd.CustomFormat = "HH:mm:ss";



            //HourPickerUpdate.Format = DateTimePickerFormat.Time;
            //HourPickerUpdate.ShowUpDown = true;
            //HourPickerUpdate.CustomFormat = "HH:mm:ss";
        }



        private void BtnExitNoSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(this.TxtDateAdd.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }


            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            da.Insert(TxtContactTypeAdd.Text, Int32.Parse(CmblPatientId.SelectedValue.ToString()), Int32.Parse(CmbWorker.SelectedValue.ToString()), TxtContactName.Text, TxtRelationAdd.Text, TxtContents.Text, TxtRemarks.Text, rs, st);
            MessageBox.Show("פרטים נשמרו בהצלחה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void CmbPatientIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            CmbDateUpdate.DataSource = da.GetDataByPatientID((int)CmbPatientIdUpdate.SelectedValue);
        }

        private void CmbDateUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            CmbHourUpdate.DataSource = da.GetDataByPatientIDandDate((int)CmbPatientIdUpdate.SelectedValue, CmbDateUpdate.SelectedValue.ToString());
        }

        private void CmbHourUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {


            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            Clinic.ContactsDataTable dt = da.GetDataByPatientIDAndDateAndHour((int)CmbPatientIdUpdate.SelectedValue, CmbDateUpdate.SelectedValue.ToString(),CmbHourUpdate.SelectedValue.ToString());
            TxtContentsUpdate.Text = dt.Rows[0]["Contents"].ToString();
            TxtRemarksUpdate.Text = dt.Rows[0]["Remarks"].ToString();
            TxtRelationUpdate.Text = dt.Rows[0]["Relationship"].ToString();
            TxtContentsUpdate.Text = dt.Rows[0]["Contents"].ToString();
            TxtContactNameUpdate.Text = dt.Rows[0]["ContactName"].ToString();
            CmbWorkerUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["WorkerID"].ToString());
            TxtContactTypeUpdate.Text = dt.Rows[0]["ContactType"].ToString();
            OriginalID = Int32.Parse(dt.Rows[0]["ID"].ToString());

        }

        private void BtnExitNoSaveUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExitNoSave_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {

            ClinicTableAdapters.ContactsTableAdapter da = new ClinicTableAdapters.ContactsTableAdapter();
            DateTime date = DateTime.Parse(CmbDateUpdate.Text);
            DateTime now = DateTime.Now;
            TimeSpan ds = (TimeSpan)CmbHourUpdate.SelectedValue;
            //TimeSpan st = new TimeSpan(ds.Hour, ds.Minute, ds.Second);
            da.UpdateQuery(TxtContactTypeUpdate.Text, (int)CmbPatientIdUpdate.SelectedValue, (int)CmbWorker.SelectedValue, TxtContactNameUpdate.Text, TxtRelationUpdate.Text, TxtContentsUpdate.Text, TxtRemarksUpdate.Text, date.ToString(), ds.ToString().ToString(), OriginalID);
            MessageBox.Show("עדכון בוצע בהצלחה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

 






    }
}
