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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblSettingsText = new System.Windows.Forms.Label();
            this.cbSettingsGender = new System.Windows.Forms.ComboBox();
            this.lblSettingsGender = new System.Windows.Forms.Label();
            this.settingsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSettingsLang = new System.Windows.Forms.ComboBox();
            this.lblSettingsLang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitle.Location = new System.Drawing.Point(397, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(380, 30);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "World Cup 2018";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCover
            // 
            this.pbCover.Image = global::WindowsFormsApp.Properties.Resources.cover;
            this.pbCover.Location = new System.Drawing.Point(5, 0);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(390, 556);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 0;
            this.pbCover.TabStop = false;
            // 
            // lblSettingsText
            // 
            this.lblSettingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSettingsText.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSettingsText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsText.Location = new System.Drawing.Point(397, 100);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(379, 22);
            this.lblSettingsText.TabIndex = 6;
            this.lblSettingsText.Text = "Please set the basic settings before using the app! ";
            this.lblSettingsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbSettingsGender
            // 
            this.cbSettingsGender.AllowDrop = true;
            this.cbSettingsGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsGender.FormattingEnabled = true;
            this.cbSettingsGender.Location = new System.Drawing.Point(448, 235);
            this.cbSettingsGender.Name = "cbSettingsGender";
            this.cbSettingsGender.Size = new System.Drawing.Size(277, 21);
            this.cbSettingsGender.TabIndex = 8;
            // 
            // lblSettingsGender
            // 
            this.lblSettingsGender.AutoSize = true;
            this.lblSettingsGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsGender.Location = new System.Drawing.Point(448, 215);
            this.lblSettingsGender.Name = "lblSettingsGender";
            this.lblSettingsGender.Size = new System.Drawing.Size(85, 13);
            this.lblSettingsGender.TabIndex = 7;
            this.lblSettingsGender.Text = "Choose gender: ";
            // 
            // settingsViewModelBindingSource
            // 
            this.settingsViewModelBindingSource.DataSource = typeof(WindowsFormsApp.Models.SettingsViewModel);
            // 
            // cbSettingsLang
            // 
            this.cbSettingsLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsLang.FormattingEnabled = true;
            this.cbSettingsLang.Location = new System.Drawing.Point(448, 306);
            this.cbSettingsLang.Name = "cbSettingsLang";
            this.cbSettingsLang.Size = new System.Drawing.Size(277, 21);
            this.cbSettingsLang.TabIndex = 10;
            // 
            // lblSettingsLang
            // 
            this.lblSettingsLang.AutoSize = true;
            this.lblSettingsLang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSettingsLang.Location = new System.Drawing.Point(448, 284);
            this.lblSettingsLang.Name = "lblSettingsLang";
            this.lblSettingsLang.Size = new System.Drawing.Size(93, 13);
            this.lblSettingsLang.TabIndex = 9;
            this.lblSettingsLang.Text = "Choose language:";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(780, 556);
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
