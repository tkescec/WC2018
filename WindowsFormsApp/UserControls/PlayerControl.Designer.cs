namespace WindowsFormsApp.UserControls
{
    partial class PlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerControl));
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbYellowCard = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbPlayerPosition = new System.Windows.Forms.Label();
            this.lbPlayerNumber = new System.Windows.Forms.Label();
            this.pbFavorit = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbPlayerName.Location = new System.Drawing.Point(92, -1);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(215, 32);
            this.lbPlayerName.TabIndex = 2;
            this.lbPlayerName.Text = "Mirko Zlikovski";
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYellowCard
            // 
            this.lbYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowCard.Image = global::WindowsFormsApp.Properties.Resources.yellowCard;
            this.lbYellowCard.Location = new System.Drawing.Point(306, 99);
            this.lbYellowCard.Name = "lbYellowCard";
            this.lbYellowCard.Size = new System.Drawing.Size(50, 50);
            this.lbYellowCard.TabIndex = 6;
            this.lbYellowCard.Text = "1";
            this.lbYellowCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGoals
            // 
            this.lbGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoals.ForeColor = System.Drawing.Color.Black;
            this.lbGoals.Image = ((System.Drawing.Image)(resources.GetObject("lbGoals.Image")));
            this.lbGoals.Location = new System.Drawing.Point(326, 0);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(30, 30);
            this.lbGoals.TabIndex = 5;
            this.lbGoals.Text = "1";
            this.lbGoals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerPosition
            // 
            this.lbPlayerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerPosition.Image = ((System.Drawing.Image)(resources.GetObject("lbPlayerPosition.Image")));
            this.lbPlayerPosition.Location = new System.Drawing.Point(121, 49);
            this.lbPlayerPosition.Name = "lbPlayerPosition";
            this.lbPlayerPosition.Size = new System.Drawing.Size(100, 100);
            this.lbPlayerPosition.TabIndex = 4;
            this.lbPlayerPosition.Text = "Midfielder";
            this.lbPlayerPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerNumber
            // 
            this.lbPlayerNumber.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerNumber.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPlayerNumber.Image = ((System.Drawing.Image)(resources.GetObject("lbPlayerNumber.Image")));
            this.lbPlayerNumber.Location = new System.Drawing.Point(217, 48);
            this.lbPlayerNumber.Name = "lbPlayerNumber";
            this.lbPlayerNumber.Size = new System.Drawing.Size(100, 100);
            this.lbPlayerNumber.TabIndex = 3;
            this.lbPlayerNumber.Text = "10";
            this.lbPlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFavorit
            // 
            this.pbFavorit.Image = ((System.Drawing.Image)(resources.GetObject("pbFavorit.Image")));
            this.pbFavorit.Location = new System.Drawing.Point(0, 0);
            this.pbFavorit.Name = "pbFavorit";
            this.pbFavorit.Size = new System.Drawing.Size(40, 40);
            this.pbFavorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFavorit.TabIndex = 1;
            this.pbFavorit.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(-3, 15);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(120, 150);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbYellowCard);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.lbPlayerPosition);
            this.Controls.Add(this.lbPlayerNumber);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.pbFavorit);
            this.Controls.Add(this.pbPlayer);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(355, 148);
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbFavorit;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbPlayerNumber;
        private System.Windows.Forms.Label lbPlayerPosition;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbYellowCard;
    }
}
