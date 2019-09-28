namespace Einf_Calc2
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
            this.Lb_operator = new System.Windows.Forms.ListBox();
            this.Txt_input2 = new System.Windows.Forms.TextBox();
            this.Btn_result = new System.Windows.Forms.Button();
            this.Lbl_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_input1
            // 
            this.Txt_input1.Location = new System.Drawing.Point(12, 12);
            this.Txt_input1.Name = "Txt_input1";
            this.Txt_input1.Size = new System.Drawing.Size(196, 22);
            this.Txt_input1.TabIndex = 0;
            this.Txt_input1.TextChanged += new System.EventHandler(this.Txt_input1_TextChanged);
            // 
            // Lb_operator
            // 
            this.Lb_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_operator.FormattingEnabled = true;
            this.Lb_operator.ItemHeight = 25;
            this.Lb_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Lb_operator.Location = new System.Drawing.Point(217, 12);
            this.Lb_operator.Name = "Lb_operator";
            this.Lb_operator.Size = new System.Drawing.Size(40, 29);
            this.Lb_operator.TabIndex = 1;
            // 
            // Txt_input2
            // 
            this.Txt_input2.Location = new System.Drawing.Point(263, 12);
            this.Txt_input2.Name = "Txt_input2";
            this.Txt_input2.Size = new System.Drawing.Size(196, 22);
            this.Txt_input2.TabIndex = 2;
            this.Txt_input2.TextChanged += new System.EventHandler(this.Txt_input2_TextChanged);
            // 
            // Btn_result
            // 
            this.Btn_result.Location = new System.Drawing.Point(465, 11);
            this.Btn_result.Name = "Btn_result";
            this.Btn_result.Size = new System.Drawing.Size(75, 23);
            this.Btn_result.TabIndex = 3;
            this.Btn_result.Text = "=";
            this.Btn_result.UseVisualStyleBackColor = true;
            this.Btn_result.Click += new System.EventHandler(this.Btn_result_Click);
            // 
            // Lbl_show
            // 
            this.Lbl_show.AutoSize = true;
            this.Lbl_show.Location = new System.Drawing.Point(546, 15);
            this.Lbl_show.Name = "Lbl_show";
            this.Lbl_show.Size = new System.Drawing.Size(46, 17);
            this.Lbl_show.TabIndex = 4;
            this.Lbl_show.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_show);
            this.Controls.Add(this.Btn_result);
            this.Controls.Add(this.Txt_input2);
            this.Controls.Add(this.Lb_operator);
            this.Controls.Add(this.Txt_input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_input1;
        private System.Windows.Forms.ListBox Lb_operator;
        private System.Windows.Forms.TextBox Txt_input2;
        private System.Windows.Forms.Button Btn_result;
        private System.Windows.Forms.Label Lbl_show;
    }
}

