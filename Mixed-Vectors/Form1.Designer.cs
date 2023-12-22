namespace Mixed_Vectors
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
            buttonCalculate = new Button();
            buttonInstruction = new Button();
            buttonWord = new Button();
            buttonExcel = new Button();
            buttonPDF = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            label1 = new Label();
            textBoxFirstVectorName = new TextBox();
            label4 = new Label();
            textBoxFirstVectorX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxFirstVectorY = new TextBox();
            label5 = new Label();
            textBoxFirstVectorZ = new TextBox();
            label6 = new Label();
            textBoxSecondVectorZ = new TextBox();
            label7 = new Label();
            textBoxSecondVectorY = new TextBox();
            label8 = new Label();
            textBoxSecondVectorX = new TextBox();
            label9 = new Label();
            textBoxSecondVectorName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxThirdVectorZ = new TextBox();
            label12 = new Label();
            textBoxThirdVectorY = new TextBox();
            label13 = new Label();
            textBoxThirdVectorX = new TextBox();
            label14 = new Label();
            textBoxThirdVectorName = new TextBox();
            label15 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 14F);
            buttonCalculate.Location = new Point(370, 12);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(225, 79);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // buttonInstruction
            // 
            buttonInstruction.Font = new Font("Segoe UI", 14F);
            buttonInstruction.Location = new Point(370, 97);
            buttonInstruction.Name = "buttonInstruction";
            buttonInstruction.Size = new Size(225, 79);
            buttonInstruction.TabIndex = 1;
            buttonInstruction.Text = "Инструкция";
            buttonInstruction.UseVisualStyleBackColor = true;
            buttonInstruction.Click += ButtonInstruction_Click;
            // 
            // buttonWord
            // 
            buttonWord.Font = new Font("Segoe UI", 14F);
            buttonWord.Location = new Point(370, 182);
            buttonWord.Name = "buttonWord";
            buttonWord.Size = new Size(225, 79);
            buttonWord.TabIndex = 2;
            buttonWord.Text = "Экспорт в Word";
            buttonWord.UseVisualStyleBackColor = true;
            buttonWord.Click += ButtonWord_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.Font = new Font("Segoe UI", 14F);
            buttonExcel.Location = new Point(370, 267);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(225, 79);
            buttonExcel.TabIndex = 3;
            buttonExcel.Text = "Экспорт в Excel";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += ButtonExcel_Click;
            // 
            // buttonPDF
            // 
            buttonPDF.Font = new Font("Segoe UI", 14F);
            buttonPDF.Location = new Point(370, 352);
            buttonPDF.Name = "buttonPDF";
            buttonPDF.Size = new Size(225, 79);
            buttonPDF.TabIndex = 4;
            buttonPDF.Text = "Экспорт в PDF";
            buttonPDF.UseVisualStyleBackColor = true;
            buttonPDF.Click += ButtonPDF_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14F);
            buttonClear.Location = new Point(370, 437);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(225, 79);
            buttonClear.TabIndex = 5;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 14F);
            buttonExit.Location = new Point(370, 522);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(225, 79);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 7;
            label1.Text = "Первый вектор";
            // 
            // textBoxFirstVectorName
            // 
            textBoxFirstVectorName.Font = new Font("Segoe UI", 14F);
            textBoxFirstVectorName.Location = new Point(12, 37);
            textBoxFirstVectorName.MaxLength = 2;
            textBoxFirstVectorName.Name = "textBoxFirstVectorName";
            textBoxFirstVectorName.Size = new Size(32, 32);
            textBoxFirstVectorName.TabIndex = 10;
            textBoxFirstVectorName.Text = "a";
            textBoxFirstVectorName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(50, 40);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 11;
            label4.Text = "= {";
            // 
            // textBoxFirstVectorX
            // 
            textBoxFirstVectorX.Font = new Font("Segoe UI", 14F);
            textBoxFirstVectorX.Location = new Point(92, 37);
            textBoxFirstVectorX.MaxLength = 8;
            textBoxFirstVectorX.Name = "textBoxFirstVectorX";
            textBoxFirstVectorX.PlaceholderText = "0";
            textBoxFirstVectorX.Size = new Size(64, 32);
            textBoxFirstVectorX.TabIndex = 12;
            textBoxFirstVectorX.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(162, 40);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 13;
            label2.Text = ";";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(254, 40);
            label3.Name = "label3";
            label3.Size = new Size(16, 25);
            label3.TabIndex = 15;
            label3.Text = ";";
            // 
            // textBoxFirstVectorY
            // 
            textBoxFirstVectorY.Font = new Font("Segoe UI", 14F);
            textBoxFirstVectorY.Location = new Point(184, 37);
            textBoxFirstVectorY.MaxLength = 8;
            textBoxFirstVectorY.Name = "textBoxFirstVectorY";
            textBoxFirstVectorY.PlaceholderText = "0";
            textBoxFirstVectorY.Size = new Size(64, 32);
            textBoxFirstVectorY.TabIndex = 14;
            textBoxFirstVectorY.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(346, 40);
            label5.Name = "label5";
            label5.Size = new Size(18, 25);
            label5.TabIndex = 17;
            label5.Text = "}";
            // 
            // textBoxFirstVectorZ
            // 
            textBoxFirstVectorZ.Font = new Font("Segoe UI", 14F);
            textBoxFirstVectorZ.Location = new Point(276, 37);
            textBoxFirstVectorZ.MaxLength = 8;
            textBoxFirstVectorZ.Name = "textBoxFirstVectorZ";
            textBoxFirstVectorZ.PlaceholderText = "0";
            textBoxFirstVectorZ.Size = new Size(64, 32);
            textBoxFirstVectorZ.TabIndex = 16;
            textBoxFirstVectorZ.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(346, 103);
            label6.Name = "label6";
            label6.Size = new Size(18, 25);
            label6.TabIndex = 26;
            label6.Text = "}";
            // 
            // textBoxSecondVectorZ
            // 
            textBoxSecondVectorZ.Font = new Font("Segoe UI", 14F);
            textBoxSecondVectorZ.Location = new Point(276, 100);
            textBoxSecondVectorZ.MaxLength = 8;
            textBoxSecondVectorZ.Name = "textBoxSecondVectorZ";
            textBoxSecondVectorZ.PlaceholderText = "0";
            textBoxSecondVectorZ.Size = new Size(64, 32);
            textBoxSecondVectorZ.TabIndex = 25;
            textBoxSecondVectorZ.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(254, 103);
            label7.Name = "label7";
            label7.Size = new Size(16, 25);
            label7.TabIndex = 24;
            label7.Text = ";";
            // 
            // textBoxSecondVectorY
            // 
            textBoxSecondVectorY.Font = new Font("Segoe UI", 14F);
            textBoxSecondVectorY.Location = new Point(184, 100);
            textBoxSecondVectorY.MaxLength = 8;
            textBoxSecondVectorY.Name = "textBoxSecondVectorY";
            textBoxSecondVectorY.PlaceholderText = "0";
            textBoxSecondVectorY.Size = new Size(64, 32);
            textBoxSecondVectorY.TabIndex = 23;
            textBoxSecondVectorY.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(162, 103);
            label8.Name = "label8";
            label8.Size = new Size(16, 25);
            label8.TabIndex = 22;
            label8.Text = ";";
            // 
            // textBoxSecondVectorX
            // 
            textBoxSecondVectorX.Font = new Font("Segoe UI", 14F);
            textBoxSecondVectorX.Location = new Point(92, 100);
            textBoxSecondVectorX.MaxLength = 8;
            textBoxSecondVectorX.Name = "textBoxSecondVectorX";
            textBoxSecondVectorX.PlaceholderText = "0";
            textBoxSecondVectorX.Size = new Size(64, 32);
            textBoxSecondVectorX.TabIndex = 21;
            textBoxSecondVectorX.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(50, 103);
            label9.Name = "label9";
            label9.Size = new Size(36, 25);
            label9.TabIndex = 20;
            label9.Text = "= {";
            // 
            // textBoxSecondVectorName
            // 
            textBoxSecondVectorName.Font = new Font("Segoe UI", 14F);
            textBoxSecondVectorName.Location = new Point(12, 100);
            textBoxSecondVectorName.MaxLength = 2;
            textBoxSecondVectorName.Name = "textBoxSecondVectorName";
            textBoxSecondVectorName.Size = new Size(32, 32);
            textBoxSecondVectorName.TabIndex = 19;
            textBoxSecondVectorName.Text = "b";
            textBoxSecondVectorName.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(12, 72);
            label10.Name = "label10";
            label10.Size = new Size(139, 25);
            label10.TabIndex = 18;
            label10.Text = "Второй вектор";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(346, 166);
            label11.Name = "label11";
            label11.Size = new Size(18, 25);
            label11.TabIndex = 35;
            label11.Text = "}";
            // 
            // textBoxThirdVectorZ
            // 
            textBoxThirdVectorZ.Font = new Font("Segoe UI", 14F);
            textBoxThirdVectorZ.Location = new Point(276, 163);
            textBoxThirdVectorZ.MaxLength = 8;
            textBoxThirdVectorZ.Name = "textBoxThirdVectorZ";
            textBoxThirdVectorZ.PlaceholderText = "0";
            textBoxThirdVectorZ.Size = new Size(64, 32);
            textBoxThirdVectorZ.TabIndex = 34;
            textBoxThirdVectorZ.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.Location = new Point(254, 166);
            label12.Name = "label12";
            label12.Size = new Size(16, 25);
            label12.TabIndex = 33;
            label12.Text = ";";
            // 
            // textBoxThirdVectorY
            // 
            textBoxThirdVectorY.Font = new Font("Segoe UI", 14F);
            textBoxThirdVectorY.Location = new Point(184, 163);
            textBoxThirdVectorY.MaxLength = 8;
            textBoxThirdVectorY.Name = "textBoxThirdVectorY";
            textBoxThirdVectorY.PlaceholderText = "0";
            textBoxThirdVectorY.Size = new Size(64, 32);
            textBoxThirdVectorY.TabIndex = 32;
            textBoxThirdVectorY.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(162, 166);
            label13.Name = "label13";
            label13.Size = new Size(16, 25);
            label13.TabIndex = 31;
            label13.Text = ";";
            // 
            // textBoxThirdVectorX
            // 
            textBoxThirdVectorX.Font = new Font("Segoe UI", 14F);
            textBoxThirdVectorX.Location = new Point(92, 163);
            textBoxThirdVectorX.MaxLength = 8;
            textBoxThirdVectorX.Name = "textBoxThirdVectorX";
            textBoxThirdVectorX.PlaceholderText = "0";
            textBoxThirdVectorX.Size = new Size(64, 32);
            textBoxThirdVectorX.TabIndex = 30;
            textBoxThirdVectorX.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F);
            label14.Location = new Point(50, 166);
            label14.Name = "label14";
            label14.Size = new Size(36, 25);
            label14.TabIndex = 29;
            label14.Text = "= {";
            // 
            // textBoxThirdVectorName
            // 
            textBoxThirdVectorName.Font = new Font("Segoe UI", 14F);
            textBoxThirdVectorName.Location = new Point(12, 163);
            textBoxThirdVectorName.MaxLength = 2;
            textBoxThirdVectorName.Name = "textBoxThirdVectorName";
            textBoxThirdVectorName.Size = new Size(32, 32);
            textBoxThirdVectorName.TabIndex = 28;
            textBoxThirdVectorName.Text = "c";
            textBoxThirdVectorName.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F);
            label15.Location = new Point(12, 135);
            label15.Name = "label15";
            label15.Size = new Size(137, 25);
            label15.TabIndex = 27;
            label15.Text = "Третий вектор";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 14F);
            labelResult.Location = new Point(12, 198);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(71, 25);
            labelResult.TabIndex = 36;
            labelResult.Text = "Ответ: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 611);
            Controls.Add(labelResult);
            Controls.Add(label11);
            Controls.Add(textBoxThirdVectorZ);
            Controls.Add(label12);
            Controls.Add(textBoxThirdVectorY);
            Controls.Add(label13);
            Controls.Add(textBoxThirdVectorX);
            Controls.Add(label14);
            Controls.Add(textBoxThirdVectorName);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(textBoxSecondVectorZ);
            Controls.Add(label7);
            Controls.Add(textBoxSecondVectorY);
            Controls.Add(label8);
            Controls.Add(textBoxSecondVectorX);
            Controls.Add(label9);
            Controls.Add(textBoxSecondVectorName);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(textBoxFirstVectorZ);
            Controls.Add(label3);
            Controls.Add(textBoxFirstVectorY);
            Controls.Add(label2);
            Controls.Add(textBoxFirstVectorX);
            Controls.Add(label4);
            Controls.Add(textBoxFirstVectorName);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonClear);
            Controls.Add(buttonPDF);
            Controls.Add(buttonExcel);
            Controls.Add(buttonWord);
            Controls.Add(buttonInstruction);
            Controls.Add(buttonCalculate);
            Name = "Form1";
            Text = "Смешанное произведение векторов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private Button buttonInstruction;
        private Button buttonWord;
        private Button buttonExcel;
        private Button buttonPDF;
        private Button buttonClear;
        private Button buttonExit;
        private Label label1;
        private TextBox textBoxFirstVectorName;
        private Label label4;
        private TextBox textBoxFirstVectorX;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstVectorY;
        private Label label5;
        private TextBox textBoxFirstVectorZ;
        private Label label6;
        private TextBox textBoxSecondVectorZ;
        private Label label7;
        private TextBox textBoxSecondVectorY;
        private Label label8;
        private TextBox textBoxSecondVectorX;
        private Label label9;
        private TextBox textBoxSecondVectorName;
        private Label label10;
        private Label label11;
        private TextBox textBoxThirdVectorZ;
        private Label label12;
        private TextBox textBoxThirdVectorY;
        private Label label13;
        private TextBox textBoxThirdVectorX;
        private Label label14;
        private TextBox textBoxThirdVectorName;
        private Label label15;
        private Label labelResult;
    }
}
