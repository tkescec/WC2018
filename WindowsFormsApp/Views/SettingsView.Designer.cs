namespace WindowsFormsApp.Views
{
    partial class SettingsView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblSettingsText = new System.Windows.Forms.Label();
            this.cbSettingsGender = new System.Windows.Forms.ComboBox();
            this.lblSettingsGender = new System.Windows.Forms.Label();
            this.cbSettingsLang = new System.Windows.Forms.ComboBox();
            this.lblSettingsLang = new System.Windows.Forms.Label();
            this.settingsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsViewModelBindingSource)).BeginInit();
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
            // lblSettingsText
            // 
            resources.ApplyResources(this.lblSettingsText, "lblSettingsText");
            this.lblSettingsText.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSettingsText.Name = "lblSettingsText";
            // 
            // cbSettingsGender
            // 
            this.cbSettingsGender.AllowDrop = true;
            this.cbSettingsGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsGender.FormattingEnabled = true;
            resources.ApplyResources(this.cbSettingsGender, "cbSettingsGender");
            this.cbSettingsGender.Name = "cbSettingsGender";
            // 
            // lblSettingsGender
            // 
            resources.ApplyResources(this.lblSettingsGender, "lblSettingsGender");
            this.lblSettingsGender.Name = "lblSettingsGender";
            // 
            // cbSettingsLang
            // 
            this.cbSettingsLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsLang.FormattingEnabled = true;
            resources.ApplyResources(this.cbSettingsLang, "cbSettingsLang");
            this.cbSettingsLang.Name = "cbSettingsLang";
            // 
            // lblSettingsLang
            // 
            resources.ApplyResources(this.lblSettingsLang, "lblSettingsLang");
            this.lblSettingsLang.Name = "lblSettingsLang";
            // 
            // settingsViewModelBindingSource
            // 
            this.settingsViewModelBindingSource.DataSource = typeof(WindowsFormsApp.Models.SettingsViewModel);
            // 
            // SettingsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbSettingsLang);
            this.Controls.Add(this.lblSettingsLang);
            this.Controls.Add(this.cbSettingsGender);
            this.Controls.Add(this.lblSettingsGender);
            this.Controls.Add(this.lblSettingsText);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbCover);
            this.Name = "SettingsView";
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblSettingsText;
        private System.Windows.Forms.Label lblSettingsGender;
        private System.Windows.Forms.BindingSource settingsViewModelBindingSource;
        public System.Windows.Forms.ComboBox cbSettingsGender;
        private System.Windows.Forms.ComboBox cbSettingsLang;
        private System.Windows.Forms.Label lblSettingsLang;
    }
}
