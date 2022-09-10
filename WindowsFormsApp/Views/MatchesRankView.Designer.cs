namespace WindowsFormsApp.Views
{
    partial class MatchesRankView
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
            this.tblPanelRankMatches = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tblPanelRankMatches
            // 
            this.tblPanelRankMatches.BackColor = System.Drawing.Color.LightGray;
            this.tblPanelRankMatches.ColumnCount = 1;
            this.tblPanelRankMatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelRankMatches.Location = new System.Drawing.Point(0, 0);
            this.tblPanelRankMatches.Name = "tblPanelRankMatches";
            this.tblPanelRankMatches.RowCount = 3;
            this.tblPanelRankMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelRankMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelRankMatches.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelRankMatches.Size = new System.Drawing.Size(769, 482);
            this.tblPanelRankMatches.TabIndex = 0;
            // 
            // MatchesRankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblPanelRankMatches);
            this.Name = "MatchesRankView";
            this.Size = new System.Drawing.Size(769, 482);
            this.Load += new System.EventHandler(this.MatchesRankView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelRankMatches;
    }
}
