using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarDemo;
using System.Windows.Forms.Calendar;

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
            CalendarDemo.DemoForm calendar = new CalendarDemo.DemoForm();
            calendar.StartPosition = FormStartPosition.CenterScreen;
            calendar.Show();

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
    }
}
