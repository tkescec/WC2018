namespace WindowsFormsApp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.tabPlayerRanks = new System.Windows.Forms.TabPage();
            this.tabMatchRank = new System.Windows.Forms.TabPage();
            this.mainMenu.SuspendLayout();
            this.tabMainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            resources.ApplyResources(this.settingsMenuItem, "settingsMenuItem");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // mainStatus
            // 
            resources.ApplyResources(this.mainStatus, "mainStatus");
            this.mainStatus.Name = "mainStatus";
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabPlayers);
            this.tabMainControl.Controls.Add(this.tabPlayerRanks);
            this.tabMainControl.Controls.Add(this.tabMatchRank);
            resources.ApplyResources(this.tabMainControl, "tabMainControl");
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.SelectedIndexChanged += new System.EventHandler(this.TabMainControl_SelectedIndexChanged);
            this.tabMainControl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.TabMainControl_Deselected);
            // 
            // tabPlayers
            // 
            resources.ApplyResources(this.tabPlayers, "tabPlayers");
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // tabPlayerRanks
            // 
            resources.ApplyResources(this.tabPlayerRanks, "tabPlayerRanks");
            this.tabPlayerRanks.Name = "tabPlayerRanks";
            this.tabPlayerRanks.UseVisualStyleBackColor = true;
            // 
            // tabMatchRank
            // 
            resources.ApplyResources(this.tabMatchRank, "tabMatchRank");
            this.tabMatchRank.Name = "tabMatchRank";
            this.tabMatchRank.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMainControl);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabMainControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPlayerRanks;
        private System.Windows.Forms.TabPage tabMatchRank;
        private System.Windows.Forms.TabPage tabPlayers;
    }
}
