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
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointees)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(285, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 17);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Number of Appointees";
            // 
            // numberOfAppointees
            // 
            this.numberOfAppointees.Location = new System.Drawing.Point(456, 95);
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
            this.numberOfAppointees.Size = new System.Drawing.Size(46, 22);
            this.numberOfAppointees.TabIndex = 4;
            this.numberOfAppointees.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfAppointees.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GroupAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 405);
            this.Controls.Add(this.numberOfAppointees);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "GroupAppointment";
            this.Text = "GroupAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAppointees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.NumericUpDown numberOfAppointees;
    }
}