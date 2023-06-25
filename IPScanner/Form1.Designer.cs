
namespace IPScanner
{
    partial class Form1
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
            this.scanBtn = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.startPoint = new System.Windows.Forms.TextBox();
            this.endPoint = new System.Windows.Forms.TextBox();
            this.sLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // bgWorker
            //
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(16, 64);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(297, 39);
            this.scanBtn.TabIndex = 0;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(16, 130);
            this.pBar.Maximum = 153;
            this.pBar.Minimum = 100;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(297, 29);
            this.pBar.Step = 5;
            this.pBar.TabIndex = 1;
            this.pBar.Value = 100;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 106);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 20);
            this.status.TabIndex = 2;
            // 
            // startPoint
            // 
            this.startPoint.Location = new System.Drawing.Point(16, 32);
            this.startPoint.Name = "startPoint";
            this.startPoint.Size = new System.Drawing.Size(113, 26);
            this.startPoint.TabIndex = 3;
            this.startPoint.Text = "192.168.0.0";
            // 
            // endPoint
            // 
            this.endPoint.Location = new System.Drawing.Point(200, 32);
            this.endPoint.Name = "endPoint";
            this.endPoint.Size = new System.Drawing.Size(113, 26);
            this.endPoint.TabIndex = 4;
            this.endPoint.Text = "192.168.0.255";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(12, 9);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(44, 20);
            this.sLabel.TabIndex = 5;
            this.sLabel.Text = "Start";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(200, 9);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(38, 20);
            this.eLabel.TabIndex = 6;
            this.eLabel.Text = "End";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 173);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.endPoint);
            this.Controls.Add(this.startPoint);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.scanBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PS3 IP Scanner ~Cain532";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanBtn;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox startPoint;
        private System.Windows.Forms.TextBox endPoint;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label eLabel;
    }
}

