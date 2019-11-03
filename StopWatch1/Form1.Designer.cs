namespace StopWatch1
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_hour = new System.Windows.Forms.Label();
            this.Lbl_min = new System.Windows.Forms.Label();
            this.Lbl_sec = new System.Windows.Forms.Label();
            this.Lbl_msec = new System.Windows.Forms.Label();
            this.Btn_start = new System.Windows.Forms.Button();
            this.Btn_stop = new System.Windows.Forms.Button();
            this.Lbl_header = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.Btn_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Lb_times = new System.Windows.Forms.ListBox();
            this.Btn_getTime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_hour
            // 
            this.Lbl_hour.AutoSize = true;
            this.Lbl_hour.Location = new System.Drawing.Point(6, 151);
            this.Lbl_hour.Name = "Lbl_hour";
            this.Lbl_hour.Size = new System.Drawing.Size(50, 20);
            this.Lbl_hour.TabIndex = 0;
            this.Lbl_hour.Text = "label1";
            // 
            // Lbl_min
            // 
            this.Lbl_min.AutoSize = true;
            this.Lbl_min.Location = new System.Drawing.Point(58, 151);
            this.Lbl_min.Name = "Lbl_min";
            this.Lbl_min.Size = new System.Drawing.Size(50, 20);
            this.Lbl_min.TabIndex = 1;
            this.Lbl_min.Text = "label2";
            // 
            // Lbl_sec
            // 
            this.Lbl_sec.AutoSize = true;
            this.Lbl_sec.Location = new System.Drawing.Point(131, 151);
            this.Lbl_sec.Name = "Lbl_sec";
            this.Lbl_sec.Size = new System.Drawing.Size(50, 20);
            this.Lbl_sec.TabIndex = 2;
            this.Lbl_sec.Text = "label3";
            // 
            // Lbl_msec
            // 
            this.Lbl_msec.AutoSize = true;
            this.Lbl_msec.Location = new System.Drawing.Point(183, 151);
            this.Lbl_msec.Name = "Lbl_msec";
            this.Lbl_msec.Size = new System.Drawing.Size(50, 20);
            this.Lbl_msec.TabIndex = 3;
            this.Lbl_msec.Text = "label4";
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(137, 268);
            this.Btn_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(75, 29);
            this.Btn_start.TabIndex = 4;
            this.Btn_start.Text = "Start";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Btn_stop
            // 
            this.Btn_stop.Location = new System.Drawing.Point(218, 268);
            this.Btn_stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.Size = new System.Drawing.Size(75, 29);
            this.Btn_stop.TabIndex = 5;
            this.Btn_stop.Text = "Stop";
            this.Btn_stop.UseVisualStyleBackColor = true;
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // Lbl_header
            // 
            this.Lbl_header.AutoSize = true;
            this.Lbl_header.Location = new System.Drawing.Point(6, 22);
            this.Lbl_header.Name = "Lbl_header";
            this.Lbl_header.Size = new System.Drawing.Size(61, 20);
            this.Lbl_header.TabIndex = 7;
            this.Lbl_header.Text = "Stopuhr";
            // 
            // aTimer
            // 
            this.aTimer.Interval = 1;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(299, 268);
            this.Btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(75, 29);
            this.Btn_reset.TabIndex = 8;
            this.Btn_reset.Text = "Reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_header);
            this.groupBox1.Controls.Add(this.Lbl_hour);
            this.groupBox1.Controls.Add(this.Lbl_min);
            this.groupBox1.Controls.Add(this.Lbl_sec);
            this.groupBox1.Controls.Add(this.Lbl_msec);
            this.groupBox1.Location = new System.Drawing.Point(137, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(235, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Lb_times
            // 
            this.Lb_times.FormattingEnabled = true;
            this.Lb_times.ItemHeight = 20;
            this.Lb_times.Location = new System.Drawing.Point(135, 341);
            this.Lb_times.Name = "Lb_times";
            this.Lb_times.Size = new System.Drawing.Size(235, 84);
            this.Lb_times.TabIndex = 10;
            // 
            // Btn_getTime
            // 
            this.Btn_getTime.Location = new System.Drawing.Point(137, 305);
            this.Btn_getTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_getTime.Name = "Btn_getTime";
            this.Btn_getTime.Size = new System.Drawing.Size(237, 29);
            this.Btn_getTime.TabIndex = 11;
            this.Btn_getTime.Text = "Zwischenzeit";
            this.Btn_getTime.UseVisualStyleBackColor = true;
            this.Btn_getTime.Click += new System.EventHandler(this.Btn_getTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.Btn_getTime);
            this.Controls.Add(this.Lb_times);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_start);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Lbl_hour;
        private System.Windows.Forms.Label Lbl_min;
        private System.Windows.Forms.Label Lbl_sec;
        private System.Windows.Forms.Label Lbl_msec;
        private System.Windows.Forms.Button Btn_stop;
        private System.Windows.Forms.Label Lbl_header;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_getTime;
        private System.Windows.Forms.ListBox Lb_times;
    }
}

