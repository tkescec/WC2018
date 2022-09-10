namespace WindowsFormsApp.UserControls
{
    partial class MatchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbAttendance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.soccer_field;
            this.pictureBox1.Location = new System.Drawing.Point(204, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbLocation
            // 
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.IndianRed;
            this.lbLocation.Location = new System.Drawing.Point(204, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(342, 30);
            this.lbLocation.TabIndex = 1;
            this.lbLocation.Text = "New England";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAttendance
            // 
            this.lbAttendance.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttendance.Location = new System.Drawing.Point(337, 135);
            this.lbAttendance.Name = "lbAttendance";
            this.lbAttendance.Size = new System.Drawing.Size(77, 23);
            this.lbAttendance.TabIndex = 2;
            this.lbAttendance.Text = "54665";
            this.lbAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home Team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(552, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Away Team";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeTeam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTeam.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHomeTeam.Location = new System.Drawing.Point(-4, 77);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(193, 23);
            this.lblHomeTeam.TabIndex = 5;
            this.lblHomeTeam.Text = "England";
            this.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblAwayTeam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayTeam.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAwayTeam.Location = new System.Drawing.Point(546, 77);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(193, 23);
            this.lblAwayTeam.TabIndex = 6;
            this.lblAwayTeam.Text = "England";
            this.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAttendance);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MatchControl";
            this.Size = new System.Drawing.Size(743, 168);
            this.Load += new System.EventHandler(this.MatchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
    }
}
