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
    public partial class Calendar : Form
    {
        DateTime date = new DateTime();
        DateTime currentTime = DateTime.Now;
        DateTime currentDay = DateTime.Today;
        int day= DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        int daysOftheMonth;
        public static int NumberOfWeeks(DateTime date)//gets ilang weeks for a month
        { 
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }
        public static int numberOfDays(int year,int month)//finds ilang araw per month
        {
            int days = DateTime.DaysInMonth(year, month) + 1;
            return days;
        }
        public static void createDaysofMonth(int year, int month)//dito dapat gagawin ung each label/panel(still choosing which)
        {
            int daysOftheMonth = numberOfDays(year, month);
            flowLayoutPanel2.Controls.Clear();
            for (int i = 1; i < daysOftheMonth; i++)
            {

                Label daysLabel = new Label();
                daysLabel.Text = i.ToString();
                flowLayoutPanel2.Controls.Add(daysLabel);
            }
        }
        public Calendar()
        {
            InitializeComponent();
            label13.Text = new DateTime(year,month,day).ToString("MMMM");
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void pictureBox2_Click(object sender, EventArgs e)//disregard this muna
        {
            currentTime.AddMonths(1).ToString("MMMM");
            label13.Text = currentTime.ToString("MMMM");
        }

        private void button1_Click(object sender, EventArgs e)//forward to months
        {
            DateTime chooseDate = new DateTime(year, month, day);
            month++;
            if (month == 12)//checks if december na then babalik sa january pero ibang year
            {
                year++;
                month = 1;
            }
            NumberOfWeeks(chooseDate);
            createDaysofMonth(year, month);
            label13.Text = new DateTime(year, month, day).ToString("MMMM");
           
        }

        private void button2_Click(object sender, EventArgs e)//go back to other months
        {
            month--;
            if (month == 1)//checks if its january then babalik ng year
            {
                year--;
                month = 12;
            }

            label13.Text = new DateTime(year, month, day).ToString("MMMM");//eto ung month title
    
        }

        private void bunifuGradientPanel40_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
