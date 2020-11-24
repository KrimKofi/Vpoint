using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PBL
{
    public partial class IndividualAppointment : Form
    {
        public string imgLoc = string.Empty;
        public static bool allPopulated;
        public IndividualAppointment()
        {
            InitializeComponent();
        }

        private void IndividualAppointment_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                imageButton.ImageLocation = imgLoc;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string lastNameString = lastNameTextbox.Text;
            string firstNameString = firstNameTextbox.Text;
            string middleNameString = middleNameTextbox.Text;
            string suffixString = suffixTextbox.Text;
            var comelecOfficeString = comelecOfficeComboBox.Text;
            string phoneNumberString = phoneNumberTextbox.Text;
            string emailAddressString = emailAddressTextbox.Text;
            var reasonForVisitString = reasonForVisitcomboBox.Text;
            DateTime datePicker = datepicker.Value;
            

            allPopulated = lastNameString != String.Empty && firstNameString != String.Empty && middleNameString != String.Empty && reasonForVisitString != String.Empty && datePicker!= null &&
                suffixString != String.Empty && comelecOfficeString != String.Empty && phoneNumberString != String.Empty && emailAddressString != String.Empty && imgLoc != string.Empty;

            if(allPopulated)
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = VPOINT;Integrated Security = true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string queryString = "INSERT INTO appointmentIdentities VALUES(@TimeSlot,@LastName,@FirstName,@MiddleName,@Suffix,@PhoneNumber,@EmailAddress,@ReasonForVisit,@COMELECOffice,@ValidID)";

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@FirstName";
                param1.Value = firstNameString;

                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@LastName";
                param2.Value = lastNameString;

                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@MiddleName";
                param3.Value = middleNameString;

                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@Suffix";
                param4.Value = suffixString;

                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@PhoneNumber";
                param5.Value = phoneNumberString;

                SqlParameter param6 = new SqlParameter();
                param6.ParameterName = "@EmailAddress";
                param6.Value = emailAddressString;

                SqlParameter param7 = new SqlParameter();
                param7.ParameterName = "@ValidID";
                param7.Value = img;

                SqlParameter param8 = new SqlParameter();
                param8.ParameterName = "@ReasonForVisit";
                param8.Value = reasonForVisitString;

                SqlParameter param9 = new SqlParameter();
                param9.ParameterName = "@COMELECOffice";
                param9.Value = comelecOfficeString;

                SqlParameter param10 = new SqlParameter();
                param10.ParameterName = "@Timeslot";
                param10.Value = datePicker;

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);
                command.Parameters.Add(param5);
                command.Parameters.Add(param6);
                command.Parameters.Add(param7);
                command.Parameters.Add(param8);
                command.Parameters.Add(param9);
                command.Parameters.Add(param10);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Ready to go.", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lastNameTextbox.Text = string.Empty;
                firstNameTextbox.Text = string.Empty;
                middleNameTextbox.Text = string.Empty;
                suffixTextbox.Text = string.Empty;
                phoneNumberTextbox.Text = string.Empty;
                emailAddressTextbox.Text = string.Empty;
                imageButton.ImageLocation = null;
                reasonForVisitcomboBox.Text = string.Empty;
                comelecOfficeComboBox.Text = string.Empty;

            }
            if (!allPopulated)
            {
                MessageBox.Show("Please fill out other details", "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void datepicker_onValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
