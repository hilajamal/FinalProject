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
        Clinic.DiagnosesForPatientsDataTable dtDiagnoseForPatients;
        Clinic.DiagnosesForPatientsDataTable dtDiagnoseForPatientsAdd;

        public F_Intake()
        {
            InitializeComponent();
            addCols();
        }

        public void addCols()
        {
            DgDiagnosesUpdate.AutoGenerateColumns = false;
            TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            TxtWrittenByAdd.Text = Globals.ConnectedUserName;
             HourPickerStartAdd.ShowUpDown = true;
            HourPickerStartAdd.Format = DateTimePickerFormat.Custom;
            HourPickerStartAdd.CustomFormat = "HH:mm:ss";

            TxtHourUpdate.ShowUpDown = true;
            TxtHourUpdate.Format = DateTimePickerFormat.Custom;
            TxtHourUpdate.CustomFormat = "HH:mm:ss";

            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();
           
            //PatientsIDAdd
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

            //PatientsIDUpdate
            ClinicTableAdapters.PatientsTableAdapter daPatientsUpdate = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatientsUpdate = daPatientsUpdate.GetDataByPatientsWithIntake();
            cmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            cmbPatientIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            cmbPatientIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatientIdUpdate.DisplayMember = "ID";
            cmbPatientIdUpdate.ValueMember = "ID";
            cmbPatientIdUpdate.SelectedIndex = 0;

            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();


            //PatientsNameUpdate
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameUpdate.DisplayMember = "FullName";
            CmbPatientNameUpdate.ValueMember = "ID";
            CmbPatientNameUpdate.SelectedIndex = 0;


            // WorkersAdd
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
            CmbTherapist.DataSource = dtWorkers;
            CmbTherapist.SelectedIndex = 0;
            CmbTherapist.AutoCompleteMode = AutoCompleteMode.Append;
            CmbTherapist.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbTherapist.DisplayMember = "FullName";
            CmbTherapist.ValueMember = "ID";

            // WorkersUpdate
            Clinic.WorkersDataTable dtWorkersUpdate = daWorkers.GetDataByActiveWorkers();
            CmbMainTherapistUpdate.DataSource = dtWorkersUpdate;
            CmbMainTherapistUpdate.SelectedIndex = 0;
            CmbMainTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMainTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistUpdate.DisplayMember = "FullName";
            CmbMainTherapistUpdate.ValueMember = "ID";

            //IntakeNumberUpdate
            CmbIntakeNumber.AutoCompleteMode = AutoCompleteMode.Append;
            CmbIntakeNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbIntakeNumber.DisplayMember = "AppointmentNumber";
            CmbIntakeNumber.ValueMember = "AppointmentNumber";
            CmbIntakeNumber.SelectedIndex = -1;
            CmbIntakeNumber.SelectedIndex = 0;



            // DiagnosesAdd
            ClinicTableAdapters.DiagnoseTableAdapter daDiagnose = new ClinicTableAdapters.DiagnoseTableAdapter();
            Clinic.DiagnoseDataTable dt = daDiagnose.GetData();
            CmbDiagnoseCode.DataSource = dt;
            CmbDiagnoseCode.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseCode.DisplayMember = "ID";
            CmbDiagnoseCode.ValueMember = "ID";

            CmbDiagnoseName.DataSource = dt;
            CmbDiagnoseName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseName.DisplayMember = "Name";
            CmbDiagnoseName.ValueMember = "Name";

            Clinic.DiagnoseDataTable dt2 = daDiagnose.GetData();
            CmbDiagnoseCodeUpdate.DataSource = dt2;
            CmbDiagnoseCodeUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseCodeUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseCodeUpdate.DisplayMember = "ID";
            CmbDiagnoseCodeUpdate.ValueMember = "ID";

            CmbDiagnoseNameUpdate.DataSource = dt2;
            CmbDiagnoseNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDiagnoseNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDiagnoseNameUpdate.DisplayMember = "Name";
            CmbDiagnoseNameUpdate.ValueMember = "Name";

           ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            DgDiagnoses.AutoGenerateColumns = false;
            col1.HeaderText = "קוד";
            col1.DataPropertyName = "ID";
            col1.Name = "ID";
            DgDiagnoses.Columns.Add(col1);

            col2.HeaderText = "שם אבחנה";
            col2.DataPropertyName = "Name";
            col2.Name = "Name";
            DgDiagnoses.Columns.Add(col2);


            col3.HeaderText = "תאריך התחלה";
            col3.DataPropertyName = "StartDate";
            col3.Name = "StartDate";
            DgDiagnoses.Columns.Add(col3);

            dtDiagnoseForPatientsAdd = daD.GetDataByPatientID((int)CmblPatientId.SelectedValue);
            DgDiagnoses.DataSource = dtDiagnoseForPatientsAdd;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();

            DgDiagnosesUpdate.AutoGenerateColumns = false;
            col4.HeaderText = "קוד";
            col4.DataPropertyName = "ID";
            col4.Name = "ID";
            DgDiagnosesUpdate.Columns.Add(col4);

            col5.HeaderText = "שם אבחנה";
            col5.DataPropertyName = "Name";
            col5.Name = "Name";
            DgDiagnosesUpdate.Columns.Add(col5);


            col6.HeaderText = "תאריך התחלה";
            col6.DataPropertyName = "StartDate";
            col6.Name = "StartDate";
            DgDiagnosesUpdate.Columns.Add(col6);

            dtDiagnoseForPatientsAdd = daD.GetDataByPatientID((int)CmblPatientId.SelectedValue);
            DgDiagnosesUpdate.DataSource = dtDiagnoseForPatients;
            DgDiagnoses.DataSource = dtDiagnoseForPatientsAdd;
        }


        private void BtnSaveIntake_Click(object sender, EventArgs e)
        {
            int apNumber;
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            if (da.GetMaxAppointment(1,(int)CmblPatientId.SelectedValue) == null)
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
         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagnose = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         string formatted = now.ToString("dd/MM/yyyy");
         DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

         daDiagnose.Update(dtDiagnoseForPatientsAdd);

         MessageBox.Show("טיפול נוסף בהצלחה");

        }

        private void BtnAddDiagnose_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnosesForPatientsTableAdapter da = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();

           String code = CmbDiagnoseCode.SelectedValue.ToString();
            foreach (DataGridViewRow row in DgDiagnoses.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == code)
                {
                    MessageBox.Show("אבחנה כבר קיימת למטופל", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            DateTime now = DateTime.Now;
            string formatted = now.ToString("dd/MM/yyyy");
            DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Clinic.DiagnosesForPatientsRow newRow = dtDiagnoseForPatientsAdd.NewDiagnosesForPatientsRow();
            newRow["ID"] = CmbDiagnoseCode.SelectedValue.ToString();
            newRow["Name"] = CmbDiagnoseName.SelectedValue.ToString();
            newRow["DiagnoseCode"] = CmbDiagnoseCode.SelectedValue.ToString();
            newRow["PatientID"] = (int)CmblPatientId.SelectedValue;
            newRow["StartDate"] = dateToAdd;
            dtDiagnoseForPatientsAdd.AddDiagnosesForPatientsRow(newRow);
            DgDiagnoses.Refresh();
        }



        private void BtnAddDiagnoseUpdate_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnosesForPatientsTableAdapter da = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();

            String code = CmbDiagnoseCodeUpdate.SelectedValue.ToString();
            foreach (DataGridViewRow row in DgDiagnosesUpdate.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == code)
                {
                    MessageBox.Show("אבחנה כבר קיימת למטופל", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            DateTime now = DateTime.Now;
            string formatted = now.ToString("dd/MM/yyyy");
            DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Clinic.DiagnosesForPatientsRow newRow = dtDiagnoseForPatients.NewDiagnosesForPatientsRow();
            newRow["ID"] = CmbDiagnoseCodeUpdate.SelectedValue.ToString();
            newRow["Name"] = CmbDiagnoseNameUpdate.SelectedValue.ToString();
            newRow["DiagnoseCode"] = CmbDiagnoseCodeUpdate.SelectedValue.ToString();
            newRow["PatientID"] = (int)cmbPatientIdUpdate.SelectedValue;
            newRow["StartDate"] = dateToAdd;
            dtDiagnoseForPatients.AddDiagnosesForPatientsRow(newRow);
            DgDiagnosesUpdate.Refresh();

        }


        private void comPatientIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void CmbPatientNameUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter da = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            Clinic.AppointmentsForPatientsDataTable dt = da.GetIntakeNumbersByPatientID((int)cmbPatientIdUpdate.SelectedValue);
            if (dt.Rows.Count > 0)
                CmbIntakeNumber.DataSource = dt;
            else
                CmbIntakeNumber.DataSource = null;
        }

        private void CmbIntakeNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbIntakeNumber.SelectedIndex == -1)
                return;

            if (CmbIntakeNumber.Items.Count == 0)
                clearAllFields();
            else
            {
                ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagsnoses = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter(); 
                DateTime now = DateTime.Now;
                String date = now.ToString("dd/MM/yyyy HH:mm:ss");
                ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
                Clinic.AppointmentsDataTable dt = da.GetDataByPatientIDAndAppointmentNumberAndAppointmentTypeID((int)CmbIntakeNumber.SelectedValue, (int)cmbPatientIdUpdate.SelectedValue, 1);
                ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
                TxtBrothersAndSistersUpdate.Text = dt.Rows[0]["BrothersAndSisters"].ToString();
                TxtFamilyUpdate.Text = dt.Rows[0]["Family"].ToString();
                TxtReasonUpdate.Text = dt.Rows[0]["Reason"].ToString();
                TxtPhysicalUpdate.Text = dt.Rows[0]["Physical"].ToString();
                TxtSocialUpdate.Text = dt.Rows[0]["Social"].ToString();
                TxtSentByUpdate.Text = dt.Rows[0]["SentBy"].ToString();
                TxtTraumasUpdate.Text = dt.Rows[0]["Traumas"].ToString();
                TxtPregnantUpdate.Text = dt.Rows[0]["Pregnant"].ToString();
                TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
                TxtWrittenByDateUpdate.Text = dt.Rows[0]["AddedByDate"].ToString();
                TxtUpdatedByDateUpdate.Text = dt.Rows[0]["UpdatedByDate"].ToString();
                TxtHourUpdate.Text = dt.Rows[0]["Hour"].ToString();
                TxtNotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
                TxtPsychoUpdate.Text = dt.Rows[0]["Psycho"].ToString();
                CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
                dtDiagnoseForPatients =  daDiagsnoses.GetDataByPatientID((int)cmbPatientIdUpdate.SelectedValue);
                DgDiagnosesUpdate.DataSource = dtDiagnoseForPatients;
                DateTime dates = (DateTime) dt.Rows[0]["Date"];
                TxtDateUpdate.Text = dates.ToString("dd/MM/yyyy");
                if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
                {
                    dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
                    TxtUpdatedByDateUpdate.Text = dates.ToString("dd/MM/yyyy");

                }
                if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
                {
                    TxtUpdatedByUpdate.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

                }


            }
        }

        public void clearAllFields()
        {
            TxtBrothersAndSistersUpdate.Text = String.Empty;
            TxtFamilyUpdate.Text = String.Empty;
            TxtPhysicalUpdate.Text = String.Empty;
            TxtSocialUpdate.Text = String.Empty;
            TxtSentByUpdate.Text = String.Empty;
            TxtTraumasUpdate.Text = String.Empty;
            TxtFamilyUpdate.Text = String.Empty;
            TxtPregnantUpdate.Text = String.Empty;
            TxtReasonUpdate.Text = String.Empty;
            TxtUpdatedByUpdate.Text = String.Empty;
            TxtWrittenByUpdate.Text = String.Empty;
            TxtWrittenByDateUpdate.Text = String.Empty;
            TxtUpdatedByDateUpdate.Text = String.Empty;
            TxtHourUpdate.Text = String.Empty;
            TxtNotesUpdate.Text = String.Empty;
            TxtPhysicalUpdate.Text = String.Empty;
        }

        private void BtnRemoveDiagnose_Click(object sender, EventArgs e)
        {
            if (DgDiagnosesUpdate.SelectedRows == null) { 
                MessageBox.Show("יש לבחור אבחנה להסרה", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                ClinicTableAdapters.DiagnosesForPatientsTableAdapter da = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();

                if (DgDiagnosesUpdate.SelectedCells.Count > 0)
                {
                    if (MessageBox.Show("האם ברצונך להסיר אבחנה?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int selectedrowindex = DgDiagnosesUpdate.SelectedCells[0].RowIndex;

                        DataGridViewRow selectedRow = DgDiagnosesUpdate.Rows[selectedrowindex];
                        DgDiagnosesUpdate.Rows.RemoveAt(selectedrowindex);

                    }
                }

            }
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
            DateTime date = DateTime.Parse(TxtDateUpdate.Text);


            da.UpdateQuery((int)CmbIntakeNumber.SelectedValue, null, 1, date, TxtHourUpdate.Text, (int)CmbMainTherapistUpdate.SelectedValue, null, TxtNotesUpdate.Text, null, Globals.ConnectedUserID, DateTime.Now, TxtSentByUpdate.Text,
                TxtReasonUpdate.Text, TxtBrothersAndSistersUpdate.Text, TxtFamilyUpdate.Text, TxtTraumasUpdate.Text, TxtPregnant.Text, TxtPsychoUpdate.Text, TxtPhysicalUpdate.Text, TxtSocialUpdate.Text, (int)cmbPatientIdUpdate.SelectedValue);
            daD.Update(dtDiagnoseForPatients);
            MessageBox.Show("טיפול עודכן בהצלחה");


        }

 

        private void CmblPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
            dtDiagnoseForPatientsAdd = daD.GetDataByPatientID((int)CmblPatientId.SelectedValue);
            DgDiagnoses.DataSource = dtDiagnoseForPatientsAdd;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 1)
            //{
            //    ClinicTableAdapters.PatientsTableAdapter daPatientsUpdate = new ClinicTableAdapters.PatientsTableAdapter();
            //    Clinic.PatientsDataTable dtPatientsUpdate = daPatientsUpdate.GetDataByPatientsWithIntake();
            //    cmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            //    CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            //}
        }

     
    }
}
