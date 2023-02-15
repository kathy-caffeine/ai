namespace BeeSwarm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_neighborhoodSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_pointsToCheckCount = new System.Windows.Forms.TextBox();
            this.textBox_inputFunction = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_iterationCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_populationSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_yRangeTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_yRangeFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_xRangeTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_xRangeFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_bestFunc = new System.Windows.Forms.TextBox();
            this.textBox_bestY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_bestX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox_neighborhoodSize);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_pointsToCheckCount);
            this.groupBox1.Controls.Add(this.textBox_inputFunction);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_iterationCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_populationSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_yRangeTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_yRangeFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_xRangeTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_xRangeFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(378, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Размер окрестности:";
            // 
            // textBox_neighborhoodSize
            // 
            this.textBox_neighborhoodSize.Location = new System.Drawing.Point(239, 351);
            this.textBox_neighborhoodSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_neighborhoodSize.Name = "textBox_neighborhoodSize";
            this.textBox_neighborhoodSize.Size = new System.Drawing.Size(133, 27);
            this.textBox_neighborhoodSize.TabIndex = 28;
            this.textBox_neighborhoodSize.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Число точек для исследования:\r\n";
            // 
            // textBox_pointsToCheckCount
            // 
            this.textBox_pointsToCheckCount.Location = new System.Drawing.Point(239, 316);
            this.textBox_pointsToCheckCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_pointsToCheckCount.Name = "textBox_pointsToCheckCount";
            this.textBox_pointsToCheckCount.Size = new System.Drawing.Size(133, 27);
            this.textBox_pointsToCheckCount.TabIndex = 20;
            this.textBox_pointsToCheckCount.Text = "40";
            // 
            // textBox_inputFunction
            // 
            this.textBox_inputFunction.Location = new System.Drawing.Point(7, 53);
            this.textBox_inputFunction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_inputFunction.Name = "textBox_inputFunction";
            this.textBox_inputFunction.Size = new System.Drawing.Size(300, 27);
            this.textBox_inputFunction.TabIndex = 19;
            this.textBox_inputFunction.Text = "x^2+y^2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(332, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Введите функцию для нахождения минимума:";
            // 
            // textBox_iterationCount
            // 
            this.textBox_iterationCount.Location = new System.Drawing.Point(239, 277);
            this.textBox_iterationCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_iterationCount.Name = "textBox_iterationCount";
            this.textBox_iterationCount.Size = new System.Drawing.Size(133, 27);
            this.textBox_iterationCount.TabIndex = 17;
            this.textBox_iterationCount.Text = "25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Число поколений:";
            // 
            // textBox_populationSize
            // 
            this.textBox_populationSize.Location = new System.Drawing.Point(239, 239);
            this.textBox_populationSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_populationSize.Name = "textBox_populationSize";
            this.textBox_populationSize.Size = new System.Drawing.Size(133, 27);
            this.textBox_populationSize.TabIndex = 11;
            this.textBox_populationSize.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Численность популяции:";
            // 
            // textBox_yRangeTo
            // 
            this.textBox_yRangeTo.Location = new System.Drawing.Point(202, 204);
            this.textBox_yRangeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_yRangeTo.Name = "textBox_yRangeTo";
            this.textBox_yRangeTo.Size = new System.Drawing.Size(84, 27);
            this.textBox_yRangeTo.TabIndex = 9;
            this.textBox_yRangeTo.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Интервал поиска по Y:";
            // 
            // textBox_yRangeFrom
            // 
            this.textBox_yRangeFrom.Location = new System.Drawing.Point(57, 204);
            this.textBox_yRangeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_yRangeFrom.Name = "textBox_yRangeFrom";
            this.textBox_yRangeFrom.Size = new System.Drawing.Size(84, 27);
            this.textBox_yRangeFrom.TabIndex = 6;
            this.textBox_yRangeFrom.Text = "-50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "от";
            // 
            // textBox_xRangeTo
            // 
            this.textBox_xRangeTo.Location = new System.Drawing.Point(202, 125);
            this.textBox_xRangeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_xRangeTo.Name = "textBox_xRangeTo";
            this.textBox_xRangeTo.Size = new System.Drawing.Size(84, 27);
            this.textBox_xRangeTo.TabIndex = 4;
            this.textBox_xRangeTo.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Интервал поиска по X:";
            // 
            // textBox_xRangeFrom
            // 
            this.textBox_xRangeFrom.Location = new System.Drawing.Point(57, 125);
            this.textBox_xRangeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_xRangeFrom.Name = "textBox_xRangeFrom";
            this.textBox_xRangeFrom.Size = new System.Drawing.Size(84, 27);
            this.textBox_xRangeFrom.TabIndex = 1;
            this.textBox_xRangeFrom.Text = "-50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "от";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_bestFunc);
            this.groupBox2.Controls.Add(this.textBox_bestY);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_bestX);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(9, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(383, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // textBox_bestFunc
            // 
            this.textBox_bestFunc.Enabled = false;
            this.textBox_bestFunc.Location = new System.Drawing.Point(239, 111);
            this.textBox_bestFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestFunc.Name = "textBox_bestFunc";
            this.textBox_bestFunc.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestFunc.TabIndex = 23;
            // 
            // textBox_bestY
            // 
            this.textBox_bestY.Enabled = false;
            this.textBox_bestY.Location = new System.Drawing.Point(239, 72);
            this.textBox_bestY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestY.Name = "textBox_bestY";
            this.textBox_bestY.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestY.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Значение функции";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Значение X:";
            // 
            // textBox_bestX
            // 
            this.textBox_bestX.Enabled = false;
            this.textBox_bestX.Location = new System.Drawing.Point(238, 33);
            this.textBox_bestX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_bestX.Name = "textBox_bestX";
            this.textBox_bestX.Size = new System.Drawing.Size(133, 27);
            this.textBox_bestX.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Значение Y:";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(14, 424);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(378, 47);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Запуск";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 652);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Пчёлки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_iterationCount;
        private Label label9;
        private TextBox textBox_populationSize;
        private Label label7;
        private TextBox textBox_yRangeTo;
        private Label label4;
        private Label label5;
        private TextBox textBox_yRangeFrom;
        private Label label6;
        private TextBox textBox_xRangeTo;
        private Label label3;
        private Label label2;
        private TextBox textBox_xRangeFrom;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox10;
        private Label label11;
        private Label label13;
        private TextBox textBox11;
        private Label label12;
        private Button button_start;
        private TextBox textBox_bestY;
        private TextBox textBox_bestX;
        private TextBox textBox_bestFunc;
        private TextBox textBox_inputFunction;
        private Label label14;
        private Label label8;
        private TextBox textBox_pointsToCheckCount;
        private TextBox textBox_neighborhoodSize;
        private Label label17;
    }
}