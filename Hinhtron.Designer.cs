namespace ChuviDientich
{
    partial class Hinhtron
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BkTxt = new TextBox();
            CvTxt = new TextBox();
            DtTxt = new TextBox();
            Calculator = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F);
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(671, 41);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính chu vi diện tích hình tròn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F);
            label2.Location = new Point(97, 161);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 1;
            label2.Text = "Nhập bán kính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F);
            label3.Location = new Point(189, 276);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 1;
            label3.Text = "Chu vi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15F);
            label4.Location = new Point(160, 320);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 1;
            label4.Text = "Diện tích:";
            // 
            // BkTxt
            // 
            BkTxt.Font = new Font("Tahoma", 15F);
            BkTxt.Location = new Point(305, 158);
            BkTxt.Name = "BkTxt";
            BkTxt.Size = new Size(195, 38);
            BkTxt.TabIndex = 2;
            // 
            // CvTxt
            // 
            CvTxt.Font = new Font("Tahoma", 15F);
            CvTxt.Location = new Point(305, 268);
            CvTxt.Name = "CvTxt";
            CvTxt.Size = new Size(195, 38);
            CvTxt.TabIndex = 2;
            // 
            // DtTxt
            // 
            DtTxt.Font = new Font("Tahoma", 15F);
            DtTxt.Location = new Point(305, 312);
            DtTxt.Name = "DtTxt";
            DtTxt.Size = new Size(195, 38);
            DtTxt.TabIndex = 2;
            // 
            // Calculator
            // 
            Calculator.Font = new Font("Tahoma", 15F);
            Calculator.Location = new Point(567, 161);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(140, 64);
            Calculator.TabIndex = 3;
            Calculator.Text = "Tính";
            Calculator.UseVisualStyleBackColor = true;
            Calculator.Click += Calculator_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 15F);
            button1.Location = new Point(567, 286);
            button1.Name = "button1";
            button1.Size = new Size(140, 64);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Hinhtron
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Calculator);
            Controls.Add(DtTxt);
            Controls.Add(CvTxt);
            Controls.Add(BkTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Hinhtron";
            Text = "Hinhtron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox BkTxt;
        private TextBox CvTxt;
        private TextBox DtTxt;
        private Button Calculator;
        private Button button1;
    }
}