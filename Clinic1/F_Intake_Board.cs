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
    public partial class F_Intake_Board : Form
    {
        String dateBeforeChange;
        public F_Intake_Board()
        {
            InitializeComponent();
            addcols();
        }

        private void addcols()
        {
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetPatientsWaitingForIntakeBoard();

            CmbPatientIDUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientIDUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientIDUpdate.DisplayMember = "ID";
            CmbPatientIDUpdate.ValueMember = "ID";

            CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDateUpdate.DisplayMember = "Date";
            CmbDateUpdate.ValueMember = "Date";

            //PatientsIDAdd
            CmblPatientIdAdd.DataSource = dtPatients;
            CmblPatientIdAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientIdAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblPatientIdAdd.DisplayMember = "ID";
            CmblPatientIdAdd.ValueMember = "ID";

            //PatientsNameAdd
            CmbPatientNameAdd.DataSource = dtPatients;
            CmbPatientNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameAdd.DisplayMember = "FullName";
            CmbPatientNameAdd.ValueMember = "ID";

            // WorkersAdd
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistAdd.DataSource = dtWorkers;
            CmbMainTherapistAdd.SelectedIndex = 0;
            CmbMainTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistAdd.DisplayMember = "FullName";
            CmbMainTherapistAdd.ValueMember = "ID";

            CmbSecondTherapistAdd.DataSource = dtWorkers;
            CmbSecondTherapistAdd.SelectedIndex = 0;
            CmbSecondTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbSecondTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistAdd.DisplayMember = "FullName";
            CmbSecondTherapistAdd.ValueMember = "ID";


            Clinic.WorkersDataTable dtWorkersUpdate = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistUpdate.DataSource = dtWorkersUpdate;
            CmbMainTherapistUpdate.SelectedIndex = 0;
            CmbMainTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistUpdate.DisplayMember = "FullName";
            CmbMainTherapistUpdate.ValueMember = "ID";

            CmbSecondTherapistUpdate.DataSource = dtWorkersUpdate;
            CmbSecondTherapistUpdate.SelectedIndex = 0;
            CmbSecondTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbSecondTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistUpdate.DisplayMember = "FullName";
            CmbSecondTherapistUpdate.ValueMember = "ID";

            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetPatientsWhoDidIntakeBoard();

            //PatientsIDAdd
            CmbPatientIDUpdate.DataSource = dtPatientsUpdate;
          
            CmbPatientIDUpdate.SelectedIndex = -1;
            CmbPatientIDUpdate.SelectedIndex = 0;

            //PatientsNameAdd
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameUpdate.DisplayMember = "FullName";
            CmbPatientNameUpdate.ValueMember = "ID";

            HourPickerUpdate.ShowUpDown = true;
            HourPickerUpdate.Format = DateTimePickerFormat.Custom;
            HourPickerUpdate.CustomFormat = "HH:mm:ss";

            HourPickerAdd.ShowUpDown = true;
            HourPickerAdd.Format = DateTimePickerFormat.Custom;
            HourPickerAdd.CustomFormat = "HH:mm:ss";
        }

        private void BtnSaveAdd_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(TxtDateAdd.Text);
            DateTime now = DateTime.Now;
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            ClinicTableAdapters.IntakeBoardTableAdapter daIntake = new ClinicTableAdapters.IntakeBoardTableAdapter();
            daIntake.Insert((int)CmblPatientIdAdd.SelectedValue, (int)CmbMainTherapistAdd.SelectedValue, (int)CmbSecondTherapistAdd.SelectedValue, now, st, Txtnotes.Text, Globals.ConnectedUserID, now, null, null);
            daPatients.UpdateIntakeBoardTrue(now, (int)CmblPatientIdAdd.SelectedValue);
            MessageBox.Show("פרטים נשמרו בהצלחה");

            Clinic.PatientsDataTable dtPatients = daPatients.GetPatientsWaitingForIntakeBoard();
            CmbPatientNameAdd.DataSource = dtPatients;
            CmblPatientIdAdd.DataSource = dtPatients;

        }

        private void CmbPatientIDUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPatientIDUpdate.SelectedIndex == -1)
                return;
            ClinicTableAdapters.IntakeBoardTableAdapter da = new ClinicTableAdapters.IntakeBoardTableAdapter();
            CmbDateUpdate.DataSource = da.GetDataByPatientID((int)CmbPatientIDUpdate.SelectedValue);
        }

        private void CmbDateUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateBeforeChange = CmbDateUpdate.SelectedValue.ToString();
            ClinicTableAdapters.IntakeBoardTableAdapter da = new ClinicTableAdapters.IntakeBoardTableAdapter();
            Clinic.IntakeBoardDataTable dt = da.GetDataByPatientIDAndDate((int)CmbPatientIDUpdate.SelectedValue,(DateTime) CmbDateUpdate.SelectedValue);
            TxtnotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
            HourPickerUpdate.Text = dt.Rows[0]["Hour"].ToString();
            TxtWrittenByDateUpdate.Text = dt.Rows[0]["WrittenByDate"].ToString();
            TxtWrittenByUpdate.Text = dt.Rows[0]["WrittenBy"].ToString();
            TxtUpdatedByDateUpdate.Text = dt.Rows[0]["UpdatedByDate"].ToString();
            TxtUpdatedByUpdate.Text = dt.Rows[0]["UpdatedBy"].ToString();
            CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
            CmbSecondTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["SecondTherapist"].ToString());
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse(dateBeforeChange);
            DateTime date2 = DateTime.Parse(CmbDateUpdate.Text);

            DateTime now = DateTime.Now;
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            ClinicTableAdapters.IntakeBoardTableAdapter da = new ClinicTableAdapters.IntakeBoardTableAdapter();
            Clinic.IntakeBoardDataTable dts = da.GetDataByPatientIDAndDate((int)CmbPatientIDUpdate.SelectedValue, date1);

            da.UpdateQuery((int)CmbMainTherapistUpdate.SelectedValue, (int)CmbSecondTherapistUpdate.SelectedValue, date2, st.ToString(), TxtnotesUpdate.Text, Globals.ConnectedUserID, now, Int32.Parse(dts.Rows[0]["ID"].ToString()));
            MessageBox.Show("עדכון בוצע בהצלחה");
            int lastIndex = CmbPatientIDUpdate.SelectedIndex;
            CmbPatientIDUpdate.SelectedIndex = -1;
            CmbPatientIDUpdate.SelectedIndex = lastIndex;


        }



 
    }
}
