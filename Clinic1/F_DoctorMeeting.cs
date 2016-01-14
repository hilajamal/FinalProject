using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;


namespace Clinic1
{
    public partial class F_DoctorMeeting : Form
    {
        Clinic.MedicinesForPatientsDataTable dtMedicineAdd;
        Clinic.MedicinesForPatientsDataTable dtMedicineUpdate;
        Clinic.DiagnosesForPatientsDataTable dtDiagnisesAdd;
        Clinic.DiagnosesForPatientsDataTable dtDiagnisesUpdate;



        public F_DoctorMeeting()
        {
            InitializeComponent();
            AddCols();
        }

     private void AddCols(){

         CmbAppointmentNumber.AutoCompleteMode = AutoCompleteMode.Append;
         CmbAppointmentNumber.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbAppointmentNumber.DisplayMember = "AppointmentNumber";
         CmbAppointmentNumber.ValueMember = "AppointmentNumber";

         DgDiagnosesUpdate.AutoGenerateColumns = false;
         DgDiagnosesAdd.AutoGenerateColumns = false;
         DgMedicine.AutoGenerateColumns = false;
         DgMedicineUpdate.AutoGenerateColumns = false;

         TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
         TxtWrittenByAdd.Text = Globals.ConnectedUserName;

         HourAdd.ShowUpDown = true;
         HourAdd.Format = DateTimePickerFormat.Custom;
         HourAdd.CustomFormat = "HH:mm:ss";
         HourUpdate.ShowUpDown = true;
         HourUpdate.Format = DateTimePickerFormat.Custom;
         HourUpdate.CustomFormat = "HH:mm:ss";

         ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
         Clinic.PatientsDataTable dtPatients = daPatients.GetData();


         //CmbDateUpdate
         CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
         CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbDateUpdate.DisplayMember = "Date";
         CmbDateUpdate.ValueMember = "Date";


         //PatientsIDAdd
         CmblPatientIdAdd.AutoCompleteMode = AutoCompleteMode.Append;
         CmblPatientIdAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmblPatientIdAdd.DisplayMember = "ID";
         CmblPatientIdAdd.ValueMember = "ID";
         CmblPatientIdAdd.DataSource = dtPatients;
         CmblPatientIdAdd.SelectedIndex = -1;
         CmblPatientIdAdd.SelectedIndex = 0;

         //PatientsNameAdd
         CmbPatientNameAdd.DataSource = dtPatients;
         CmbPatientNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
         CmbPatientNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbPatientNameAdd.DisplayMember = "FullName";
         CmbPatientNameAdd.ValueMember = "ID";
         CmbPatientNameAdd.SelectedIndex = 0;

         //PatientsIDUpdate
         Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(6);
         CmbPatientIDUpdate.DataSource = dtPatientsUpdate;
         CmbPatientIDUpdate.AutoCompleteMode = AutoCompleteMode.Append;
         CmbPatientIDUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbPatientIDUpdate.DisplayMember = "ID";
         CmbPatientIDUpdate.ValueMember = "ID";
         if (CmbPatientIDUpdate.Items.Count > 0)
         {
             CmbPatientIDUpdate.SelectedIndex = -1;
             CmbPatientIDUpdate.SelectedIndex = 0;
         }
      

         //PatientsNameUpdate
         CmbPatientNameUpdate.DataSource = dtPatientsUpdate;
         CmbPatientNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
         CmbPatientNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbPatientNameUpdate.DisplayMember = "FullName";
         CmbPatientNameUpdate.ValueMember = "ID";

         //MainTherapistAdd
         ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
         Clinic.WorkersDataTable dtWorkers = daWorkers.GetDataByActiveWorkers();
         CmbTherapistAdd.DataSource = dtWorkers;
         CmbTherapistAdd.SelectedIndex = 0;
         CmbTherapistAdd.AutoCompleteMode = AutoCompleteMode.Append;
         CmbTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbTherapistAdd.DisplayMember = "FullName";
         CmbTherapistAdd.ValueMember = "ID";
        
         //MainTherapistUpdate
         CmbTherapistUpdate.DataSource = daWorkers.GetDataByActiveWorkers();
         CmbTherapistUpdate.SelectedIndex = 0;
         CmbTherapistUpdate.AutoCompleteMode = AutoCompleteMode.Append;
         CmbTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
         CmbTherapistUpdate.DisplayMember = "FullName";
         CmbTherapistUpdate.ValueMember = "ID";

         DataGridViewComboBoxColumn col1 = new DataGridViewComboBoxColumn();
         DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
         DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col40 = new DataGridViewTextBoxColumn();


         ClinicTableAdapters.DiagnoseTableAdapter daDiagnoses = new ClinicTableAdapters.DiagnoseTableAdapter();
         Clinic.DiagnoseDataTable dtDiagnosesAdd = daDiagnoses.GetData();
         Clinic.DiagnoseDataTable dtDiagnosesUpdate = daDiagnoses.GetData();

         DgDiagnosesAdd.AutoGenerateColumns = false;
         col1.HeaderText = "קוד";
         col1.DataPropertyName = "DiagnoseCode";
         col1.Name = "ID";
         col1.ValueMember = "ID";
         col1.DisplayMember = "ID";
         col1.DataSource = dtDiagnosesAdd;
         col1.Width = 100;
         DgDiagnosesAdd.Columns.Add(col1);

         col2.HeaderText = "שם אבחנה";
         col2.DataPropertyName = "Name";
         col2.Name = "Name";
         col2.ValueMember = "Name";
         col2.DisplayMember = "Name";
         col2.DataSource = dtDiagnosesAdd;
         col2.Width = 440;
         DgDiagnosesAdd.Columns.Add(col2);

         col3.HeaderText = "תאריך התחלה";
         col3.DataPropertyName = "StartDate";
         col3.Name = "StartDate";
         col3.Width = 100;
         DgDiagnosesAdd.Columns.Add(col3);

         col40.HeaderText = "תעודת זהות";
         col40.DataPropertyName = "PatientID";
         col40.Name = "PatientID";
         col40.Width = 100;
         DgDiagnosesAdd.Columns.Add(col40);
         DgDiagnosesAdd.Columns["PatientID"].Visible = false;

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

         DataGridViewComboBoxColumn col7 = new DataGridViewComboBoxColumn();
         DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col15 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col17 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col18 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col60 = new DataGridViewTextBoxColumn();

         ClinicTableAdapters.MedicinesTableAdapter daMedicine = new ClinicTableAdapters.MedicinesTableAdapter();

         DgMedicine.AutoGenerateColumns = false;
         col7.HeaderText = "תרופה";
         col7.ValueMember = "ID";
         col7.DisplayMember = "Name";
         col7.DataPropertyName = "MedicineID";
         col7.DataSource = daMedicine.GetData();
         col7.AutoComplete = true;
         DgMedicine.Columns.Add(col7);

         col8.HeaderText = "תדירות";
         col8.DataPropertyName = "Frequency";
         col8.Name = "Frequency";
         DgMedicine.Columns.Add(col8);


         col9.HeaderText = "בוקר";
         col9.DataPropertyName = "Morning";
         col9.Name = "Morning";
         DgMedicine.Columns.Add(col9);

         col10.HeaderText = "צהריים";
         col10.DataPropertyName = "Noon";
         col10.Name = "Noon";
         DgMedicine.Columns.Add(col10);

         col11.HeaderText = "אחר צהריים";
         col11.DataPropertyName = "AfterNoon";
         col11.Name = "AfterNoon";
         DgMedicine.Columns.Add(col11);


         col12.HeaderText = "ערב";
         col12.DataPropertyName = "Evening";
         col12.Name = "Evening";
         DgMedicine.Columns.Add(col12);

         col13.HeaderText = "משך מתן התרופה";
         col13.DataPropertyName = "Duration";
         col13.Name = "Duration";
         DgMedicine.Columns.Add(col13);

         col14.HeaderText = "משך מתן מינון אחרון";
         col14.DataPropertyName = "LastDuration";
         col14.Name = "LastDuration";
         col14.ReadOnly = true;
         DgMedicine.Columns.Add(col14);

         col16.HeaderText = "יחידות";
         col16.DataPropertyName = "Units";
         col16.Name = "Units";
         DgMedicine.Columns.Add(col16);

         col17.HeaderText = "מנון";
         col17.DataPropertyName = "Dosage";
         col17.Name = "Dosage";
         DgMedicine.Columns.Add(col17);


         col18.HeaderText = "תאריך התחלה";
         col18.DataPropertyName = "StartDate";
         col18.Name = "StartDate";
         DateTime now = DateTime.Now;
         string formatted = now.ToString("dd/MM/yyyy");
         col18.DefaultCellStyle.NullValue = formatted;
         DgMedicine.Columns.Add(col18);

         col15.HeaderText = "תאריך סיום";
         col15.DataPropertyName = "EndDate";
         col15.Name = "EndDate";
         col15.ReadOnly = true;
         DgMedicine.Columns.Add(col15);

         col60.HeaderText = "תעודת זהות";
         col60.DataPropertyName = "PatientID";
         col60.Name = "PatientID";
         col60.Width = 100;
         DgMedicine.Columns.Add(col60);
         DgMedicine.Columns["PatientID"].Visible = false;

         DataGridViewComboBoxColumn col19 = new DataGridViewComboBoxColumn();
         DataGridViewTextBoxColumn col20 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col21 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col22 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col23 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col24 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col25 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col26 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col27 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col28 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col29 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col30 = new DataGridViewTextBoxColumn();
         DataGridViewTextBoxColumn col70 = new DataGridViewTextBoxColumn();

         DgMedicineUpdate.AutoGenerateColumns = false;
         col19.HeaderText = "תרופה";
         col19.ValueMember = "ID";
         col19.DisplayMember = "Name";
         col19.DataPropertyName = "MedicineID";
         col19.Width = 80;
         col19.DataSource = daMedicine.GetData();
         DgMedicineUpdate.Columns.Add(col19);

         col20.HeaderText = "תדירות";
         col20.DataPropertyName = "Frequency";
         col20.Name = "Frequency";
         DgMedicineUpdate.Columns.Add(col20);


         col21.HeaderText = "בוקר";
         col21.DataPropertyName = "Morning";
         col21.Name = "Morning";
         DgMedicineUpdate.Columns.Add(col21);

         col22.HeaderText = "צהריים";
         col22.DataPropertyName = "Noon";
         col22.Name = "Noon";
         DgMedicineUpdate.Columns.Add(col22);

         col23.HeaderText = "אחר צהריים";
         col23.DataPropertyName = "AfterNoon";
         col23.Name = "AfterNoon";
         DgMedicineUpdate.Columns.Add(col23);


         col24.HeaderText = "ערב";
         col24.DataPropertyName = "Evening";
         col24.Name = "Evening";
         DgMedicineUpdate.Columns.Add(col24);

         col25.HeaderText = "משך מתן התרופה";
         col25.DataPropertyName = "Duration";
         col25.Name = "Duration";
         DgMedicineUpdate.Columns.Add(col25);

         col26.HeaderText = "משך מתן מינון אחרון";
         col26.DataPropertyName = "LastDuration";
         col26.Name = "LastDuration";
         col26.ReadOnly = true;
         DgMedicineUpdate.Columns.Add(col26);

         col27.HeaderText = "יחידות";
         col27.DataPropertyName = "Units";
         col27.Name = "Units";
         DgMedicineUpdate.Columns.Add(col27);

         col28.HeaderText = "מנון";
         col28.DataPropertyName = "Dosage";
         col28.Name = "Dosage";
         DgMedicineUpdate.Columns.Add(col28);

         col29.HeaderText = "תאריך התחלה";
         col29.DataPropertyName = "StartDate";
         col29.Name = "StartDate";
         col29.DefaultCellStyle.NullValue = formatted;
         DgMedicineUpdate.Columns.Add(col29);

         col30.HeaderText = "תאריך סיום";
         col30.DataPropertyName = "EndDate";
         col30.Name = "EndDate";
         col30.ReadOnly = true;
         DgMedicineUpdate.Columns.Add(col30);

         col70.HeaderText = "תעודת זהות";
         col70.DataPropertyName = "PatientID";
         col70.Name = "PatientID";
         col70.Width = 100;
         DgMedicineUpdate.Columns.Add(col70);
         DgMedicineUpdate.Columns["PatientID"].Visible = false;

     }

     private void CmbPatientIDUpdate_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (CmbPatientIDUpdate.SelectedIndex == -1)
             return;
         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         dtDiagnisesUpdate = daD.GetDataByPatientID((int)CmbPatientIDUpdate.SelectedValue);
         DgDiagnosesUpdate.DataSource = dtDiagnisesUpdate;

         ClinicTableAdapters.MedicinesForPatientsTableAdapter daM = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();
         dtMedicineUpdate = daM.GetActiveMedicinesByPatientID((int)CmbPatientIDUpdate.SelectedValue, DateTime.Now);
         DgMedicineUpdate.DataSource = dtMedicineUpdate;
         ClinicTableAdapters.AppointmentsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsTableAdapter();
         CmbDateUpdate.DataSource = daAPA.GetDataByAppointmentTypeAndPatientID(6,(int)CmbPatientIDUpdate.SelectedValue);


     }

     private void CmblPatientIdAdd_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (CmblPatientIdAdd.SelectedIndex == -1)
             return;
         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daD = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         dtDiagnisesAdd = daD.GetDataByPatientID((int)CmblPatientIdAdd.SelectedValue);
         DgDiagnosesAdd.DataSource = dtDiagnisesAdd;

         ClinicTableAdapters.MedicinesForPatientsTableAdapter daM = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();
         dtMedicineAdd = daM.GetActiveMedicinesByPatientID((int)CmblPatientIdAdd.SelectedValue, DateTime.Now);
         DgMedicine.DataSource = dtMedicineAdd;
         TxtNotesAdd.Text = String.Empty;
     }

     private void DgMedicine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
     {
         if (e.ColumnIndex == 0)
         {
             ClinicTableAdapters.MedicinesForPatientsTableAdapter da = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();
             Clinic.MedicinesForPatientsDataTable dt = da.GetLastDurationByPatientIDAndMedicineID(Int32.Parse(DgMedicine.Rows[e.RowIndex].Cells[0].Value.ToString()), (int)CmblPatientIdAdd.SelectedValue);
             if (dt.Rows.Count > 0)
             {
                 DataRow dr = dt.Rows[0];
                 DgMedicine.Rows[e.RowIndex].Cells[7].Value = dr["Duration"].ToString();
             }
             else
                 DgMedicine.Rows[e.RowIndex].Cells[7].Value = 0;
         }

       
     }

     private void DgDiagnosesAdd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
     {
         if (DgDiagnosesAdd.CurrentCell.ColumnIndex == 0 && e.Control is ComboBox)
         {
             ComboBox comboBox = e.Control as ComboBox;
             comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
         }

         if (DgDiagnosesAdd.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
         {
             ComboBox comboBox = e.Control as ComboBox;
             comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged1;
         }

     }

     private void LastColumnComboSelectionChanged(object sender, EventArgs e)
     {
         ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
         var currentcell = DgDiagnosesAdd.CurrentCellAddress;
         var sendingCB = sender as DataGridViewComboBoxEditingControl;
         DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnosesAdd.Rows[currentcell.Y].Cells[1];
         cel.Value = da.GetNameByID(sendingCB.EditingControlFormattedValue.ToString());

     }

     private void LastColumnComboSelectionChanged1(object sender, EventArgs e)
     {
         ClinicTableAdapters.DiagnoseTableAdapter da = new ClinicTableAdapters.DiagnoseTableAdapter();
         var currentcell = DgDiagnosesAdd.CurrentCellAddress;
         var sendingCB = sender as DataGridViewComboBoxEditingControl;
         DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)DgDiagnosesAdd.Rows[currentcell.Y].Cells[0];
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

     private void DgMedicine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
     {
         DateTime date;

         if (DgMedicineUpdate.Columns[e.ColumnIndex].Name == "Duration" && DgMedicineUpdate[6, e.RowIndex].Value!=null)
         {
             if (DgMedicineUpdate[10, e.RowIndex].Value == null)
                 date = DateTime.Now;
             else
                 date = DateTime.Parse(DgMedicineUpdate[10, e.RowIndex].Value.ToString());
             date.AddDays(Double.Parse(DgMedicineUpdate[6, e.RowIndex].Value.ToString()));
             DgMedicineUpdate[11, e.RowIndex].Value = date.ToString("dd/MM/yyyy");
         }
     }

     private void BtnSave_Click(object sender, EventArgs e)
     {
         ClinicTableAdapters.MedicinesForPatientsTableAdapter daM = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();

         int apNumber;
         ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
         if (da.GetMaxAppointment(6, (int)CmblPatientIdAdd.SelectedValue) == null)
             apNumber = 1;
         else apNumber = (int)da.GetMaxAppointment(6, (int)CmblPatientIdAdd.SelectedValue) + 1;
         DateTime rs;
         CultureInfo ci = new CultureInfo("en-IE");
         if (!DateTime.TryParseExact(this.TxtDateAdd.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
         {
             MessageBox.Show("יש להזין תאריך תקין");
             return;
         }


         int index = 0;
         foreach (DataGridViewRow row in DgMedicine.Rows)
         {
             if(row.Cells[0].Value!=null)
             if (ValidateMedicineRow(row, index) == false)
                 return;
             else
             {
                 DateTime dates = DateTime.Parse(row.Cells[10].Value.ToString());
                 dates.AddDays(Double.Parse(row.Cells[6].Value.ToString()));
                 row.Cells[11].Value = dates;
                 
                 index++;

             }
         }


         DateTime now = DateTime.Now;

         DateTime dt = HourAdd.Value;
         TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

         int id = Int32.Parse(da.InsertQuery(apNumber, null, 6, rs, st.ToString(), (int)CmbTherapistAdd.SelectedValue, null, TxtNotesAdd.Text, null, Globals.ConnectedUserID, null, now,
                null, null, null, null, null, null, null, null,
                null, null).ToString());
         ClinicTableAdapters.AppointmentsForPatientsTableAdapter app = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
         app.Insert(id, 6, (int)CmblPatientIdAdd.SelectedValue, true);
         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagnose = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         string formatted = now.ToString("dd/MM/yyyy");
         DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

         daDiagnose.Update(dtDiagnisesAdd);
         daM.Update(dtMedicineAdd);

         MessageBox.Show("טיפול נוסף בהצלחה");
         ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
         Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(6);
         CmbPatientIDUpdate.DataSource = dtPatientsUpdate;

     }

     private bool ValidateMedicineRow(DataGridViewRow row, int index)
     {


         StringBuilder str = new StringBuilder();
         int num = index + 1;
         int check;
         DateTime DateCheck;
         str.Append(" הוסף בשורה " + num);
         Boolean HasErrors = false; //במידה והמשתמש מילא את כל הפרטים לא נדפיס הודעה
         Boolean First_ItemNull = false; //בהוספה ראשונה נשמיט את הפסיק
         if (row.Cells[0].Value == System.DBNull.Value  || row.Cells[0].Value == null)
         {
             str.Append(" תרופה");
             HasErrors = true;
             First_ItemNull = true;
         }

         if (row.Cells[1].Value == System.DBNull.Value || row.Cells[1].Value == null)
         {
             if (First_ItemNull == true)
             {
                 str.Append(", תדירות");
             }
             else
             {
                 str.Append(" תדירות");
                 First_ItemNull = true;
             }
             HasErrors = true;
         }
         else
         {
             if (Int32.TryParse(row.Cells[1].Value.ToString(),out check) == false)
             {
                 if (First_ItemNull == true)
                 {
                     str.Append(", תדירות");
                 }
                 else
                 {
                     str.Append(" תדירות");
                     First_ItemNull = true;
                 }
                 HasErrors = true;
             }

         }

         if (row.Cells[6].Value == System.DBNull.Value || row.Cells[6].Value == null)
         {
             if (First_ItemNull == true)
             {
                 str.Append(", משך מתן התרופה");
             }
             else
             {
                 str.Append(" משך מתן התרופה");
                 First_ItemNull = true;
             }
             HasErrors = true;
         }

         else
         {
             if (Int32.TryParse(row.Cells[6].Value.ToString(), out check) == false)
             {
                 if (First_ItemNull == true)
                 {
                     str.Append(", משך מתן התרופה");
                 }
                 else
                 {
                     str.Append(" משך מתן התרופה");
                     First_ItemNull = true;
                 }
                 HasErrors = true;
             }

         }

         if (row.Cells[8].Value == System.DBNull.Value || row.Cells[8].Value == null)
         {
             if (First_ItemNull == true)
             {
                 str.Append(", יחידות");
             }
             else
             {
                 str.Append(" יחידות");
                 First_ItemNull = true;
             }
             HasErrors = true;
         }

         else
         {
             if (Int32.TryParse(row.Cells[8].Value.ToString(), out check) == false)
             {
                 if (First_ItemNull == true)
                 {
                     str.Append(", יחידות");
                 }
                 else
                 {
                     str.Append(" יחידות");
                     First_ItemNull = true;
                 }
                 HasErrors = true;
             }

         }

         if (row.Cells[9].Value == System.DBNull.Value || row.Cells[9].Value == null)
         {
             if (First_ItemNull == true)
             {
                 str.Append(", מנון");
             }
             else
             {
                 str.Append(" מנון");
                 First_ItemNull = true;
             }
             HasErrors = true;
         }

         else
         {
             if (Int32.TryParse(row.Cells[9].Value.ToString(), out check) == false)
             {
                 if (First_ItemNull == true)
                 {
                     str.Append(", מנון");
                 }
                 else
                 {
                     str.Append(" מנון");
                     First_ItemNull = true;
                 }
                 HasErrors = true;
             }

         }

         if (row.Cells[10].Value == System.DBNull.Value || row.Cells[10].Value == null)
         {
             if (First_ItemNull == true)
             {
                 str.Append(", תאריך התחלה");
             }
             else
             {
                 str.Append(" תאריך התחלה");
                 First_ItemNull = true;
             }
             HasErrors = true;
         }

         else
         {
             if (DateTime.TryParse(row.Cells[10].Value.ToString(), out DateCheck) == false)
             {
                 if (First_ItemNull == true)
                 {
                     str.Append(", תאריך התחלה");
                 }
                 else
                 {
                     str.Append(" תאריך התחלה");
                     First_ItemNull = true;
                 }
                 HasErrors = true;
             }

         }

         if (HasErrors)
         {
             MessageBox.Show(str.ToString());
             return false; //אם חסרים פרטים בשורה יש לבצע את בדיקת התקינות שוב
         }

         return true; //אחרת-אם כל השורה מולאה אל תבצע את בדיקת התקינות שוב
     
     
     
     
     }

     private void DgDiagnosesAdd_Validating(object sender, CancelEventArgs e)
     {
                 DataGridView dg = (sender as DataGridView);
            if (dg.CurrentRow==null)
            {
                e.Cancel = true;
            }  
     }


     private void DgDiagnosesAdd_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
     {
         var dgv = sender as DataGridView;
         if (dgv == null)
             return;

         e.Row.Cells["PatientID"].Value = (int)CmblPatientIdAdd.SelectedValue;

      //   dgv.BindingContext[dgv.DataSource].EndCurrentEdit();
     }

     private void DgMedicine_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
     {
         var dgv = sender as DataGridView;
         if (dgv == null)
             return;

         e.Row.Cells["PatientID"].Value = (int)CmblPatientIdAdd.SelectedValue;
         e.Row.Cells["StartDate"].Value = DateTime.Now.ToString("dd/MM/yyyy");

     }

     private void DgMedicineUpdate_Validating(object sender, CancelEventArgs e)
     {
         DataGridView dg = (sender as DataGridView);
         if (dg.CurrentRow == null)
         {
             e.Cancel = true;
         }  
     }

     private void DgMedicine_Validating(object sender, CancelEventArgs e)
     {
          DataGridView dg = (sender as DataGridView);
         if (dg.CurrentRow == null)
         {
             e.Cancel = true;
         }  
     }

     private void CmbDateUpdate_SelectedIndexChanged(object sender, EventArgs e)
     {

         if (CmbDateUpdate.SelectedIndex == -1)
             return;

         if (CmbDateUpdate.Items.Count == 0)

         {

             TxtNotesUpdate.Text = String.Empty;
             TxtWrittenByDateUpdate.Text = String.Empty;
             TxtWrittenByUpdate.Text = String.Empty;
             TxtUpdatedBy.Text = String.Empty;
             TxtUpdatedByDate.Text = String.Empty;
             return;
         
         
         }
         else
         {
             ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
             Clinic.AppointmentsDataTable dt = da.GetDataByPatientIDAppointmentTypeAndDate((int)CmbPatientIDUpdate.SelectedValue, 6, (DateTime)CmbDateUpdate.SelectedValue);
             if (dt.Rows.Count == 0)
             {

                 TxtNotesUpdate.Text = String.Empty;
                 TxtWrittenByDateUpdate.Text = String.Empty;
                 TxtWrittenByUpdate.Text = String.Empty;
                 TxtUpdatedBy.Text = String.Empty;
                 TxtUpdatedByDate.Text = String.Empty;

             }
             else
                 CmbAppointmentNumber.DataSource = dt;
             DateTime d = (DateTime)CmbDateUpdate.SelectedValue;
             TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");

         }

         //if (CmbDateUpdate.Items.Count > 0)
         //{
         //    ClinicTableAdapters.AppointmentsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsTableAdapter();
         //    ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
         //    Clinic.AppointmentsDataTable dt = daAPA.GetDataByAppointmentTypeDatePatientID((int)CmbPatientIDUpdate.SelectedValue, (DateTime)CmbDateUpdate.SelectedValue, 6);
         //    TxtNotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
         //    TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
         //    TxtWrittenByDateUpdate.Text = dt.Rows[0]["Date"].ToString();
         //    DateTime d = (DateTime)dt.Rows[0]["AddedByDate"];
         //    TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
         //    HourUpdate.Text = dt.Rows[0]["Hour"].ToString();

         //    CmbTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
         //    DateTime Dates = new DateTime();
         //    //HourPickerUpdate.va
         //    if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
         //    {
         //        Dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
         //        TxtUpdatedByDate.Text = Dates.ToString("dd/MM/yyyy");

         //    }
         //    if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
         //    {
         //        TxtUpdatedBy.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

         //    }
         //}
         //else TxtNotesUpdate.Text = String.Empty;
     }

     private void DgMedicineUpdate_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
     {
         var dgv = sender as DataGridView;
         if (dgv == null)
             return;

         e.Row.Cells["PatientID"].Value = (int)CmbPatientIDUpdate.SelectedValue;
         e.Row.Cells["StartDate"].Value = DateTime.Now.ToString("dd/MM/yyyy");
     }

     private void DgDiagnosesUpdate_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
     {
         var dgv = sender as DataGridView;
         if (dgv == null)
             return;

         e.Row.Cells["PatientID"].Value = (int)CmblPatientIdAdd.SelectedValue;
     }

     private void BtnSaveUpdates_Click(object sender, EventArgs e)
     {

         DateTime rs;
         CultureInfo ci = new CultureInfo("en-IE");
         if (!DateTime.TryParseExact(this.TxtDateUpdate.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
         {
             MessageBox.Show("יש להזין תאריך תקין");
             return;
         }


         int index = 0;
         foreach (DataGridViewRow row in DgMedicineUpdate.Rows)
         {
             if (row.Cells[0].Value != null)
                 if (ValidateMedicineRow(row, index) == false)
                     return;
                 else
                 {
                     DateTime dates = DateTime.Parse(row.Cells[10].Value.ToString());
                     dates.AddDays(Double.Parse(row.Cells[6].Value.ToString()));
                     row.Cells[11].Value = dates;

                     index++;

                 }
         }


         ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
         DateTime dt = HourUpdate.Value;
         TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
         DateTime now = DateTime.Now;


         Clinic.AppointmentsDataTable dtToAdd = da.GetDataByAppointmentTypeDatePatientID((int)CmbPatientIDUpdate.SelectedValue, (DateTime)CmbDateUpdate.SelectedValue, 6);

         da.UpdateQuery(Int32.Parse(dtToAdd.Rows[0]["AppointmentNumber"].ToString()), null, 6, rs, st.ToString(), (int)CmbTherapistUpdate.SelectedValue, null, TxtNotesUpdate.Text, null, Globals.ConnectedUserID, now, null, null, null, null, null, null, null, null, null, Int32.Parse(dtToAdd.Rows[0]["ID"].ToString()));
         MessageBox.Show("טיפול עודכן בהצלחה");

         ClinicTableAdapters.DiagnosesForPatientsTableAdapter daDiagnose = new ClinicTableAdapters.DiagnosesForPatientsTableAdapter();
         ClinicTableAdapters.MedicinesForPatientsTableAdapter daM = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();

         string formatted = now.ToString("dd/MM/yyyy");
         DateTime dateToAdd = DateTime.ParseExact(formatted, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);


         daDiagnose.Update(dtDiagnisesUpdate);
         daM.Update(dtMedicineUpdate);

     }

     private void DgMedicineUpdate_CellEndEdit(object sender, DataGridViewCellEventArgs e)
     {
         if (e.ColumnIndex == 0)
         {
             ClinicTableAdapters.MedicinesForPatientsTableAdapter da = new ClinicTableAdapters.MedicinesForPatientsTableAdapter();
             Clinic.MedicinesForPatientsDataTable dt = da.GetLastDurationByPatientIDAndMedicineID(Int32.Parse(DgMedicineUpdate.Rows[e.RowIndex].Cells[0].Value.ToString()), (int)CmbPatientIDUpdate.SelectedValue);
             if (dt.Rows.Count > 0)
             {
                 DataRow dr = dt.Rows[0];
                 DgMedicineUpdate.Rows[e.RowIndex].Cells[7].Value = dr["Duration"].ToString();
             }
             else
                 DgMedicineUpdate.Rows[e.RowIndex].Cells[7].Value = 0;
         }
     }

     private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
     {
         ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
         Clinic.PatientsDataTable dtPatientsUpdate = daPatients.GetDataByAppointmentTypeID(6);
         CmbPatientIDUpdate.DataSource = dtPatientsUpdate;

         Clinic.PatientsDataTable dtPatients = daPatients.GetData();
         CmblPatientIdAdd.DataSource = dtPatients;
     }

     private void label19_Click(object sender, EventArgs e)
     {

     }

     private void label5_Click(object sender, EventArgs e)
     {

     }

     private void HourUpdate_ValueChanged(object sender, EventArgs e)
     {

     }

     private void CmbAppointmentNumber_SelectedIndexChanged(object sender, EventArgs e)
     {
         if (CmbAppointmentNumber.Items.Count > 0)
         {
             ClinicTableAdapters.AppointmentsTableAdapter daAPA = new ClinicTableAdapters.AppointmentsTableAdapter();
             ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
             Clinic.AppointmentsDataTable dt = daAPA.GetDataByPatientIDAppointmentTypeDateAppointmentNumber((int)CmbPatientIDUpdate.SelectedValue,6, (DateTime)CmbDateUpdate.SelectedValue, (int)CmbAppointmentNumber.SelectedValue);
             TxtNotesUpdate.Text = dt.Rows[0]["Notes"].ToString();
             TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
             TxtWrittenByDateUpdate.Text = dt.Rows[0]["Date"].ToString();
             DateTime d = (DateTime)dt.Rows[0]["AddedByDate"];
             TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
             HourUpdate.Text = dt.Rows[0]["Hour"].ToString();

             CmbTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
             DateTime Dates = new DateTime();
             //HourPickerUpdate.va
             if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
             {
                 Dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
                 TxtUpdatedByDate.Text = Dates.ToString("dd/MM/yyyy");

             }
             if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
             {
                 TxtUpdatedBy.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

             }
         }
     }














    }
}

