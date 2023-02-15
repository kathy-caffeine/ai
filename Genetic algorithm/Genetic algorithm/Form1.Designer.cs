namespace Genetic_algorithm
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
            this.start = new System.Windows.Forms.Button();
            this.radioButton_isDecimalEncodingMode = new System.Windows.Forms.RadioButton();
            this.radioButton_isBinaryEncodingMode = new System.Windows.Forms.RadioButton();
            this.textBox_inputFunction = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_iterationAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_mutationP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_populationSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yMin = new System.Windows.Forms.TextBox();
            this.xMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_bestFunc = new System.Windows.Forms.TextBox();
            this.textBox_bestY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_bestX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(7, 348);
            this.start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(279, 35);
            this.start.TabIndex = 3;
            this.start.Text = "Запустить";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // radioButton_isDecimalEncodingMode
            // 
            this.radioButton_isDecimalEncodingMode.AutoSize = true;
            this.radioButton_isDecimalEncodingMode.Checked = true;
            this.radioButton_isDecimalEncodingMode.Location = new System.Drawing.Point(7, 30);
            this.radioButton_isDecimalEncodingMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_isDecimalEncodingMode.Name = "radioButton_isDecimalEncodingMode";
            this.radioButton_isDecimalEncodingMode.Size = new System.Drawing.Size(112, 24);
            this.radioButton_isDecimalEncodingMode.TabIndex = 40;
            this.radioButton_isDecimalEncodingMode.TabStop = true;
            this.radioButton_isDecimalEncodingMode.Text = "Десятичное";
            this.radioButton_isDecimalEncodingMode.UseVisualStyleBackColor = true;
            // 
            // radioButton_isBinaryEncodingMode
            // 
            this.radioButton_isBinaryEncodingMode.AutoSize = true;
            this.radioButton_isBinaryEncodingMode.Location = new System.Drawing.Point(125, 30);
            this.radioButton_isBinaryEncodingMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_isBinaryEncodingMode.Name = "radioButton_isBinaryEncodingMode";
            this.radioButton_isBinaryEncodingMode.Size = new System.Drawing.Size(100, 24);
            this.radioButton_isBinaryEncodingMode.TabIndex = 26;
            this.radioButton_isBinaryEncodingMode.Text = "Двоичное";
            this.radioButton_isBinaryEncodingMode.UseVisualStyleBackColor = true;
            // 
            // textBox_inputFunction
            // 
            this.textBox_inputFunction.Location = new System.Drawing.Point(7, 82);
            this.textBox_inputFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_inputFunction.Name = "textBox_inputFunction";
            this.textBox_inputFunction.Size = new System.Drawing.Size(279, 27);
            this.textBox_inputFunction.TabIndex = 39;
            this.textBox_inputFunction.Text = "x^2+y^2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 38;
            this.label14.Text = "Функция:";
            // 
            // textBox_iterationCount
            // 
            this.textBox_iterationAmount.Location = new System.Drawing.Point(150, 305);
            this.textBox_iterationAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_iterationAmount.Name = "textBox_iterationCount";
            this.textBox_iterationAmount.Size = new System.Drawing.Size(136, 27);
            this.textBox_iterationAmount.TabIndex = 37;
            this.textBox_iterationAmount.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Число поколений:";
            // 
            // textBox_mutationChance
            // 
            this.textBox_mutationP.Location = new System.Drawing.Point(203, 275);
            this.textBox_mutationP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_mutationP.Name = "textBox_mutationChance";
            this.textBox_mutationP.Size = new System.Drawing.Size(83, 27);
            this.textBox_mutationP.TabIndex = 35;
            this.textBox_mutationP.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Вероятность мутации (%):";
            // 
            // textBox_populationSize
            // 
            this.textBox_populationSize.Location = new System.Drawing.Point(153, 245);
            this.textBox_populationSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_populationSize.Name = "textBox_populationSize";
            this.textBox_populationSize.Size = new System.Drawing.Size(133, 27);
            this.textBox_populationSize.TabIndex = 33;
            this.textBox_populationSize.Text = "30";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Число особей";
            // 
            // textBox_yRangeTo
            // 
            this.yMax.Location = new System.Drawing.Point(202, 214);
            this.yMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yMax.Name = "textBox_yRangeTo";
            this.yMax.Size = new System.Drawing.Size(84, 27);
            this.yMax.TabIndex = 31;
            this.yMax.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Интервал поиска по Y:";
            // 
            // textBox_yRangeFrom
            // 
            this.yMin.Location = new System.Drawing.Point(57, 214);
            this.yMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yMin.Name = "textBox_yRangeFrom";
            this.yMin.Size = new System.Drawing.Size(84, 27);
            this.yMin.TabIndex = 28;
            this.yMin.Text = "-50";
            // 
            // textBox_xRangeTo
            // 
            this.xMax.Location = new System.Drawing.Point(202, 137);
            this.xMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xMax.Name = "textBox_xRangeTo";
            this.xMax.Size = new System.Drawing.Size(84, 27);
            this.xMax.TabIndex = 25;
            this.xMax.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Интервал поиска по X:";
            // 
            // textBox_xRangeFrom
            // 
            this.xMin.Location = new System.Drawing.Point(57, 137);
            this.xMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xMin.Name = "textBox_xRangeFrom";
            this.xMin.Size = new System.Drawing.Size(84, 27);
            this.xMin.TabIndex = 22;
            this.xMin.Text = "-50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Представление генов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "max";
            // 
            // textBox_bestFunc
            // 
            this.textBox_bestFunc.Enabled = false;
            this.textBox_bestFunc.Location = new System.Drawing.Point(153, 463);
            this.textBox_bestFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestFunc.Name = "textBox_bestFunc";
            this.textBox_bestFunc.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestFunc.TabIndex = 49;
            // 
            // textBox_bestY
            // 
            this.textBox_bestY.Enabled = false;
            this.textBox_bestY.Location = new System.Drawing.Point(153, 428);
            this.textBox_bestY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestY.Name = "textBox_bestY";
            this.textBox_bestY.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestY.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Значение функции";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Значение X:";
            // 
            // textBox_bestX
            // 
            this.textBox_bestX.Enabled = false;
            this.textBox_bestX.Location = new System.Drawing.Point(152, 393);
            this.textBox_bestX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestX.Name = "textBox_bestX";
            this.textBox_bestX.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestX.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Значение Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 510);
            this.Controls.Add(this.textBox_bestFunc);
            this.Controls.Add(this.textBox_bestY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_bestX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton_isDecimalEncodingMode);
            this.Controls.Add(this.radioButton_isBinaryEncodingMode);
            this.Controls.Add(this.textBox_inputFunction);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_iterationAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_mutationP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_populationSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yMin);
            this.Controls.Add(this.xMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Скрещивайтес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button start;
        private RadioButton radioButton_isDecimalEncodingMode;
        private RadioButton radioButton_isBinaryEncodingMode;
        private TextBox textBox_inputFunction;
        private Label label14;
        private TextBox textBox_iterationAmount;
        private Label label9;
        private TextBox textBox_mutationP;
        private Label label10;
        private TextBox textBox_populationSize;
        private Label label7;
        private TextBox yMax;
        private Label label5;
        private TextBox yMin;
        private TextBox xMax;
        private Label label3;
        private Label label2;
        private TextBox xMin;
        private Label label1;
        private Label label8;
        private Label label6;
        private Label label15;
        private TextBox textBox_bestFunc;
        private TextBox textBox_bestY;
        private Label label11;
        private Label label13;
        private TextBox textBox_bestX;
        private Label label12;
    }
}