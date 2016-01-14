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
    public partial class F_Meetings : Form
    {
        public F_Meetings()
        {
            InitializeComponent();
            addCols();

        }

        public void addCols()
        {
            tabControl1.SelectedIndex = 1;
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();

            CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDateUpdate.DisplayMember = "Date";
            CmbDateUpdate.ValueMember = "Date";


            HourPickerAdd.ShowUpDown = true;
            HourPickerAdd.Format = DateTimePickerFormat.Custom;
            HourPickerAdd.CustomFormat = "HH:mm:ss";

            HourPickerUpdate.ShowUpDown = true;
            HourPickerUpdate.Format = DateTimePickerFormat.Custom;
            HourPickerUpdate.CustomFormat = "HH:mm:ss";

            TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            TxtWrittenByAdd.Text = Globals.ConnectedUserName;

            //PatientsIDAdd
            CmblPatientIdAdd.DataSource = dtPatients;
            CmblPatientIdAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientIdAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblPatientIdAdd.DisplayMember = "ID";
            CmblPatientIdAdd.ValueMember = "ID";
            CmblPatientIdAdd.SelectedIndex = 0;

            //PatientsNameAdd
            CmbPatientNameAdd.DataSource = dtPatients;
            CmbPatientNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameAdd.DisplayMember = "FullName";
            CmbPatientNameAdd.ValueMember = "ID";
            CmbPatientNameAdd.SelectedIndex = 0;


            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(3);
            //PatientsIDUpdate
            CmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            CmbPatientIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientIdUpdate.DisplayMember = "ID";
            CmbPatientIdUpdate.ValueMember = "ID";
            CmbPatientIdUpdate.SelectedIndex = 0;

            //PatientsNameUpdate
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameUpdate.DisplayMember = "FullName";
            CmbPatientNameUpdate.ValueMember = "ID";
            CmbPatientNameUpdate.SelectedIndex = 0;



            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistAdd.DataSource = dtWorkers;
            CmbMainTherapistAdd.SelectedIndex = 0;
            CmbMainTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistAdd.DisplayMember = "FullName";
            CmbMainTherapistAdd.ValueMember = "ID";

            CmbMainTherapistUpdate.DataSource = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistUpdate.SelectedIndex = 0;
            CmbMainTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistUpdate.DisplayMember = "FullName";
            CmbMainTherapistUpdate.ValueMember = "ID";



            ClinicTableAdapters.AppointmentsTableAdapter daAp = new ClinicTableAdapters.AppointmentsTableAdapter();
            if (daAp.GetMaxAppointmentNumber((int)CmblPatientIdAdd.SelectedValue) == null)
                TxtMeetingNumber.Text = "1";
            else
                TxtMeetingNumber.Text = (daAp.GetMaxAppointmentNumber((int)CmblPatientIdAdd.SelectedValue) + 1).ToString();
            

        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
             DateTime date = DateTime.Parse(TxtDateUpdate.Text);
             DateTime now = DateTime.Now;

            int Number;
            if (da.GetMaxAppointmentNumber((int)CmblPatientIdAdd.SelectedValue) == null)
                Number = 1;
            else
                Number = (Int32.Parse(da.GetMaxAppointmentNumber((int)CmblPatientIdAdd.SelectedValue).ToString())) + 1;
            Clinic.AppointmentsDataTable dtToAdd = da.GetDataByAppointmentTypeDatePatientID((int)CmbPatientIdUpdate.SelectedValue,(DateTime) CmbDateUpdate.SelectedValue, 3);

            da.UpdateQuery(Number, null, 3, DateTime.Now, st.ToString(), (int)CmbMainTherapistUpdate.SelectedValue, null, TxtnotesUpdate.Text, null, Globals.ConnectedUserID, now, null, null, null, null, null, null, null, null, null, Int32.Parse(dtToAdd.Rows[0]["ID"].ToString()));
            MessageBox.Show("טיפול עודכן בהצלחה");


        }

        private void BtnSaveAdd_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(TxtDateAdd.Text);
            DateTime now = DateTime.Now;
            DateTime dt = HourPickerAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();

            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            int id = Int32.Parse(da.InsertQuery(Int32.Parse(TxtMeetingNumber.Text), null, 3, date, st.ToString(), (int)CmbMainTherapistAdd.SelectedValue, null, Txtnotes.Text, null, Globals.ConnectedUserID, null,
                now, null, null, null, null, null, null, null, null, null, null).ToString());
            daAPA.Insert(id, 3, (int)CmblPatientIdAdd.SelectedValue, true);
            MessageBox.Show("טיפול נוצר בהצלחה");
        }

        private void CmbPatientNameUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();

        if (CmbPatientIdUpdate.SelectedIndex == -1)
            return;

            CmbDateUpdate.DataSource = da.GetDataByAppointmentTypeAndPatientID((3),(int)CmbPatientIdUpdate.SelectedValue);
        }

        private void CmbDateUpdate_SelectedValueChanged(object sender, EventArgs e)
        {

            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();

            if (CmbPatientIdUpdate.SelectedIndex == -1)
                return;


            if (CmbDateUpdate.Items.Count > 0)
            {
                if (CmbDateUpdate.Items.Count == 0)
                    return;
                ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
                Clinic.AppointmentsDataTable dt = da.GetDataByAppointmentTypeDatePatientID((int)CmbPatientIdUpdate.SelectedValue, (DateTime)CmbDateUpdate.SelectedValue, 3);
                TxtnotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
                TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
                TxtWrittenByDateUpdate.Text = dt.Rows[0]["Date"].ToString();
                DateTime d = (DateTime)dt.Rows[0]["Date"];
                TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
                HourPickerUpdate.Text = dt.Rows[0]["Hour"].ToString();

                CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
                DateTime Dates = new DateTime();
                //HourPickerUpdate.va
                if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
                {
                    Dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
                    TxtUpdatedByDateUpdate.Text = Dates.ToString("dd/MM/yyyy");

                }
                if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
                {
                    TxtUpdatedByUpdate.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

                }




            }



        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(3);
            CmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientIdUpdate.SelectedIndex = -1;
            CmbPatientIdUpdate.SelectedIndex = 0;



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(3);
            CmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientIdUpdate.SelectedIndex = -1;
            CmbPatientIdUpdate.SelectedIndex = 0;
        }
    }
}
