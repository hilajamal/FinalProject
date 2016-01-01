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
            ClinicTableAdapters.DiagnosesTableAdapter daDiagnose = new ClinicTableAdapters.DiagnosesTableAdapter();
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






        }

    }
}
