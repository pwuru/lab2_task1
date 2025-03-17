namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNumberA = new TextBox();
            textNumberB = new TextBox();
            textNumberC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textNumberA
            // 
            textNumberA.Location = new Point(124, 97);
            textNumberA.Name = "textNumberA";
            textNumberA.Size = new Size(125, 27);
            textNumberA.TabIndex = 0;
            // 
            // textNumberB
            // 
            textNumberB.Location = new Point(124, 130);
            textNumberB.Name = "textNumberB";
            textNumberB.Size = new Size(125, 27);
            textNumberB.TabIndex = 1;
            // 
            // textNumberC
            // 
            textNumberC.Location = new Point(124, 163);
            textNumberC.Name = "textNumberC";
            textNumberC.Size = new Size(125, 27);
            textNumberC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 97);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Сторона a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 130);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Сторона b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "Сторона c";
            // 
            // button1
            // 
            button1.Location = new Point(308, 249);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 6;
            button1.Text = "Проверка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(38, 19);
            label4.Name = "label4";
            label4.Size = new Size(374, 61);
            label4.TabIndex = 7;
            label4.Text = "Даны вещественные положительные числа a, b, c.  Если существует треугольник со сторонами a, b, c, то определить, является ли он прямоугольным.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 290);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNumberC);
            Controls.Add(textNumberB);
            Controls.Add(textNumberA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNumberA;
        private TextBox textNumberB;
        private TextBox textNumberC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}
