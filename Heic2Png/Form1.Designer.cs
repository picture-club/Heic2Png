namespace Heic2Png
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
            this.tbxSrcFolder = new System.Windows.Forms.TextBox();
            this.tbxDestFolder = new System.Windows.Forms.TextBox();
            this.btnSrcBrowse = new System.Windows.Forms.Button();
            this.btnDestBrowse = new System.Windows.Forms.Button();
            this.lblPngCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeicCnt = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSrcFolder
            // 
            this.tbxSrcFolder.Enabled = false;
            this.tbxSrcFolder.Location = new System.Drawing.Point(12, 12);
            this.tbxSrcFolder.Name = "tbxSrcFolder";
            this.tbxSrcFolder.Size = new System.Drawing.Size(414, 20);
            this.tbxSrcFolder.TabIndex = 0;
            this.tbxSrcFolder.Text = "D:\\lk\\Pictures";
            // 
            // tbxDestFolder
            // 
            this.tbxDestFolder.Enabled = false;
            this.tbxDestFolder.Location = new System.Drawing.Point(12, 54);
            this.tbxDestFolder.Name = "tbxDestFolder";
            this.tbxDestFolder.Size = new System.Drawing.Size(414, 20);
            this.tbxDestFolder.TabIndex = 1;
            this.tbxDestFolder.Text = "D:\\lk\\Heic2Png";
            // 
            // btnSrcBrowse
            // 
            this.btnSrcBrowse.Location = new System.Drawing.Point(464, 12);
            this.btnSrcBrowse.Name = "btnSrcBrowse";
            this.btnSrcBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSrcBrowse.TabIndex = 2;
            this.btnSrcBrowse.Text = "Browse";
            this.btnSrcBrowse.UseVisualStyleBackColor = true;
            this.btnSrcBrowse.Click += new System.EventHandler(this.btnSrcBrowse_Click);
            // 
            // btnDestBrowse
            // 
            this.btnDestBrowse.Location = new System.Drawing.Point(464, 54);
            this.btnDestBrowse.Name = "btnDestBrowse";
            this.btnDestBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDestBrowse.TabIndex = 3;
            this.btnDestBrowse.Text = "Browse";
            this.btnDestBrowse.UseVisualStyleBackColor = true;
            this.btnDestBrowse.Click += new System.EventHandler(this.btnDestBrowse_Click);
            // 
            // lblPngCnt
            // 
            this.lblPngCnt.AutoSize = true;
            this.lblPngCnt.Location = new System.Drawing.Point(12, 101);
            this.lblPngCnt.Name = "lblPngCnt";
            this.lblPngCnt.Size = new System.Drawing.Size(13, 13);
            this.lblPngCnt.TabIndex = 4;
            this.lblPngCnt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // lblHeicCnt
            // 
            this.lblHeicCnt.AutoSize = true;
            this.lblHeicCnt.Location = new System.Drawing.Point(102, 101);
            this.lblHeicCnt.Name = "lblHeicCnt";
            this.lblHeicCnt.Size = new System.Drawing.Size(13, 13);
            this.lblHeicCnt.TabIndex = 6;
            this.lblHeicCnt.Text = "0";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(464, 91);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 140);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblHeicCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPngCnt);
            this.Controls.Add(this.btnDestBrowse);
            this.Controls.Add(this.btnSrcBrowse);
            this.Controls.Add(this.tbxDestFolder);
            this.Controls.Add(this.tbxSrcFolder);
            this.Name = "Form1";
            this.Text = "Heic To Png";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSrcFolder;
        private System.Windows.Forms.TextBox tbxDestFolder;
        private System.Windows.Forms.Button btnSrcBrowse;
        private System.Windows.Forms.Button btnDestBrowse;
        private System.Windows.Forms.Label lblPngCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeicCnt;
        private System.Windows.Forms.Button btnGo;
    }
}

