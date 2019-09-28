namespace Einf_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Vom Windows Form-Designer generierter Code
        
        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_start = new System.Windows.Forms.Button();
            this.Btn_stop = new System.Windows.Forms.Button();
            this.Lbl_status_motor = new System.Windows.Forms.Label();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Txt_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_start
            // 
            this.Btn_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_start.Location = new System.Drawing.Point(12, 12);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(210, 50);
            this.Btn_start.TabIndex = 0;
            this.Btn_start.Text = "Start";
            this.Btn_start.UseVisualStyleBackColor = false;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Btn_stop
            // 
            this.Btn_stop.Location = new System.Drawing.Point(660, 12);
            this.Btn_stop.Name = "Btn_stop";
            this.Btn_stop.Size = new System.Drawing.Size(210, 50);
            this.Btn_stop.TabIndex = 1;
            this.Btn_stop.Text = "Stop";
            this.Btn_stop.UseVisualStyleBackColor = true;
            this.Btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // Lbl_status_motor
            // 
            this.Lbl_status_motor.AutoSize = true;
            this.Lbl_status_motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_status_motor.Location = new System.Drawing.Point(450, 234);
            this.Lbl_status_motor.Name = "Lbl_status_motor";
            this.Lbl_status_motor.Size = new System.Drawing.Size(127, 29);
            this.Lbl_status_motor.TabIndex = 2;
            this.Lbl_status_motor.Text = "__Motor__";
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(348, 12);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(210, 50);
            this.Btn_reset.TabIndex = 3;
            this.Btn_reset.Text = "Reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Txt_value
            // 
            this.Txt_value.Location = new System.Drawing.Point(12, 79);
            this.Txt_value.Name = "Txt_value";
            this.Txt_value.Size = new System.Drawing.Size(100, 22);
            this.Txt_value.TabIndex = 4;
            this.Txt_value.TextChanged += new System.EventHandler(this.Txt_value_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 493);
            this.Controls.Add(this.Txt_value);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Lbl_status_motor);
            this.Controls.Add(this.Btn_stop);
            this.Controls.Add(this.Btn_start);
            this.Name = "Form1";
            this.Text = "3dhwim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.Button Btn_stop;
        private System.Windows.Forms.Label Lbl_status_motor;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.TextBox Txt_value;
    }
}

