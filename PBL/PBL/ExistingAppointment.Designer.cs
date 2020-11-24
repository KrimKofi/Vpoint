namespace PBL
{
    partial class ExistingAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterEmailLabel = new System.Windows.Forms.Label();
            this.enterEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterAppointmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterEmailLabel
            // 
            this.enterEmailLabel.AutoSize = true;
            this.enterEmailLabel.Location = new System.Drawing.Point(182, 92);
            this.enterEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterEmailLabel.Name = "enterEmailLabel";
            this.enterEmailLabel.Size = new System.Drawing.Size(63, 13);
            this.enterEmailLabel.TabIndex = 0;
            this.enterEmailLabel.Text = "Enter Email:";
            // 
            // enterEmailTextBox
            // 
            this.enterEmailTextBox.Location = new System.Drawing.Point(249, 92);
            this.enterEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterEmailTextBox.Name = "enterEmailTextBox";
            this.enterEmailTextBox.Size = new System.Drawing.Size(216, 20);
            this.enterEmailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Appointment Code:";
            // 
            // enterAppointmentCodeTextBox
            // 
            this.enterAppointmentCodeTextBox.Location = new System.Drawing.Point(249, 120);
            this.enterAppointmentCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterAppointmentCodeTextBox.Name = "enterAppointmentCodeTextBox";
            this.enterAppointmentCodeTextBox.Size = new System.Drawing.Size(216, 20);
            this.enterAppointmentCodeTextBox.TabIndex = 3;
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Location = new System.Drawing.Point(266, 175);
            this.viewDetailsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(114, 45);
            this.viewDetailsButton.TabIndex = 4;
            this.viewDetailsButton.Text = "VIEW DETAILS";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            // 
            // ExistingAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 621);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.enterAppointmentCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterEmailTextBox);
            this.Controls.Add(this.enterEmailLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExistingAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistingAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterEmailLabel;
        private System.Windows.Forms.TextBox enterEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterAppointmentCodeTextBox;
        private System.Windows.Forms.Button viewDetailsButton;
    }
}