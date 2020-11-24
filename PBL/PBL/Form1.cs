using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home bahay = new Home();
            bahay.Show();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetAppointment appointment = new SetAppointment();
            appointment.Show();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExistingAppointment look = new ExistingAppointment();
            look.Show();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar date = new Calendar();
            date.Show();
        }

        private void guidelinesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationGuidelines guide = new RegistrationGuidelines();
            guide.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationGuidelines guide = new RegistrationGuidelines();
            guide.Show();
        }

        private void Form1_Load(object sender, EventArgs e)// indeeeee poano ba to tong code lang kita ko HAHAHAHA pagaralan nalang natin to para sure// ung buong folder ung olal
        {
            // turo mo nalang sa kin pano idownload to tas lagay sa gdrive ahhahahah parang ang
            // sige sige wait
        }
    }
}
