namespace ChuviDientich
{
    partial class HinhChuNhat
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
            Calculator = new Button();
            CdTxt1 = new Label();
            label1 = new Label();
            CdTxt = new TextBox();
            CrTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CvTxt = new TextBox();
            DtTxt = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Calculator
            // 
            Calculator.Font = new Font("Tahoma", 15F);
            Calculator.Location = new Point(595, 108);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(144, 61);
            Calculator.TabIndex = 0;
            Calculator.Text = "Tính";
            Calculator.UseVisualStyleBackColor = true;
            Calculator.Click += Calculator_Click;
            // 
            // CdTxt1
            // 
            CdTxt1.AutoSize = true;
            CdTxt1.Font = new Font("Tahoma", 15F);
            CdTxt1.Location = new Point(78, 83);
            CdTxt1.Name = "CdTxt1";
            CdTxt1.Size = new Size(202, 30);
            CdTxt1.TabIndex = 1;
            CdTxt1.Text = "Nhập Chiều Dài: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.Location = new Point(78, 139);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 1;
            label1.Text = "Nhập Chiều Rộng: ";
            // 
            // CdTxt
            // 
            CdTxt.Font = new Font("Tahoma", 15F);
            CdTxt.Location = new Point(335, 75);
            CdTxt.Name = "CdTxt";
            CdTxt.Size = new Size(143, 38);
            CdTxt.TabIndex = 2;
            // 
            // CrTxt
            // 
            CrTxt.Font = new Font("Tahoma", 15F);
            CrTxt.Location = new Point(335, 136);
            CrTxt.Name = "CrTxt";
            CrTxt.Size = new Size(143, 38);
            CrTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F);
            label2.Location = new Point(231, 261);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 1;
            label2.Text = "Chu vi: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F);
            label3.Location = new Point(231, 329);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 1;
            label3.Text = "Diện tích: ";
            // 
            // CvTxt
            // 
            CvTxt.Font = new Font("Tahoma", 15F);
            CvTxt.Location = new Point(368, 261);
            CvTxt.Name = "CvTxt";
            CvTxt.Size = new Size(143, 38);
            CvTxt.TabIndex = 2;
            // 
            // DtTxt
            // 
            DtTxt.Font = new Font("Tahoma", 15F);
            DtTxt.Location = new Point(368, 321);
            DtTxt.Name = "DtTxt";
            DtTxt.Size = new Size(143, 38);
            DtTxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(33, 9);
            label4.Name = "label4";
            label4.Size = new Size(755, 41);
            label4.TabIndex = 1;
            label4.Text = "Chương trình tính chu vi, diện tích hình chữ nhật";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 15F);
            button1.Location = new Point(595, 194);
            button1.Name = "button1";
            button1.Size = new Size(144, 56);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(DtTxt);
            Controls.Add(CvTxt);
            Controls.Add(CrTxt);
            Controls.Add(CdTxt);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(CdTxt1);
            Controls.Add(Calculator);
            Name = "HinhChuNhat";
            Text = "HinhChuNhat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculator;
        private Label CdTxt1;
        private Label label1;
        private TextBox CdTxt;
        private TextBox CrTxt;
        private Label label2;
        private Label label3;
        private TextBox CvTxt;
        private TextBox DtTxt;
        private Label label4;
        private Button button1;
    }
}