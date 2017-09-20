namespace ConfigAndLog4netWin
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoggerDebug = new System.Windows.Forms.Button();
            this.btnLoggerDBDebug = new System.Windows.Forms.Button();
            this.btnfrmDebug = new System.Windows.Forms.Button();
            this.btnGetAppenderCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoggerDebug
            // 
            this.btnLoggerDebug.Location = new System.Drawing.Point(38, 16);
            this.btnLoggerDebug.Name = "btnLoggerDebug";
            this.btnLoggerDebug.Size = new System.Drawing.Size(117, 40);
            this.btnLoggerDebug.TabIndex = 0;
            this.btnLoggerDebug.Text = "Logger.Debug";
            this.btnLoggerDebug.UseVisualStyleBackColor = true;
            this.btnLoggerDebug.Click += new System.EventHandler(this.btnLoggerDebug_Click);
            // 
            // btnLoggerDBDebug
            // 
            this.btnLoggerDBDebug.Location = new System.Drawing.Point(43, 76);
            this.btnLoggerDBDebug.Name = "btnLoggerDBDebug";
            this.btnLoggerDBDebug.Size = new System.Drawing.Size(112, 41);
            this.btnLoggerDBDebug.TabIndex = 1;
            this.btnLoggerDBDebug.Text = "LoggerDB.Debug";
            this.btnLoggerDBDebug.UseVisualStyleBackColor = true;
            this.btnLoggerDBDebug.Click += new System.EventHandler(this.btnLoggerDBDebug_Click);
            // 
            // btnfrmDebug
            // 
            this.btnfrmDebug.Location = new System.Drawing.Point(45, 151);
            this.btnfrmDebug.Name = "btnfrmDebug";
            this.btnfrmDebug.Size = new System.Drawing.Size(109, 45);
            this.btnfrmDebug.TabIndex = 2;
            this.btnfrmDebug.Text = "frmDebug";
            this.btnfrmDebug.UseVisualStyleBackColor = true;
            this.btnfrmDebug.Click += new System.EventHandler(this.btnfrmDebug_Click);
            // 
            // btnGetAppenderCount
            // 
            this.btnGetAppenderCount.Location = new System.Drawing.Point(38, 211);
            this.btnGetAppenderCount.Name = "btnGetAppenderCount";
            this.btnGetAppenderCount.Size = new System.Drawing.Size(134, 49);
            this.btnGetAppenderCount.TabIndex = 3;
            this.btnGetAppenderCount.Text = "Get Appender Count";
            this.btnGetAppenderCount.UseVisualStyleBackColor = true;
            this.btnGetAppenderCount.Click += new System.EventHandler(this.btnGetAppenderCount_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 289);
            this.Controls.Add(this.btnGetAppenderCount);
            this.Controls.Add(this.btnfrmDebug);
            this.Controls.Add(this.btnLoggerDBDebug);
            this.Controls.Add(this.btnLoggerDebug);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoggerDebug;
        private System.Windows.Forms.Button btnLoggerDBDebug;
        private System.Windows.Forms.Button btnfrmDebug;
        private System.Windows.Forms.Button btnGetAppenderCount;
    }
}

