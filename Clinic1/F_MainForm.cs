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
            F_AddNewGroup groups = new F_AddNewGroup();
            groups.Show();
        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            F_AddNewPatient Patients = new F_AddNewPatient();
            Patients.Show();
        }
    }
}
