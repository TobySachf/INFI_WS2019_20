namespace Einf_Calculator
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
            this.Txt_input1 = new System.Windows.Forms.TextBox();
            this.Txt_input2 = new System.Windows.Forms.TextBox();
            this.Lbl_output_result = new System.Windows.Forms.Label();
            this.Btn_plus = new System.Windows.Forms.Button();
            this.Btn_minus = new System.Windows.Forms.Button();
            this.Btn_multi = new System.Windows.Forms.Button();
            this.Btn_divi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_input1
            // 
            this.Txt_input1.Location = new System.Drawing.Point(12, 12);
            this.Txt_input1.Name = "Txt_input1";
            this.Txt_input1.Size = new System.Drawing.Size(100, 22);
            this.Txt_input1.TabIndex = 0;
            // 
            // Txt_input2
            // 
            this.Txt_input2.Location = new System.Drawing.Point(12, 58);
            this.Txt_input2.Name = "Txt_input2";
            this.Txt_input2.Size = new System.Drawing.Size(100, 22);
            this.Txt_input2.TabIndex = 1;
            // 
            // Lbl_output_result
            // 
            this.Lbl_output_result.AutoSize = true;
            this.Lbl_output_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_output_result.Location = new System.Drawing.Point(724, 9);
            this.Lbl_output_result.Name = "Lbl_output_result";
            this.Lbl_output_result.Size = new System.Drawing.Size(64, 25);
            this.Lbl_output_result.TabIndex = 2;
            this.Lbl_output_result.Text = "label1";
            // 
            // Btn_plus
            // 
            this.Btn_plus.Location = new System.Drawing.Point(132, 11);
            this.Btn_plus.Name = "Btn_plus";
            this.Btn_plus.Size = new System.Drawing.Size(75, 23);
            this.Btn_plus.TabIndex = 3;
            this.Btn_plus.Text = "+";
            this.Btn_plus.UseVisualStyleBackColor = true;
            // 
            // Btn_minus
            // 
            this.Btn_minus.Location = new System.Drawing.Point(132, 58);
            this.Btn_minus.Name = "Btn_minus";
            this.Btn_minus.Size = new System.Drawing.Size(75, 22);
            this.Btn_minus.TabIndex = 4;
            this.Btn_minus.Text = "-";
            this.Btn_minus.UseVisualStyleBackColor = true;
            // 
            // Btn_multi
            // 
            this.Btn_multi.Location = new System.Drawing.Point(229, 12);
            this.Btn_multi.Name = "Btn_multi";
            this.Btn_multi.Size = new System.Drawing.Size(75, 22);
            this.Btn_multi.TabIndex = 5;
            this.Btn_multi.Text = "*";
            this.Btn_multi.UseVisualStyleBackColor = true;
            // 
            // Btn_divi
            // 
            this.Btn_divi.Location = new System.Drawing.Point(229, 58);
            this.Btn_divi.Name = "Btn_divi";
            this.Btn_divi.Size = new System.Drawing.Size(75, 22);
            this.Btn_divi.TabIndex = 6;
            this.Btn_divi.Text = "/";
            this.Btn_divi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_divi);
            this.Controls.Add(this.Btn_multi);
            this.Controls.Add(this.Btn_minus);
            this.Controls.Add(this.Btn_plus);
            this.Controls.Add(this.Lbl_output_result);
            this.Controls.Add(this.Txt_input2);
            this.Controls.Add(this.Txt_input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_input1;
        private System.Windows.Forms.TextBox Txt_input2;
        private System.Windows.Forms.Label Lbl_output_result;
        private System.Windows.Forms.Button Btn_plus;
        private System.Windows.Forms.Button Btn_minus;
        private System.Windows.Forms.Button Btn_multi;
        private System.Windows.Forms.Button Btn_divi;
    }
}

