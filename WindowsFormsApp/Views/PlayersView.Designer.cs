namespace WindowsFormsApp.Views
{
    partial class PlayersView
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
            this.tblPanelFavoritPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.lbFavoritPlayers = new System.Windows.Forms.Label();
            this.lbAllPlayers = new System.Windows.Forms.Label();
            this.cmAddPlayerToFavorite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRemovePlayerFromFavorite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddPlayerToFavorite.SuspendLayout();
            this.cmRemovePlayerFromFavorite.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelFavoritPlayers
            // 
            this.tblPanelFavoritPlayers.AllowDrop = true;
            this.tblPanelFavoritPlayers.BackColor = System.Drawing.Color.LightGray;
            this.tblPanelFavoritPlayers.ColumnCount = 1;
            this.tblPanelFavoritPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelFavoritPlayers.Location = new System.Drawing.Point(387, 30);
            this.tblPanelFavoritPlayers.Name = "tblPanelFavoritPlayers";
            this.tblPanelFavoritPlayers.RowCount = 1;
            this.tblPanelFavoritPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelFavoritPlayers.Size = new System.Drawing.Size(380, 449);
            this.tblPanelFavoritPlayers.TabIndex = 7;
            // 
            // tblPanelPlayers
            // 
            this.tblPanelPlayers.AllowDrop = true;
            this.tblPanelPlayers.BackColor = System.Drawing.Color.LightGray;
            this.tblPanelPlayers.ColumnCount = 1;
            this.tblPanelPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPanelPlayers.Location = new System.Drawing.Point(1, 30);
            this.tblPanelPlayers.Name = "tblPanelPlayers";
            this.tblPanelPlayers.RowCount = 3;
            this.tblPanelPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelPlayers.Size = new System.Drawing.Size(380, 449);
            this.tblPanelPlayers.TabIndex = 6;
            // 
            // lbFavoritPlayers
            // 
            this.lbFavoritPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbFavoritPlayers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbFavoritPlayers.Location = new System.Drawing.Point(387, 4);
            this.lbFavoritPlayers.Name = "lbFavoritPlayers";
            this.lbFavoritPlayers.Size = new System.Drawing.Size(380, 23);
            this.lbFavoritPlayers.TabIndex = 5;
            this.lbFavoritPlayers.Text = "Favorit Players";
            this.lbFavoritPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbAllPlayers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAllPlayers.Location = new System.Drawing.Point(8, 4);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.Size = new System.Drawing.Size(373, 23);
            this.lbAllPlayers.TabIndex = 4;
            this.lbAllPlayers.Text = "All Players";
            this.lbAllPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmAddPlayerToFavorite
            // 
            this.cmAddPlayerToFavorite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem});
            this.cmAddPlayerToFavorite.Name = "cmAddPlayerToFavorite";
            this.cmAddPlayerToFavorite.Size = new System.Drawing.Size(161, 26);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to Favorites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.AddToFavoritesToolStripMenuItem_Click);
            // 
            // cmRemovePlayerFromFavorite
            // 
            this.cmRemovePlayerFromFavorite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromFavoritesToolStripMenuItem});
            this.cmRemovePlayerFromFavorite.Name = "cmRemovePlayerFromFavorite";
            this.cmRemovePlayerFromFavorite.Size = new System.Drawing.Size(197, 26);
            // 
            // removeFromFavoritesToolStripMenuItem
            // 
            this.removeFromFavoritesToolStripMenuItem.Name = "removeFromFavoritesToolStripMenuItem";
            this.removeFromFavoritesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeFromFavoritesToolStripMenuItem.Text = "Remove from Favorites";
            this.removeFromFavoritesToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromFavoritesToolStripMenuItem_Click);
            // 
            // PlayersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblPanelFavoritPlayers);
            this.Controls.Add(this.tblPanelPlayers);
            this.Controls.Add(this.lbFavoritPlayers);
            this.Controls.Add(this.lbAllPlayers);
            this.Name = "PlayersView";
            this.Size = new System.Drawing.Size(769, 482);
            this.Load += new System.EventHandler(this.PlayersView_Load);
            this.cmAddPlayerToFavorite.ResumeLayout(false);
            this.cmRemovePlayerFromFavorite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelFavoritPlayers;
        private System.Windows.Forms.TableLayoutPanel tblPanelPlayers;
        private System.Windows.Forms.Label lbFavoritPlayers;
        private System.Windows.Forms.Label lbAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmRemovePlayerFromFavorite;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavoritesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmAddPlayerToFavorite;
    }
}
