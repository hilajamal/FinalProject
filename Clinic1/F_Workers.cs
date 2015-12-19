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
    public partial class F_Workers : Form
    {
        public F_Workers()
        {
            InitializeComponent();
            AddCols();
            fillDataTable();
        }

        public void fillDataTable()
        {
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            Clinic.WorkersDataTable dtWorkers = daWorkers.GetData();
            DgWorkers.DataSource = dtWorkers.DefaultView;

        }
        public void AddCols()
        {
            DgWorkers.AutoGenerateColumns = false;
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewTextBoxColumn();
            var col4 = new DataGridViewTextBoxColumn();
            var col5 = new DataGridViewCheckBoxColumn();

            col1.HeaderText = "תעודת זהות";
            col1.DataPropertyName = "ID";
            col1.Name = "ID";
            DgWorkers.Columns.Add(col1);

            col2.HeaderText = "שם פרטי";
            col2.DataPropertyName = "FirstName";
            col2.Name = "FirstName";
            DgWorkers.Columns.Add(col2);

            col3.HeaderText = "שם משפחה";
            col3.DataPropertyName = "LastName";
            col3.Name = "LastName";
            DgWorkers.Columns.Add(col3);

            col4.HeaderText = "שם מלא";
            col4.DataPropertyName = "FullName";
            col4.Name = "FullName";
            DgWorkers.Columns.Add(col4);

            col5.HeaderText = "פעיל";
            col5.DataPropertyName = "Active";
            col5.Name = "Active";
            DgWorkers.Columns.Add(col5);

            DgWorkers.Columns["FullName"].Visible = false;

        }

        private void BtnAddNewWorker_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.PermissionTypeTableAdapter da = new ClinicTableAdapters.PermissionTypeTableAdapter();
            CmbPermissions.DataSource = da.GetData();
            CmbPermissions.SelectedIndex = 0;
            CmbPermissions.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPermissions.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPermissions.DisplayMember = "Name";
            CmbPermissions.ValueMember = "ID";
            CmbPermissions.DataSource = da.GetData();
            BtnAddNewWorker.Visible = false;
            DgWorkers.Visible = false;
            BtnExitNoSave.Visible = true;
            btnEditWorkers.Visible = false;
            BtnSave.Visible = true;
            BtnPermissions.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.WorkersTableAdapter daWorkers = new ClinicTableAdapters.WorkersTableAdapter();
            if (!ValidateWorkerTextBox() == false)
            {
                String fullname = TxtFirstName.Text + " " + TxtLastName.Text;
                Clinic.WorkersDataTable workerCheck = new Clinic.WorkersDataTable();
                workerCheck = daWorkers.GetDataByID(Int32.Parse(TxtID.Text));
                if (workerCheck.Rows.Count == 0)
                {
                    int perm = Int32.Parse(CmbPermissions.SelectedValue.ToString());
                    daWorkers.Insert(Int32.Parse(TxtID.Text), TxtFirstName.Text, fullname, TxtLastName.Text, perm, true);
                    BtnAddNewWorker.Visible = true;
                    BtnPermissions.Visible = true;
                    workerCheck = daWorkers.GetData();
                    DgWorkers.DataSource = workerCheck;
                    DgWorkers.Refresh();
                    DgWorkers.Visible = true;
                    BtnExitNoSave.Visible = false;
                    BtnSave.Visible = false;
                    btnEditWorkers.Visible = true;
                    ClearTextBox();
                }
                else
                    MessageBox.Show("עובד עם תעודת זהות זו כבר קיים במערכת.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
        }


        private void ClearTextBox()
        {
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text   = string.Empty;
            TxtID.Text   = string.Empty;
            TxtPassword.Text = string.Empty;

            if (CmbPermissions.Items.Count > 0)
                CmbPermissions.SelectedIndex = 0;

            
        }


        private Boolean ValidateWorkerTextBox(){
              StringBuilder str = new StringBuilder();
            str.Append(" הוסף " );
            Boolean HasErrors = false; //במידה והמשתמש מילא את כל הפרטים לא נדפיס הודעה
            Boolean First_ItemNull = false; //בהוספה ראשונה נשמיט את הפסיק
            int outVal;
            if (!Int32.TryParse(TxtID.Text, out outVal))
            {
                str.Append(" תעודת זהות");
                HasErrors = true;
                First_ItemNull = true;
            }

            if (TxtFirstName.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם פרטי");
                }
                else
                {
                    str.Append(" שם פרטי");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtLastName.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם משפחה");
                }
                else
                {
                    str.Append(" שם משפחה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            
            if (TxtPassword.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", סיסמה");
                }
                else
                {
                    str.Append(" סיסמה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            if (CmbPermissions.SelectedIndex == -1)
            {
                if (First_ItemNull == true)
                {
                    str.Append(", הרשאה");
                }
                else
                {
                    str.Append(" הרשאה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (HasErrors)
            {
                MessageBox.Show(str.ToString());
                return false; //אם חסרים פרטים בשורה יש לבצע את בדיקת התקינות שוב
            }

            return true; //אחרת-אם כל השורה מולאה אל תבצע את בדיקת התקינות שוב

        }

        private void BtnExitNoSave_Click(object sender, EventArgs e)
        {
            DgWorkers.Visible = true;
            BtnAddNewWorker.Visible = true;
            BtnPermissions.Visible = true;
            BtnExitNoSave.Visible = false;
            BtnSave.Visible = false;
            btnEditWorkers.Visible = true;
            ClearTextBox();
        }

        private void btnEditWorkers_Click(object sender, EventArgs e)
        {
            ShowEditMode();
        }

        private void ShowEditMode()
        {
            btnEditWorkers.Visible = false;
            BtnPermissions.Visible = false;
            BtnAddNewWorker.Visible = false;
            DgWorkers.Enabled = true;
            DgWorkers.ReadOnly = false;
            DgWorkers.AllowUserToAddRows = false;
            DgWorkers.AllowUserToDeleteRows = false;
            BtnExitNoSaveEditting.Visible = true;
            btnSaveEditing.Visible = true;

        }

        private void HideEditMode()
        {
            btnEditWorkers.Visible = true;
            BtnPermissions.Visible = true;
            BtnAddNewWorker.Visible = true;
            DgWorkers.ReadOnly = true;
            BtnExitNoSaveEditting.Visible = false;
            btnSaveEditing.Visible = false;

        }

        private void BtnExitNoSaveEditting_Click(object sender, EventArgs e)
        {
            HideEditMode();
        }

        private Boolean ValidateWorkersRow(DataGridViewRow row, int index)
        {
            StringBuilder str = new StringBuilder();
            str.Append(" הוסף בשורה " + index + 1 );
            Boolean HasErrors = false; //במידה והמשתמש מילא את כל הפרטים לא נדפיס הודעה
            Boolean First_ItemNull = false; //בהוספה ראשונה נשמיט את הפסיק
            if (DgWorkers.Rows[index].Cells[0].Value == System.DBNull.Value)
            {
                str.Append(" תעודת זהות");
                HasErrors = true;
                First_ItemNull = true;
            }

            if (DgWorkers.Rows[index].Cells[1].Value == System.DBNull.Value)
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם פרטי");
                }
                else
                {
                    str.Append(" שם פרטי");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (DgWorkers.Rows[index].Cells[2].Value == System.DBNull.Value)
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם משפחה");
                }
                else
                {
                    str.Append(" שם משפחה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (HasErrors)
            {
                MessageBox.Show(str.ToString());
                return false; //אם חסרים פרטים בשורה יש לבצע את בדיקת התקינות שוב
            }

            return true; //אחרת-אם כל השורה מולאה אל תבצע את בדיקת התקינות שוב

        }

        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
            ClinicTableAdapters.WorkersTableAdapter da = new ClinicTableAdapters.WorkersTableAdapter();
            string FullName;
            int index = 0;

            foreach (DataGridViewRow row in DgWorkers.Rows)
            {
                if (ValidateWorkersRow(row, index) == false)
                    return;
                else
                    FullName = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                row.Cells["FullName"].Value = FullName.ToString();
                index ++ ;
           }
       //     da.Fill(Clinic.WorkersDataTable);
               HideEditMode();
        }
























    }
}
