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
    public partial class F_Intake_Board : Form
    {
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
            if (CmblPatientIdAdd.Items.Count > 0)
            {
                CmblPatientIdAdd.SelectedIndex = -1;
                CmblPatientIdAdd.SelectedIndex = 0;
            }

            //PatientsNameAdd
            CmbPatientNameAdd.DataSource = dtPatients;
            CmbPatientNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameAdd.DisplayMember = "FullName";
            CmbPatientNameAdd.ValueMember = "ID";

            // WorkersAdd
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            CmbMainTherapistAdd.DataSource = daWorkers.GetDataByActiveWorkers(); ;
            CmbMainTherapistAdd.SelectedIndex = 0;
            CmbMainTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistAdd.DisplayMember = "FullName";
            CmbMainTherapistAdd.ValueMember = "ID";

            CmbSecondTherapistAdd.DataSource = daWorkers.GetDataByActiveWorkers();
            CmbSecondTherapistAdd.SelectedIndex = 0;
            CmbSecondTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbSecondTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistAdd.DisplayMember = "FullName";
            CmbSecondTherapistAdd.ValueMember = "ID";


            Clinic.WorkersDataTable dtWorkersUpdate = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistUpdate.DataSource = dtWorkersUpdate;
            CmbMainTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistUpdate.DisplayMember = "FullName";
            CmbMainTherapistUpdate.ValueMember = "ID";

            CmbSecondTherapistUpdate.DataSource = daWorkers.GetDataByActiveWorkers(); ;
            CmbSecondTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbSecondTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistUpdate.DisplayMember = "FullName";
            CmbSecondTherapistUpdate.ValueMember = "ID";

            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetPatientsWhoDidIntakeBoard();

            //PatientsIDAdd
            CmbPatientIDUpdate.DataSource = dtPatientsUpdate;
          
            if (CmbPatientIDUpdate.Items.Count > 0)
            {
                CmbPatientIDUpdate.SelectedIndex = -1;
                CmbPatientIDUpdate.SelectedIndex = 0;
            }

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
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(this.TxtDateAdd.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }
            
            DateTime now = DateTime.Now;
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            ClinicTableAdapters.IntakeBoardTableAdapter daIntake = new ClinicTableAdapters.IntakeBoardTableAdapter();
            daIntake.Insert((int)CmblPatientIdAdd.SelectedValue, (int)CmbMainTherapistAdd.SelectedValue, (int)CmbSecondTherapistAdd.SelectedValue, rs, st, Txtnotes.Text, Globals.ConnectedUserID, now, null, null);
            daPatients.UpdateIntakeBoardTrue(now, (int)CmblPatientIdAdd.SelectedValue);
            MessageBox.Show("פרטים נשמרו בהצלחה");

            Clinic.PatientsDataTable dtPatients = daPatients.GetPatientsWaitingForIntakeBoard();
            CmbPatientNameAdd.DataSource = dtPatients;
            CmblPatientIdAdd.DataSource = dtPatients;
            Txtnotes.Text = String.Empty;


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
            DateTime d = (DateTime)CmbDateUpdate.SelectedValue;
            TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {

            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(TxtDateUpdate.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }


            DateTime now = DateTime.Now;
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            ClinicTableAdapters.IntakeBoardTableAdapter da = new ClinicTableAdapters.IntakeBoardTableAdapter();
            Clinic.IntakeBoardDataTable dts = da.GetDataByPatientIDAndDate((int)CmbPatientIDUpdate.SelectedValue, (DateTime)CmbDateUpdate.SelectedValue);

            da.UpdateQuery((int)CmbMainTherapistUpdate.SelectedValue, (int)CmbSecondTherapistUpdate.SelectedValue, rs, st.ToString(), TxtnotesUpdate.Text, Globals.ConnectedUserID, now, Int32.Parse(dts.Rows[0]["ID"].ToString()));
            MessageBox.Show("עדכון בוצע בהצלחה");
            int lastIndex = CmbPatientIDUpdate.SelectedIndex;
            CmbPatientIDUpdate.SelectedIndex = -1;
            CmbPatientIDUpdate.SelectedIndex = lastIndex;


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetPatientsWhoDidIntakeBoard();
            CmbPatientIDUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            Txtnotes.Text = String.Empty;
        }

        private void CmblPatientIdAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtWrittenByAdd.Text = Globals.ConnectedUserName;
            TxtWrittenByDateAdd.Text = DateTime.Now.ToString();
            TxtIntakeBoardLeft.Text = CmblPatientIdAdd.Items.Count.ToString();
         
        }



 
    }
}
