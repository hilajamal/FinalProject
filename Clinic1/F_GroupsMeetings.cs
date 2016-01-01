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
            CmbMeetingNumberUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingNumberUpdate.DisplayMember = "AppointmentNumber";
            CmbMeetingNumberUpdate.ValueMember = "AppointmentNumber";
            addCols();
            loaddata();
        }

        private void loaddata()
        {
            ClinicTableAdapters.GroupsTableAdapter daGroups = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dtGroups1 = daGroups.GetDataByGroupsWithAppointments();
            Clinic.GroupsDataTable dtGroups2 = daGroups.GetData();

        
            CmbGroupNameUpdate.DataSource = dtGroups1;
            CmbGroupIdUpdate.DataSource = dtGroups1;

            CmbGroupNameAdd.DataSource = dtGroups2;
            CmbGroupIDAdd.DataSource = dtGroups2;

            ClinicTableAdapters.AppointmentTypeTableAdapter daType = new ClinicTableAdapters.AppointmentTypeTableAdapter();
            CmbMeetingTypeAdd.DataSource = daType.GetData();
            CmbMeetingTypeUpdate.DataSource = daType.GetData();
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
            col4.HeaderText = "משתתף";
            col4.FalseValue = 0;
            col4.TrueValue = 1;
            DgPatientsAdd.Columns.Insert(0, col4);

            TxtWrittenByAdd.Text = Globals.ConnectedUserName;
            TxtWrittenByDateAdd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            TxtUpdatedByUpdate.Text = Globals.ConnectedUserName;
            TxtUpdatedByDateUpdate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            ClinicTableAdapters.WorkersTableAdapter daWorker = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers1 = daWorker.GetDataByActiveWorkers();
            Clinic.WorkersDataTable dtWorkers2 = daWorker.GetDataByActiveWorkers();
            Clinic.WorkersDataTable dtWorkers3 = daWorker.GetDataByActiveWorkers();
            Clinic.WorkersDataTable dtWorkers4 = daWorker.GetDataByActiveWorkers();
            
            CmbMainTherapistAdd.DataSource = dtWorkers1;
            CmbSecondTherapistAdd.DataSource = dtWorkers2;
            CmbMainTherapistUpdate.DataSource = dtWorkers3;
            CmbSecondTherapistUpdate.DataSource = dtWorkers4;


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


            CmbMeetingNumberUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingNumberUpdate.DisplayMember = "AppointmentNumber";
            CmbMeetingNumberUpdate.ValueMember = "AppointmentNumber";

            HourPickerStartAdd.ShowUpDown = true;
            HourPickerStartAdd.Format = DateTimePickerFormat.Custom;
            HourPickerStartAdd.CustomFormat = "HH:mm:ss";

            HourPickerEndAdd.ShowUpDown = true;
            HourPickerEndAdd.Format = DateTimePickerFormat.Custom;
            HourPickerEndAdd.CustomFormat = "HH:mm:ss";

            HourPickerStartUpdate.ShowUpDown = true;
            HourPickerStartUpdate.Format = DateTimePickerFormat.Custom;
            HourPickerStartUpdate.CustomFormat = "HH:mm:ss";

            HourPickerEndUpdate.ShowUpDown = true;
            HourPickerEndUpdate.Format = DateTimePickerFormat.Custom;
            HourPickerEndUpdate.CustomFormat = "HH:mm:ss";

            CmbMeetingTypeAdd.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMeetingTypeAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingTypeAdd.DisplayMember = "Name";
            CmbMeetingTypeAdd.ValueMember = "ID";

            CmbMeetingTypeUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbMeetingTypeUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbMeetingTypeUpdate.DisplayMember = "Name";
            CmbMeetingTypeUpdate.ValueMember = "ID";


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
            col8.FalseValue = 0;
            col8.TrueValue = 1;
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
            DateTime dt1 = DateTime.ParseExact(TxtWrittenByDateAdd.Text, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);


         int id = System.Convert.ToInt32(daAp.InsertQuery(Int32.Parse(txtMeetingNumberAdd.Text), (int)CmbGroupIDAdd.SelectedValue, (int)CmbMeetingTypeAdd.SelectedValue, HourPickerStartAdd.Value.ToString(), HourPickerEndAdd.Value.ToString(), (int)CmbMainTherapistAdd.SelectedValue, (int)CmbSecondTherapistAdd.SelectedValue, TxtNotesAdd.Text, TxtSummaryAdd.Text, Globals.ConnectedUserID, null, dt1, null));
            foreach (DataGridViewRow row in DgPatientsAdd.Rows)
            {
                bool result;
                if (row.Cells["Active"].Value != null)
                    result = Int32.Parse(row.Cells["Active"].Value.ToString()) == 1;
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
                    Clinic.AppointmentsDataTable dt = da.GetDataByGroupNumber((int)CmbGroupIdUpdate.SelectedValue);
                    if(dt.Rows.Count > 0)
                    CmbMeetingNumberUpdate.DataSource = dt;
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
                    Clinic.AppointmentsDataTable dt = da.GetDataByGroupNumberAndAppointmentNumber((int)CmbGroupIdUpdate.SelectedValue, (int)CmbMeetingNumberUpdate.SelectedValue);
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
                        

                    }
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
            else
                CmbMeetingNumberUpdate.Items.Clear();
      }

        private void TabGroupsMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClinicTableAdapters.GroupsTableAdapter da = new ClinicTableAdapters.GroupsTableAdapter();
            Clinic.GroupsDataTable dt = da.GetDataByGroupsWithAppointments();
            CmbGroupIdUpdate.DataSource = dt;
            CmbGroupNameUpdate.DataSource = dt;
        }

        private void BtnUpdateMeeting_Click(object sender, EventArgs e)
        {

            ClinicTableAdapters.AppointmentsTableAdapter da = new ClinicTableAdapters.AppointmentsTableAdapter();
            ClinicTableAdapters.AppointmentsForPatientsTableAdapter daAFP = new ClinicTableAdapters.AppointmentsForPatientsTableAdapter();
            Clinic.AppointmentsDataTable dtApp = da.GetDataByGroupNumberAndAppointmentNumber((int)CmbGroupIdUpdate.SelectedValue,(int)CmbMeetingNumberUpdate.SelectedValue);
            int appId = Int32.Parse(dtApp.Rows[0]["ID"].ToString());

            DateTime now = DateTime.Now;
            String date = now.ToString("dd/MM/yyyy HH:mm:ss");
            DateTime dt1 = DateTime.ParseExact(date, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            da.UpdateQuery((int)CmbMainTherapistUpdate.SelectedValue, (int)CmbSecondTherapistUpdate.SelectedValue, TxtRemarksUpdate.Text, TxtSummaryUpdate.Text, Globals.ConnectedUserID, dt1, (int)CmbGroupIdUpdate.SelectedValue, (int)CmbMeetingNumberUpdate.SelectedValue);
            foreach (DataGridViewRow row in DgPatientsUpdate.Rows)
            {
                bool result;
                if (row.Cells["Active"].Value != null)
                    result = Int32.Parse(row.Cells["Active"].Value.ToString()) == 1;
                else result = false;

                //daAFP.UpdateQuery(id, (int)CmbMeetingTypeAdd.SelectedValue, Int32.Parse(row.Cells["ID"].Value.ToString()), result);
                daAFP.UpdateQuery((int)CmbMeetingTypeUpdate.SelectedValue, result, appId);
            }

            MessageBox.Show("טיפול עודכן בהצלחה");
        }


}
}