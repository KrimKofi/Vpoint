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
    public partial class GroupAppointment : Form
    {
        public GroupAppointment()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            // may startup app na ba itu
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            decimal x = numberOfAppointees.Value;
            int count = 0;
            bool entered = true;
            while (x>=0)
            {
                x--;
                count++;
                IndividualAppointment individualAppointment = new IndividualAppointment();
                if (entered && x!=0)
                {
                    individualAppointment.Show();
                    entered = false;
                    if (IndividualAppointment.allPopulated)
                    {
                        entered = true;
                    }
                }
                if (count == numberOfAppointees.Value)
                {
                    break;
                }
            }
            SetAppointment setAppointment = new SetAppointment();
            setAppointment.Show();

        }

        private void GroupAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
