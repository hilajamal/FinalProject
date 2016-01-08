using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;



namespace Clinic1
{
    public partial class F_MainForm : Form
    {
        public F_MainForm()
        {
            InitializeComponent();
            LblName.Text = "ברוך שובך, " + Globals.ConnectedUserName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calendar.NETDemo.Form1 calendar = new Calendar.NETDemo.Form1();
            //calendar.StartPosition = FormStartPosition.CenterScreen;
            //calendar.Show();

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("he-IL");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("he-IL");

       //    Jarloo.Calendar.TestApp.MainWindow c = new Jarloo.Calendar.TestApp.MainWindow();
      //     c.Show();

     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Contacts contacts = new F_Contacts();
            contacts.StartPosition = FormStartPosition.CenterScreen;
            contacts.Show();
        }

        private void BtnWorkers_Click(object sender, EventArgs e)
        {
            F_Workers workers = new F_Workers();
            workers.StartPosition = FormStartPosition.CenterScreen;
            workers.Show();
        }

        private void BtnGroups_Click(object sender, EventArgs e)
        {
            F_Groups groups = new F_Groups();
            groups.Show();
        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            F_Patients Patients = new F_Patients();
            Patients.Show();
        }

        private void btnGroupsMeetings_Click(object sender, EventArgs e)
        {
            F_GroupsMeetings groupsMeetings = new F_GroupsMeetings();
            groupsMeetings.Show();
        }

        private void btnIntake_Click(object sender, EventArgs e)
        {
            F_Intake intake = new F_Intake();
            intake.Show();
        }

        private void BtnIntakeBoard_Click(object sender, EventArgs e)
        {
            F_Intake_Board IntakeBoard = new F_Intake_Board();
            IntakeBoard.Show();
        }

        private void BtnPsycho_Click(object sender, EventArgs e)
        {
            F_Meetings f = new F_Meetings();
            f.Show();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            F_DoctorMeeting doctor = new F_DoctorMeeting();
            doctor.Show();
        }

     
    }
}
