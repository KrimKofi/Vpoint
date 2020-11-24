namespace PBL
{
    partial class GroupAppointment
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numberOfAppointees = new System.Windows.Forms.NumericUpDown();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointees)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(433, 214);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(112, 13);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Number of Appointees";
            // 
            // numberOfAppointees
            // 
            this.numberOfAppointees.Location = new System.Drawing.Point(561, 214);
            this.numberOfAppointees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberOfAppointees.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfAppointees.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfAppointees.Name = "numberOfAppointees";
            this.numberOfAppointees.Size = new System.Drawing.Size(34, 20);
            this.numberOfAppointees.TabIndex = 4;
            this.numberOfAppointees.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfAppointees.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(488, 319);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(56, 19);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // GroupAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 621);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.numberOfAppointees);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GroupAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupAppointment";
            this.Load += new System.EventHandler(this.GroupAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.NumericUpDown numberOfAppointees;
        private System.Windows.Forms.Button nextButton;
    }
}