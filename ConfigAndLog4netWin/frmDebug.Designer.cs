namespace ConfigAndLog4netWin
{
    partial class frmDebug
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
            this.lstDebug = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDebug
            // 
            this.lstDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDebug.FormattingEnabled = true;
            this.lstDebug.ItemHeight = 12;
            this.lstDebug.Location = new System.Drawing.Point(0, 0);
            this.lstDebug.Name = "lstDebug";
            this.lstDebug.Size = new System.Drawing.Size(524, 391);
            this.lstDebug.TabIndex = 0;
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.lstDebug);
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDebug_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDebug;
    }
}