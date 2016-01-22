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
            CmblPatientId.AutoCompleteMode = AutoCompleteMode.Append;
            CmblPatientId.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmblPatientId.DisplayMember = "ID";
            CmblPatientId.ValueMember = "ID";

            CmbAppointmenrNumber.AutoCompleteMode = AutoCompleteMode.Append;
            CmbAppointmenrNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbAppointmenrNumber.DisplayMember = "AppointmentNumber";
            CmbAppointmenrNumber.ValueMember = "AppointmentNumber";

            DgDiagnosesUpdate.AutoGenerateColumns = false;
            DgDiagnoses.AutoGenerateColumns = false;

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



            CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDateUpdate.DisplayMember = "Date";
            CmbDateUpdate.ValueMember = "Date";

            //PatientsIDAdd
            CmblPatientId.DataSource = dtPatients;
      

            //PatientsNameAdd
            CmbPatientName.DataSource = dtPatients;
            CmbPatientName.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientName.DisplayMember = "FullName";
            CmbPatientName.ValueMember = "ID";
            CmbPatientName.SelectedIndex = 0;

            //PatientsIDUpdate
            ClinicTableAdapters.PatientsTableAdapter daPatientsUpdate = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatientsUpdate = daPatientsUpdate.GetDataByAppointmentTypeID(1);
            cmbPatientIdUpdate.DataSource = dtPatientsUpdate;
            cmbPatientIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            cmbPatientIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatientIdUpdate.DisplayMember = "ID";
            cmbPatientIdUpdate.ValueMember = "ID";

            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();


            //PatientsNameUpdate
            CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
            CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientNameUpdate.DisplayMember = "FullName";
            CmbPatientNameUpdate.ValueMember = "ID";


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
            //CmbIntakeNumber.AutoCompleteMode = AutoCompleteMode.Append;
            //CmbIntakeNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
            //CmbIntakeNumber.DisplayMember = "AppointmentNumber";
            //CmbIntakeNumber.ValueMember = "AppointmentNumber";
            //if (CmbIntakeNumber.Items.Count > 0)
            //{
            //    CmbIntakeNumber.SelectedIndex = -1;
            //    CmbIntakeNumber.SelectedIndex = 0;
            //}


           ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
           DataGridViewComboBoxColumn col1 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col40 = new DataGridViewTextBoxColumn();

            ClinicTableAdapters.DiagnoseTableAdapter daDiagnoses = new ClinicTableAdapters.DiagnoseTableAdapter();
            Clinic.DiagnoseDataTable dtDiagnosesAdd = daDiagnoses.GetData();
            Clinic.DiagnoseDataTable dtDiagnosesUpdate = daDiagnoses.GetData();



            DgDiagnoses.AutoGenerateColumns = false;
            col1.HeaderText = "קוד";
            col1.DataPropertyName = "DiagnoseCode";
            col1.Name = "ID";
            col1.ValueMember = "ID";
            col1.DisplayMember = "ID";
            col1.DataSource = dtDiagnosesAdd;
            col1.Width = 100;
            DgDiagnoses.Columns.Add(col1);

            col2.HeaderText = "שם אבחנה";
            col2.DataPropertyName = "Name";
            col2.Name = "Name";
            col2.ValueMember = "Name";
            col2.DisplayMember = "Name";
            col2.DataSource = dtDiagnosesAdd;
            col2.Width = 440;
            DgDiagnoses.Columns.Add(col2);

            col3.HeaderText = "תאריך התחלה";
            col3.DataPropertyName = "StartDate";
            col3.Name = "StartDate";
            col3.Width = 100;
            DgDiagnoses.Columns.Add(col3);

            col40.HeaderText = "תעודת זהות";
            col40.DataPropertyName = "PatientID";
            col40.Name = "PatientID";
            col40.Width = 100;
            DgDiagnoses.Columns.Add(col40);
            DgDiagnoses.Columns["PatientID"].Visible = false;

            DataGridViewComboBoxColumn col4 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn col5 = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col50 = new DataGridViewTextBoxColumn();

            DgDiagnosesUpdate.AutoGenerateColumns = false;
            col4.HeaderText = "קוד";
            col4.DataPropertyName = "DiagnoseCode";
            col4.Name = "ID";
            col4.ValueMember = "ID";
            col4.DisplayMember = "ID";
            col4.DataSource = dtDiagnosesUpdate;
            col4.Width = 100;
            DgDiagnosesUpdate.Columns.Add(col4);

            col5.HeaderText = "שם אבחנה";
            col5.DataPropertyName = "Name";
            col5.Name = "Name";
            col5.ValueMember = "Name";
            col5.DisplayMember = "Name";
            col5.DataSource = dtDiagnosesUpdate;
            col5.Width = 440;
            DgDiagnosesUpdate.Columns.Add(col5);

            col6.HeaderText = "תאריך התחלה";
            col6.DataPropertyName = "StartDate";
            col6.Name = "StartDate";
            col6.Width = 100;
            DgDiagnosesUpdate.Columns.Add(col6);

            col50.HeaderText = "תעודת זהות";
            col50.DataPropertyName = "PatientID";
            col50.Name = "PatientID";
            col50.Width = 100;
            DgDiagnosesUpdate.Columns.Add(col50);
            DgDiagnosesUpdate.Columns["PatientID"].Visible = false;

            dtDiagnoseForPatientsAdd = daD.GetDataByPatientID((int)CmblPatientId.SelectedValue);
            DgDiagnosesUpdate.DataSource = dtDiagnoseForPatients;
            DgDiagnoses.DataSource = dtDiagnoseForPatientsAdd;
        }


        private void BtnSaveIntake_Click(object sender, EventArgs e)
        {
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(this.TxtDate.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }

            int apNumber;
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            if (da.GetMaxAppointment(1,(int)CmblPatientId.SelectedValue) == null)
                apNumber = 1;
            else apNumber =(int) da.GetMaxAppointment(1,(int)CmblPatientId.SelectedValue)+1;
            
            DateTime now = DateTime.Now;
            DateTime dt = HourPickerStartAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            int id = Int32.Parse(da.InsertQuery(apNumber, null, 1, rs, st.ToString(), (int)CmbTherapist.SelectedValue, null, TxtNotes.Text, null, Globals.ConnectedUserID, null, now,
                null, TxtSentBy.Text, TxtReason.Text, TxtBrothersAndSisters.Text, TxtFamily.Text, TxtTraumas.Text, TxtPregnant.Text, TxtPsycho.Text,
                TxtSocial.Text, TxtPhysical.Text).ToString());
         ClinicTableAdapters.AppointmentsForPatientsTableAdapter app = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
         app.Insert(id, 1, (int)CmblPatientId.SelectedValue, true);
         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagnose = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         string formatted = now.ToString("dd/MM/yyyy");
         DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

         daDiagnose.Update(dtDiagnoseForPatientsAdd);
         ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
         daPatients.UpdateIntakeMeetingTrue(dateToAdd, (int)CmblPatientId.SelectedValue);



         MessageBox.Show("טיפול נוסף בהצלחה");

        }

        private void comPatientIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void CmbPatientNameUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            Clinic.AppointmentsDataTable dt = da.GetDataByAppointmentTypeAndPatientID(1,(int)cmbPatientIdUpdate.SelectedValue);
            if (dt.Rows.Count > 0)
                CmbDateUpdate.DataSource = dt;
            else
                CmbDateUpdate.DataSource = new Clinic.AppointmentsDataTable();
        }

        private void CmbDateUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbDateUpdate.SelectedIndex == -1)
                return;

            if (CmbDateUpdate.Items.Count == 0)
                clearAllFields();

            else
            {
                DateTime d = (DateTime)CmbDateUpdate.SelectedValue;
                TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
                ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
                Clinic.AppointmentsDataTable dt = da.GetDataByPatientIDAppointmentTypeAndDate((int)cmbPatientIdUpdate.SelectedValue, 1, (DateTime)CmbDateUpdate.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    CmbAppointmenrNumber.DataSource = dt;

                }
                else
                    clearAllFields();

            }
            //else
            //{
            //    DateTime d = (DateTime)CmbDateUpdate.SelectedValue;
            //    TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
            //    dateBeforeChange = (DateTime)CmbDateUpdate.SelectedValue;
            //    ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagsnoses = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter(); 
            //    DateTime now = DateTime.Now;
            //    String date = now.ToString("dd/MM/yyyy HH:mm:ss");
            //    ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            //    Clinic.AppointmentsDataTable dt = da.GetDataByAppointmentTypeDatePatientID((int)cmbPatientIdUpdate.SelectedValue,(DateTime)CmbDateUpdate.SelectedValue,  1);
            //    ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            //    TxtBrothersAndSistersUpdate.Text = dt.Rows[0]["BrothersAndSisters"].ToString();
            //    TxtFamilyUpdate.Text = dt.Rows[0]["Family"].ToString();
            //    TxtReasonUpdate.Text = dt.Rows[0]["Reason"].ToString();
            //    TxtPhysicalUpdate.Text = dt.Rows[0]["Physical"].ToString();
            //    TxtSocialUpdate.Text = dt.Rows[0]["Social"].ToString();
            //    TxtSentByUpdate.Text = dt.Rows[0]["SentBy"].ToString();
            //    TxtTraumasUpdate.Text = dt.Rows[0]["Traumas"].ToString();
            //    TxtPregnantUpdate.Text = dt.Rows[0]["Pregnant"].ToString();
            //    TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
            //    TxtWrittenByDateUpdate.Text = dt.Rows[0]["AddedByDate"].ToString();
            //    TxtHourUpdate.Text = dt.Rows[0]["Hour"].ToString();
            //    TxtNotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
            //    TxtPsychoUpdate.Text = dt.Rows[0]["Psycho"].ToString();
            //    CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
            //    dtDiagnoseForPatients =  daDiagsnoses.GetDataByPatientID((int)cmbPatientIdUpdate.SelectedValue);
            //    DgDiagnosesUpdate.DataSource = dtDiagnoseForPatients;
            //    DateTime dates = (DateTime) dt.Rows[0]["Date"];
            //    if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
            //    {
            //        dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
            //        TxtUpdatedByDateUpdate.Text = dates.ToString("dd/MM/yyyy");

            //    }
            //    if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
            //    {
            //        TxtUpdatedByUpdate.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

            //    }


            //}
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


        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
            Clinic.AppointmentsDataTable dt = da.GetDataByAppointmentTypeDatePatientID((int)cmbPatientIdUpdate.SelectedValue, (DateTime) CmbDateUpdate.SelectedValue, 1);
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(TxtDateUpdate.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }

            da.UpdateQuery(Int32.Parse(dt.Rows[0]["AppointmentNumber"].ToString()), null, 1, rs, TxtHourUpdate.Text, (int)CmbMainTherapistUpdate.SelectedValue, null, TxtNotesUpdate.Text, null, Globals.ConnectedUserID, DateTime.Now, TxtSentByUpdate.Text,
                TxtReasonUpdate.Text, TxtBrothersAndSistersUpdate.Text, TxtFamilyUpdate.Text, TxtTraumasUpdate.Text, TxtPregnant.Text, TxtPsychoUpdate.Text, TxtPhysicalUpdate.Text, TxtSocialUpdate.Text, Int32.Parse(dt.Rows[0]["ID"].ToString()));
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
           
                ClinicTableAdapters.PatientsTableAdapter daPatientsUpdate = new ClinicTableAdapters.PatientsTableAdapter();
                Clinic.PatientsDataTable dtPatientsUpdate = daPatientsUpdate.GetDataByPatientsWithIntake();
                cmbPatientIdUpdate.DataSource = dtPatientsUpdate;
                CmbPatientNameUpdate.DataSource = dtPatientsUpdate;

            
        }

        private void DgDiagnoses_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgDiagnoses.CurrentCell.ColumnIndex == 0 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }

            if (DgDiagnoses.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged1;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
            var currentcell = DgDiagnoses.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnoses.Rows[currentcell.Y].Cells[1];
            cel.Value = da.GetNameByID(sendingCB.EditingControlFormattedValue.ToString());

        }

        private void LastColumnComboSelectionChanged1(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
            var currentcell = DgDiagnoses.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnoses.Rows[currentcell.Y].Cells[0];
            cel.Value = da.GetIDByName(sendingCB.EditingControlFormattedValue.ToString());
        }

        private void DgDiagnosesUpdate_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgDiagnosesUpdate.CurrentCell.ColumnIndex == 0 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChangedUpdate;
            }

            if (DgDiagnosesUpdate.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChangedUpdate1;
            }

        }

        private void LastColumnComboSelectionChangedUpdate(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
            var currentcell = DgDiagnosesUpdate.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnosesUpdate.Rows[currentcell.Y].Cells[1];
            cel.Value = da.GetNameByID(sendingCB.EditingControlFormattedValue.ToString());
        }

        private void LastColumnComboSelectionChangedUpdate1(object sender, EventArgs e)
        {
            ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
            var currentcell = DgDiagnosesUpdate.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnosesUpdate.Rows[currentcell.Y].Cells[0];

            cel.Value = da.GetIDByName(sendingCB.EditingControlFormattedValue.ToString());

        }

        private void DgDiagnoses_Validating(object sender, CancelEventArgs e)
        {
            DataGridView dg = (sender as DataGridView);
            if (dg.CurrentRow == null)
            {
                e.Cancel = true;
            }  
        }

        private void DgDiagnoses_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            e.Row.Cells["PatientID"].Value = (int)CmblPatientId.SelectedValue;
        }

        private void DgDiagnosesUpdate_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            e.Row.Cells["PatientID"].Value = (int)CmblPatientId.SelectedValue;
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {

        }

        private void CmbDateUpdate_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            TxtBrothersAndSisters.Text = String.Empty;
            TxtFamily.Text = String.Empty;
            TxtPhysical.Text = String.Empty;
            TxtSocial.Text = String.Empty;
            TxtSentBy.Text = String.Empty;
            TxtTraumas.Text = String.Empty;
            TxtFamily.Text = String.Empty;
            TxtPregnant.Text = String.Empty;
            TxtReason.Text = String.Empty;
            TxtWrittenByAdd.Text = String.Empty;
            TxtWrittenByDateAdd.Text = String.Empty;
            HourPickerStartAdd.Text = String.Empty;
            TxtNotes.Text = String.Empty;
            TxtPhysical.Text = String.Empty;
        }

        private void CmbAppointmenrNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

              if (CmbDateUpdate.SelectedIndex == -1)
                return;

            if (CmbDateUpdate.Items.Count == 0)
                clearAllFields();


                ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
                Clinic.AppointmentsDataTable dt = da.GetDataByPatientIDAppointmentTypeDateAppointmentNumber((int)cmbPatientIdUpdate.SelectedValue, 1, (DateTime)CmbDateUpdate.SelectedValue,(int)CmbAppointmenrNumber.SelectedValue);
                if (dt.Rows.Count == 0)
                {
                clearAllFields();
            }
            else
            {
   
                ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagsnoses = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter(); 
                DateTime now = DateTime.Now;
                String date = now.ToString("dd/MM/yyyy HH:mm:ss");
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
                TxtHourUpdate.Text = dt.Rows[0]["Hour"].ToString();
                TxtNotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
                TxtPsychoUpdate.Text = dt.Rows[0]["Psycho"].ToString();
                CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
                dtDiagnoseForPatients =  daDiagsnoses.GetDataByPatientID((int)cmbPatientIdUpdate.SelectedValue);
                DgDiagnosesUpdate.DataSource = dtDiagnoseForPatients;
                DateTime dates = (DateTime) dt.Rows[0]["Date"];
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


     




    }
}
