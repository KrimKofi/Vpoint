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
    public partial class SetAppointment : Form
    {
        public SetAppointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndividualAppointment individualAppointment = new IndividualAppointment();
            individualAppointment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupAppointment groupAppointment = new GroupAppointment();
            groupAppointment.Show();
        }
    }
}
