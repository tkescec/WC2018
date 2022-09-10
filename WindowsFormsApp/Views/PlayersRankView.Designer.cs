namespace WindowsFormsApp.Views
{
    partial class PlayersRankView
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
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.tblPanelRankPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.lbSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSort
            // 
            this.cbSort.AllowDrop = true;
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Location = new System.Drawing.Point(253, 7);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(330, 21);
            this.cbSort.TabIndex = 0;
            // 
            // tblPanelRankPlayers
            // 
            this.tblPanelRankPlayers.BackColor = System.Drawing.Color.LightGray;
            this.tblPanelRankPlayers.ColumnCount = 1;
            this.tblPanelRankPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelRankPlayers.Location = new System.Drawing.Point(203, 33);
            this.tblPanelRankPlayers.Name = "tblPanelRankPlayers";
            this.tblPanelRankPlayers.RowCount = 1;
            this.tblPanelRankPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelRankPlayers.Size = new System.Drawing.Size(380, 449);
            this.tblPanelRankPlayers.TabIndex = 1;
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(203, 10);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(44, 13);
            this.lbSort.TabIndex = 2;
            this.lbSort.Text = "Sort By:";
            // 
            // PlayersRankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.tblPanelRankPlayers);
            this.Controls.Add(this.cbSort);
            this.Name = "PlayersRankView";
            this.Size = new System.Drawing.Size(769, 482);
            this.Load += new System.EventHandler(this.PlayersRankView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.TableLayoutPanel tblPanelRankPlayers;
        private System.Windows.Forms.Label lbSort;
    }
}
