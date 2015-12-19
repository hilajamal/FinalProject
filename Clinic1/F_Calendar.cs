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
    public partial class F_Calendar : Form
    {
        public F_Calendar()
        {
            InitializeComponent();
            setLook();
        }
        
        private void setLook()
        {

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddDays(1);
            double duration = 15;
            string morning = "";
            string afternon = "";
            while (true)
            {
                DateTime dtNext = start.AddMinutes(duration);
                if (start > end || dtNext > end)
                    break;
                if (start < DateTime.Parse("12:00 PM"))
                {
                    morning += start.ToShortTimeString() + "-" + dtNext.ToShortTimeString() + "<br>";
                }
                else
                {
                    afternon += start.ToShortTimeString() + "-" + dtNext.ToShortTimeString() + "<br>";
                }
                start = dtNext;
            }
            if (morning.Length > 0)
                morning = "<B>Morning</B><BR>" + morning;
            if (afternon.Length > 0)
                afternon = "<B>Afternon</B><BR>" + afternon;
            Label lbl = new Label();
            lbl.Text = morning + afternon;
            this.Controls.Add(lbl);

        }
    }


}
