namespace PBL
{
    partial class Form1
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
            this.appointmentButton = new System.Windows.Forms.Button();
            this.lookUpButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentButton
            // 
            this.appointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentButton.Location = new System.Drawing.Point(160, 85);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(252, 68);
            this.appointmentButton.TabIndex = 1;
            this.appointmentButton.Text = "Set Appointment";
            this.appointmentButton.UseVisualStyleBackColor = true;
            this.appointmentButton.Click += new System.EventHandler(this.appointmentButton_Click);
            // 
            // lookUpButton
            // 
            this.lookUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookUpButton.Location = new System.Drawing.Point(160, 152);
            this.lookUpButton.Name = "lookUpButton";
            this.lookUpButton.Size = new System.Drawing.Size(252, 68);
            this.lookUpButton.TabIndex = 2;
            this.lookUpButton.Text = "Existing Appointment";
            this.lookUpButton.UseVisualStyleBackColor = true;
            this.lookUpButton.Click += new System.EventHandler(this.lookUpButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarButton.Location = new System.Drawing.Point(160, 219);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(252, 68);
            this.calendarButton.TabIndex = 3;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "see registration guidelines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(346, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.lookUpButton);
            this.Controls.Add(this.appointmentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button lookUpButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

