namespace Loader
{
    partial class LoaderForm
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
            this.loaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loaderLabel
            // 
            this.loaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.loaderLabel.Image = global::Loader.Properties.Resources.Ellipsis_0_7s_100px;
            this.loaderLabel.Location = new System.Drawing.Point(50, 0);
            this.loaderLabel.Name = "loaderLabel";
            this.loaderLabel.Size = new System.Drawing.Size(100, 100);
            this.loaderLabel.TabIndex = 1;
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.loaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaderForm";
            this.Text = "LoaderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loaderLabel;
    }
}