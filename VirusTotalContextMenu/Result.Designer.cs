namespace VirusTotalContextMenu
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_response_code = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_scan_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_permalink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_verbose_msg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_detection_ratio = new System.Windows.Forms.Label();
            this.label_fn = new System.Windows.Forms.Label();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Response Code:";
            // 
            // lbl_response_code
            // 
            this.lbl_response_code.AutoSize = true;
            this.lbl_response_code.Location = new System.Drawing.Point(101, 47);
            this.lbl_response_code.Name = "lbl_response_code";
            this.lbl_response_code.Size = new System.Drawing.Size(80, 13);
            this.lbl_response_code.TabIndex = 1;
            this.lbl_response_code.Text = "response_code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Analysis date:";
            // 
            // lbl_scan_date
            // 
            this.lbl_scan_date.AutoSize = true;
            this.lbl_scan_date.Location = new System.Drawing.Point(101, 80);
            this.lbl_scan_date.Name = "lbl_scan_date";
            this.lbl_scan_date.Size = new System.Drawing.Size(27, 13);
            this.lbl_scan_date.TabIndex = 3;
            this.lbl_scan_date.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Permanent Link:";
            // 
            // lbl_permalink
            // 
            this.lbl_permalink.AutoSize = true;
            this.lbl_permalink.Location = new System.Drawing.Point(101, 113);
            this.lbl_permalink.Name = "lbl_permalink";
            this.lbl_permalink.Size = new System.Drawing.Size(27, 13);
            this.lbl_permalink.TabIndex = 5;
            this.lbl_permalink.TabStop = true;
            this.lbl_permalink.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Verbose Msg:";
            // 
            // lbl_verbose_msg
            // 
            this.lbl_verbose_msg.AutoSize = true;
            this.lbl_verbose_msg.Location = new System.Drawing.Point(101, 146);
            this.lbl_verbose_msg.Name = "lbl_verbose_msg";
            this.lbl_verbose_msg.Size = new System.Drawing.Size(70, 13);
            this.lbl_verbose_msg.TabIndex = 7;
            this.lbl_verbose_msg.Text = "verbose_msg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detection ratio:";
            // 
            // lbl_detection_ratio
            // 
            this.lbl_detection_ratio.AutoSize = true;
            this.lbl_detection_ratio.Location = new System.Drawing.Point(101, 179);
            this.lbl_detection_ratio.Name = "lbl_detection_ratio";
            this.lbl_detection_ratio.Size = new System.Drawing.Size(27, 13);
            this.lbl_detection_ratio.TabIndex = 9;
            this.lbl_detection_ratio.Text = "N/A";
            // 
            // label_fn
            // 
            this.label_fn.AutoSize = true;
            this.label_fn.Location = new System.Drawing.Point(13, 18);
            this.label_fn.Name = "label_fn";
            this.label_fn.Size = new System.Drawing.Size(57, 13);
            this.label_fn.TabIndex = 10;
            this.label_fn.Text = "File Name:";
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(101, 18);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(46, 13);
            this.lbl_filename.TabIndex = 11;
            this.lbl_filename.Text = "filename";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.label_fn);
            this.Controls.Add(this.lbl_detection_ratio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_verbose_msg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_permalink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_scan_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_response_code);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "Result";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "VirusTotal Scan Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_response_code;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_scan_date;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.LinkLabel lbl_permalink;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_verbose_msg;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_detection_ratio;
        private System.Windows.Forms.Label label_fn; 
        public System.Windows.Forms.Label lbl_filename;
    }
}