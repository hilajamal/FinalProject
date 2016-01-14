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
    public partial class F_GroupsMeetings : Form
    {
        Clinic.AppointmentsForPatientsDataTable dtPatientsUpdate = new Clinic.AppointmentsForPatientsDataTable();
        public F_GroupsMeetings()
        {
            InitializeComponent();
    
            addCols();
            loaddata();
        }

        private void loaddata()
        {
            ClinicTableAdapters.AppointmentsTableAdapter daAppointments = new ClinicTableAdapters.AppointmentsTableAdapter(); 
            ClinicTableAdapters.GroupsTableAdapter daGroups = new ClinicTableAdapters.GroupsTableAdapter();
            if (daAppointments.GetDataByGroupsWithAppointments().Rows.Count > 0)
            {
                Clinic.AppointmentsDataTable dtGroups1 = daAppointments.GetDataByGroupsWithAppointments();
                CmbGroupNameUpdate.DataSource = dtGroups1;
                CmbGroupIdUpdate.DataSource = dtGroups1;
            }
            Clinic.GroupsDataTable dtGroups2 = daGroups.GetData();

       

            CmbGroupNameAdd.DataSource = dtGroups2;
            CmbGroupIDAdd.DataSource = dtGroups2;

            ClinicTableAdapters.AppointmentTypeTableAdapter daType = new ClinicTableAdapters.AppointmentTypeTableAdapter();
            CmbMeetingTypeAdd.DataSource = daType.GetDataByGroupsAppointments();
            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetDataByPatientIDInnerJoinPatients((int)CmbGroupIDAdd.SelectedValue);
            DgPatientsAdd.DataSource = dtPatients;
            
            ClinicTableAdapters.AppointmentsTableAdapter daAp = new ClinicTableAdapters.AppointmentsTableAdapter();
            if(daAp.GetMaxAppointmentNumber((int)CmbGroupIDAdd.SelectedValue) == null)
            txtMeetingNumberAdd.Text = "1";
            else
            txtMeetingNumberAdd.Text = (daAp.GetMaxAppointmentNumber((int)CmbGroupIDAdd.SelectedValue) + 1).ToString();

        }

        private void addCols()
        {

            CmbGroupIdUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupIdUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupIdUpdate.DisplayMember = "GroupNumber";
            CmbGroupIdUpdate.ValueMember = "GroupNumber";

            CmbGroupNameUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupNameUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupNameUpdate.DisplayMember = "Name";
            CmbGroupNameUpdate.ValueMember = "GroupNumber";

            CmbGroupIDAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupIDAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupIDAdd.DisplayMember = "GroupNumber";
            CmbGroupIDAdd.ValueMember = "GroupNumber";

            CmbGroupNameAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGroupNameAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGroupNameAdd.DisplayMember = "Name";
            CmbGroupNameAdd.ValueMember = "GroupNumber";

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn col4 = new DataGridViewCheckBoxColumn();
            DgPatientsAdd.AutoGenerateColumns = false;
            col1.HeaderText = "תעודת זהות";
            col1.DataPropertyName = "ID";
            col1.Name = "ID";
            DgPatientsAdd.Columns.Add(col1);

            col2.HeaderText = "שם פרטי";
            col2.DataPropertyName = "FirstName";
            col2.Name = "FirstName";
            DgPatientsAdd.Columns.Add(col2);


            col3.HeaderText = "שם משפחה";
            col3.DataPropertyName = "LastName";
            col3.Name = "LastName";
            DgPatientsAdd.Columns.Add(col3);

            col4.Name = "Active";
            col4.DataPropertyName = "Active";
            col4.HeaderText = "משתתף";
            col4.FalseValue = false;
            col4.TrueValue = true;
            DgPatientsAdd.Columns.Insert(0, col4);

            TxtWrittenByAdd.Text = Globals.ConnectedUserName;
            TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
       

            CmbMeetingNumberUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingNumberUpdate.DisplayMember = "AppointmentNumber";
            CmbMeetingNumberUpdate.ValueMember = "AppointmentNumber";

            ClinicTableAdapters.WorkersTableAdapter daWorker = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers1 = daWorker.GetDataByActiveWorkers();
            Clinic.WorkersDataTable dtWorkers2 = new Clinic.WorkersDataTable();
            Clinic.WorkersDataTable dtWorkers3 = daWorker.GetDataByActiveWorkers();
            Clinic.WorkersDataTable dtWorkers4 = new Clinic.WorkersDataTable();


            DataRow row = dtWorkers2.NewRow();
            row["ID"] = 0;
            row["FullName"] = "";
            dtWorkers2.Rows.InsertAt(row, 0);
            dtWorkers2.Merge(daWorker.GetDataByActiveWorkers());

            DataRow row2 = dtWorkers4.NewRow();
            row2["ID"] = 0;
            row2["FullName"] = "";
            dtWorkers4.Rows.InsertAt(row2, 0);
            dtWorkers4.Merge(daWorker.GetDataByActiveWorkers());
       
            CmbMainTherapistAdd.DataSource = dtWorkers1;
            CmbSecondTherapistAdd.DataSource = dtWorkers2;
            CmbMainTherapistUpdate.DataSource = dtWorkers3;
            CmbSecondTherapistUpdate.DataSource = dtWorkers4;
            CmbSecondTherapistAdd.SelectedIndex = 0;
            CmbSecondTherapistUpdate.SelectedIndex = 0;

            CmbMainTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistAdd.DisplayMember = "FullName";
            CmbMainTherapistAdd.ValueMember = "ID";
            
            CmbSecondTherapistAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistAdd.DisplayMember = "FullName";
            CmbSecondTherapistAdd.ValueMember = "ID";


            CmbMainTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMainTherapistUpdate.DisplayMember = "FullName";
            CmbMainTherapistUpdate.ValueMember = "ID";

     
            CmbSecondTherapistUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbSecondTherapistUpdate.DisplayMember = "FullName";
            CmbSecondTherapistUpdate.ValueMember = "ID";

     

            CmbDateUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbDateUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbDateUpdate.DisplayMember = "Date";
            CmbDateUpdate.ValueMember = "Date";


            CmbMeetingNumberUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingNumberUpdate.DisplayMember = "AppointmentNumber";
            CmbMeetingNumberUpdate.ValueMember = "AppointmentNumber";

            HourPickerStartAdd.ShowUpDown = true;
            HourPickerStartAdd.Format = DateTimePickerFormat.Custom;
            HourPickerStartAdd.CustomFormat = "HH:mm:ss";


            HourPickerStartUpdate.ShowUpDown = true;
            HourPickerStartUpdate.Format = DateTimePickerFormat.Custom;
            HourPickerStartUpdate.CustomFormat = "HH:mm:ss";

            CmbMeetingTypeAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMeetingTypeAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingTypeAdd.DisplayMember = "Name";
            CmbMeetingTypeAdd.ValueMember = "ID";

            CmbMeetingTypeUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMeetingTypeUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingTypeUpdate.DisplayMember = "Name";
            CmbMeetingTypeUpdate.ValueMember = "AppointmentType";


            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn col8 = new DataGridViewCheckBoxColumn();

            DgPatientsUpdate.AutoGenerateColumns = false;
            col5.HeaderText = "תעודת זהות";
            col5.DataPropertyName = "PatientID";
            col5.Name = "PatientID";
            DgPatientsUpdate.Columns.Add(col5);

            col6.HeaderText = "שם פרטי";
            col6.DataPropertyName = "FirstName";
            col6.Name = "FirstName";
            DgPatientsUpdate.Columns.Add(col6);


            col7.HeaderText = "שם משפחה";
            col7.DataPropertyName = "LastName";
            col7.Name = "LastName";
            DgPatientsUpdate.Columns.Add(col7);

            col8.Name = "Active";
            col8.HeaderText = "משתתף";
            col8.FalseValue = false;
            col8.TrueValue = true;
            col8.DataPropertyName = "Active";
            DgPatientsUpdate.Columns.Add(col8);
        }

        private void BtnAddNewMeeting_Click(object sender, EventArgs e)
        {

            ClinicTableAdapters.AppointmentsTableAdapter daAp = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAForPatients = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            Clinic.AppointmentsDataTable dtAp = daAp.GetDataByGroupNumberAndAppointmentNumber((int) CmbGroupIDAdd.SelectedValue,Int32.Parse(txtMeetingNumberAdd.Text));
            if (dtAp.Count > 0)
            {
                MessageBox.Show("טיפול כבר קיים");
                return;
            }
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(this.TxtDateAdd.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }
            DateTime dt = HourPickerStartAdd.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            int id = System.Convert.ToInt32(daAp.InsertQuery(Int32.Parse(txtMeetingNumberAdd.Text), (int)CmbGroupIDAdd.SelectedValue, (int)CmbMeetingTypeAdd.SelectedValue, rs, st.ToString(), (int)CmbMainTherapistAdd.SelectedValue, (int)CmbSecondTherapistAdd.SelectedValue, TxtNotesAdd.Text, TxtSummaryAdd.Text, Globals.ConnectedUserID, null, DateTime.Now, null, null, null, null, null, null, null, null, null, null));
            foreach (DataGridViewRow row in DgPatientsAdd.Rows)
            {
                bool result;
                if (row.Cells["Active"].Value != null)
                    result = row.Cells["Active"].Value.ToString() == "True";
                else result = false;

                daAForPatients.Insert(id, (int)CmbMeetingTypeAdd.SelectedValue, Int32.Parse(row.Cells["ID"].Value.ToString()), result);
            }

            MessageBox.Show("טיפול נוסף בהצלחה");
            TxtNotesAdd.Clear();
            TxtSummaryAdd.Clear();


        }

        


        private void CmbGroupIDAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.PatientsTableAdapter da = new ClinicTableAdapters.PatientsTableAdapter();
            DgPatientsAdd.DataSource = da.GetDataByPatientIDInnerJoinPatients((int)CmbGroupIDAdd.SelectedValue);

            ClinicTableAdapters.AppointmentsTableAdapter daAp = new ClinicTableAdapters.AppointmentsTableAdapter();
            if (daAp.GetMaxAppointmentNumber((int)CmbGroupIDAdd.SelectedValue) == null)
                txtMeetingNumberAdd.Text = "1";
            else
                txtMeetingNumberAdd.Text = (daAp.GetMaxAppointmentNumber((int)CmbGroupIDAdd.SelectedValue) + 1).ToString();
                    }

       
        private void CmbGroupIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            if (CmbGroupIdUpdate.Items.Count > 0)
                if (CmbGroupIdUpdate.SelectedIndex != -1)
                {
                    Clinic.AppointmentsDataTable dt = da.GetAppointmentsTypesByGroupNumber((int)CmbGroupIdUpdate.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        CmbMeetingTypeUpdate.DataSource = dt;
                        CmbMeetingTypeUpdate.SelectedIndex = 0;
                    }
                    else
                    {
                        TxtRemarksUpdate.Text = String.Empty;
                        TxtSummaryUpdate.Text = String.Empty;
                        TxtWrittenByDateUpdate.Text = String.Empty;
                        TxtWrittenByUpdate.Text = String.Empty;
                        if (DgPatientsUpdate.Rows.Count > 0)
                            DgPatientsUpdate.DataSource = null;

                    }
            
                }
        }

        private void CmbMeetingNumberUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAFP = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();

            if (CmbMeetingNumberUpdate.Items.Count > 0)
            {
                if (CmbMeetingNumberUpdate.SelectedIndex != -1)
                {
                    Clinic.AppointmentsDataTable dt = da.GetDataByGroupNumberAppointmentTypeAppointmentNumberDate((int)CmbGroupIdUpdate.SelectedValue,(int)CmbMeetingTypeUpdate.SelectedValue, (int)CmbMeetingNumberUpdate.SelectedValue,(DateTime)CmbDateUpdate.SelectedValue);
                    if (dt.Rows.Count > 0)
                    {
                        DgPatientsUpdate.DataSource = daAFP.GetDataByAppointmentNumbrInnerJoinPatients(Int32.Parse(dt.Rows[0]["ID"].ToString()));

                        TxtRemarksUpdate.Text = dt.Rows[0]["Notes"].ToString();
                        TxtSummaryUpdate.Text = dt.Rows[0]["Summary"].ToString();
                        DateTime date = DateTime.Parse(dt.Rows[0]["AddedByDate"].ToString());
                        TxtWrittenByDateUpdate.Text = date.ToString("dd/MM/yyyy HH:mm:ss");
                        TxtWrittenByUpdate.Text = daWorkers.GetFullNameByID(Int32.Parse(dt.Rows[0]["AddedBy"].ToString()));
                        CmbMeetingTypeUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["AppointmentType"].ToString());
                        CmbMainTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["MainTherapist"].ToString());
                        CmbSecondTherapistUpdate.SelectedValue = Int32.Parse(dt.Rows[0]["SecondTherapist"].ToString());
                        DateTime Dates = new DateTime();

                        if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedByDate"]))
                        {
                            Dates = (DateTime)dt.Rows[0]["UpdatedByDate"];
                            TxtUpdatedByDateUpdate.Text = Dates.ToString("dd/MM/yyyy HH:mm:ss");

                        }
                        if (!DBNull.Value.Equals(dt.Rows[0]["UpdatedBy"]))
                        {
                            TxtUpdatedByUpdate.Text = daWorkers.GetFullNameByID((int)dt.Rows[0]["UpdatedBy"]);

                        }

                    }
                    else
                    {

                        TxtRemarksUpdate.Text = String.Empty;
                        TxtSummaryUpdate.Text = String.Empty;
                        TxtWrittenByDateUpdate.Text = String.Empty;
                        TxtWrittenByUpdate.Text = String.Empty;
                        TxtUpdatedByDateUpdate.Text = String.Empty;
                        TxtUpdatedByUpdate.Text = String.Empty;
                        DgPatientsUpdate.Rows.Clear();


                    }
                }

            }
            else
                CmbMeetingNumberUpdate.Items.Clear();
      }

        private void TabGroupsMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter daAppointments = new ClinicTableAdapters.AppointmentsTableAdapter();
            Clinic.AppointmentsDataTable dt = daAppointments.GetDataByGroupsWithAppointments();
            CmbGroupIdUpdate.DataSource = dt;
            CmbGroupNameUpdate.DataSource = dt;
        }

        private void BtnUpdateMeeting_Click(object sender, EventArgs e)
        {

            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAFP = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            Clinic.AppointmentsDataTable dtApp = da.GetDataByGroupNumberAppointmentTypeAppointmentNumberDate((int)CmbGroupIdUpdate.SelectedValue,(int)CmbMeetingTypeUpdate.SelectedValue,(int)CmbMeetingNumberUpdate.SelectedValue,(DateTime)CmbDateUpdate.SelectedValue);
            int appId = Int32.Parse(dtApp.Rows[0]["ID"].ToString());

            DateTime now = DateTime.Now;
            String date = now.ToString("dd/MM/yyyy HH:mm:ss");
            DateTime dt = HourPickerStartUpdate.Value;
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (!DateTime.TryParseExact(this.TxtDateUpdate.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                MessageBox.Show("יש להזין תאריך תקין");
                return;
            }


            da.UpdateQuery((int)CmbMeetingNumberUpdate.SelectedValue, (int)CmbGroupIdUpdate.SelectedValue, (int)CmbMeetingTypeUpdate.SelectedValue, rs, st.ToString(), (int)CmbMainTherapistUpdate.SelectedValue, (int)CmbSecondTherapistUpdate.SelectedValue, TxtRemarksUpdate.Text,
                TxtSummaryUpdate.Text, Globals.ConnectedUserID, now, null, null, null, null, null, null, null, null, null, appId);
            foreach (DataGridViewRow row in DgPatientsUpdate.Rows)
            {
                bool result;
                if (row.Cells["Active"].Value != null)
                    result = row.Cells["Active"].Value.ToString() == "True";
                else result = false;

                daAFP.UpdateQuery((int)CmbMeetingTypeUpdate.SelectedValue, result, appId);
            }

            MessageBox.Show("טיפול עודכן בהצלחה");
        }

        private void CmbDateUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            Clinic.AppointmentsDataTable dt = da.GetDataByGroupIDAppointmentTypeAndDAte((int)CmbGroupIdUpdate.SelectedValue, (int)CmbMeetingTypeUpdate.SelectedValue, (DateTime)CmbDateUpdate.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                CmbMeetingNumberUpdate.DataSource = dt;
                DateTime d = (DateTime)CmbDateUpdate.SelectedValue;
                TxtDateUpdate.Text = d.ToString("dd/MM/yyyy");
            }
            else
            {

                TxtRemarksUpdate.Text = String.Empty;
                TxtSummaryUpdate.Text = String.Empty;
                TxtWrittenByDateUpdate.Text = String.Empty;
                TxtWrittenByUpdate.Text = String.Empty;
                DgPatientsUpdate.Rows.Clear();
                TxtDateUpdate.Text = string.Empty;


            }
        }

        private void CmbMeetingTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            Clinic.AppointmentsDataTable dt = da.GetDataByGroupNumberAndAppointmentType((int)CmbGroupIdUpdate.SelectedValue,(int)CmbMeetingTypeUpdate.SelectedValue);
            if (dt.Rows.Count > 0)
                CmbDateUpdate.DataSource = dt;
            else
            {

                TxtRemarksUpdate.Text = String.Empty;
                TxtSummaryUpdate.Text = String.Empty;
                TxtWrittenByDateUpdate.Text = String.Empty;
                TxtWrittenByUpdate.Text = String.Empty;
                DgPatientsUpdate.Rows.Clear();


            }
        }


}
}