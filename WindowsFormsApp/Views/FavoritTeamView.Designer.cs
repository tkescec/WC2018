namespace WindowsFormsApp.Views
{
    partial class FavoritTeamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritTeamView));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblFTPaneltext = new System.Windows.Forms.Label();
            this.lbSettingsTeam = new System.Windows.Forms.ListBox();
            this.btnSettingsBack = new System.Windows.Forms.Button();
            this.btnSettingsFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // pbCover
            // 
            this.pbCover.Image = global::WindowsFormsApp.Properties.Resources.cover;
            resources.ApplyResources(this.pbCover, "pbCover");
            this.pbCover.Name = "pbCover";
            this.pbCover.TabStop = false;
            // 
            // lblFTPaneltext
            // 
            resources.ApplyResources(this.lblFTPaneltext, "lblFTPaneltext");
            this.lblFTPaneltext.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFTPaneltext.Name = "lblFTPaneltext";
            // 
            // lbSettingsTeam
            // 
            this.lbSettingsTeam.FormattingEnabled = true;
            resources.ApplyResources(this.lbSettingsTeam, "lbSettingsTeam");
            this.lbSettingsTeam.Name = "lbSettingsTeam";
            this.lbSettingsTeam.SelectedValueChanged += new System.EventHandler(this.SettingsTeam_SelectedValueChanged);
            // 
            // btnSettingsBack
            // 
            resources.ApplyResources(this.btnSettingsBack, "btnSettingsBack");
            this.btnSettingsBack.Name = "btnSettingsBack";
            this.btnSettingsBack.UseVisualStyleBackColor = true;
            this.btnSettingsBack.Click += new System.EventHandler(this.SettingsBack_Click);
            // 
            // btnSettingsFinish
            // 
            resources.ApplyResources(this.btnSettingsFinish, "btnSettingsFinish");
            this.btnSettingsFinish.Name = "btnSettingsFinish";
            this.btnSettingsFinish.UseVisualStyleBackColor = true;
            this.btnSettingsFinish.Click += new System.EventHandler(this.SettingsFinish_Click);
            // 
            // FavoritTeamView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettingsBack);
            this.Controls.Add(this.btnSettingsFinish);
            this.Controls.Add(this.lbSettingsTeam);
            this.Controls.Add(this.lblFTPaneltext);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbCover);
            this.Name = "FavoritTeamView";
            this.Load += new System.EventHandler(this.FavoritTeamView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblFTPaneltext;
        private System.Windows.Forms.ListBox lbSettingsTeam;
        private System.Windows.Forms.Button btnSettingsBack;
        private System.Windows.Forms.Button btnSettingsFinish;
    }
}
