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
    public partial class F_Intake : Form
    {
        public F_Intake()
        {
            InitializeComponent();
            addCols();
        }

        public void addCols()
        {

            TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            TxtWrittenByAdd.Text = Globals.ConnectedUserName;
             HourPickerStartAdd.ShowUpDown = true;
            HourPickerStartAdd.Format = DateTimePickerFormat.Custom;
            HourPickerStartAdd.CustomFormat = "HH:mm:ss";

            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
    Clinic.PatientsDataTable dtPatients = daPatients.GetData();
            CmblPatientId.DataSource = dtPatients;
            CmblPatientId.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientId.AutoCompleteSource = AutoCompleteSource.ListItems;

            CmblPatientId.DisplayMember = "ID";
            CmblPatientId.ValueMember = "ID";
            CmblPatientId.SelectedIndex = 0;

            //PatientsNameAdd
            CmbPatientName.DataSource = dtPatients;
            CmbPatientName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientName.DisplayMember = "FullName";
            CmbPatientName.ValueMember = "ID";
            CmbPatientName.SelectedIndex = 0;

            // Workers
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbTherapist.DataSource = dtWorkers;
            CmbTherapist.SelectedIndex = 0;
            CmbTherapist.AutoCompleteMode = AutoCompleteMode.Append;
            CmbTherapist.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbTherapist.DisplayMember = "FullName";
            CmbTherapist.ValueMember = "ID";


            // Workers
            ClinicTableAdapters.DiagnoseTableAdapter daDiagnose = new ClinicTableAdapters.DiagnoseTableAdapter();
            Clinic.DiagnoseDataTable dt = daDiagnose.GetData();
            CmbDiagnoseCode.DataSource = daDiagnose.GetData();
            CmbDiagnoseCode.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseCode.DisplayMember = "ID";
            CmbDiagnoseCode.ValueMember = "ID";

            CmbDiagnoseName.DataSource = daDiagnose.GetData();
            CmbDiagnoseName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseName.DisplayMember = "Name";
            CmbDiagnoseName.ValueMember = "ID";
        }

        private void BtnSaveIntake_Click(object sender, EventArgs e)
        {
            int apNumber;
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            if ((int) da.GetMaxAppointment(1,(int)CmblPatientId.SelectedValue) == 0)
                apNumber = 1;
            else apNumber =(int) da.GetMaxAppointment(1,(int)CmblPatientId.SelectedValue)+1;
            DateTime date = DateTime.Parse(TxtDate.Text);
            DateTime now = DateTime.Now;

            DateTime dt = HourPickerStartAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

         int id = Int32.Parse(da.InsertQuery(apNumber, null, 1, date, st.ToString(), (int)CmbTherapist.SelectedValue, null, TxtNotes.Text, null, Globals.ConnectedUserID, null, now,
                null, TxtSentBy.Text, TxtReason.Text, TxtBrothersAndSisters.Text, TxtFamily.Text, TxtTraumas.Text, TxtPregnant.Text, TxtPsycho.Text,
                TxtSocial.Text, TxtPhysical.Text).ToString());
         ClinicTableAdapters.AppointmentsForPatientsTableAdapter app = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
         app.Insert(id, 1, (int)CmblPatientId.SelectedValue, true);
         MessageBox.Show("טיפול נוסף בהצלחה");

        }

    }
}
