
namespace lab3_GeneticAlgorithm
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
            this.TextFunc = new System.Windows.Forms.TextBox();
            this.labelTextFunc = new System.Windows.Forms.Label();
            this.labelSizePop = new System.Windows.Forms.Label();
            this.labelIterCount = new System.Windows.Forms.Label();
            this.labelMutChance = new System.Windows.Forms.Label();
            this.labelCoupChance = new System.Windows.Forms.Label();
            this.numericUpDownPopSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIterCount = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.columnHeaderIter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPopChance = new System.Windows.Forms.TextBox();
            this.textBoxMutChance = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TextFunc
            // 
            this.TextFunc.Location = new System.Drawing.Point(15, 28);
            this.TextFunc.Name = "TextFunc";
            this.TextFunc.Size = new System.Drawing.Size(313, 22);
            this.TextFunc.TabIndex = 0;
            this.TextFunc.Text = "Pow((x-6),2) + Pow((y-3),2)";
            // 
            // labelTextFunc
            // 
            this.labelTextFunc.AutoSize = true;
            this.labelTextFunc.Location = new System.Drawing.Point(12, 9);
            this.labelTextFunc.Name = "labelTextFunc";
            this.labelTextFunc.Size = new System.Drawing.Size(67, 16);
            this.labelTextFunc.TabIndex = 1;
            this.labelTextFunc.Text = "Функция:";
            // 
            // labelSizePop
            // 
            this.labelSizePop.AutoSize = true;
            this.labelSizePop.Location = new System.Drawing.Point(180, 99);
            this.labelSizePop.Name = "labelSizePop";
            this.labelSizePop.Size = new System.Drawing.Size(134, 16);
            this.labelSizePop.TabIndex = 2;
            this.labelSizePop.Text = "Размер популяции:";
            // 
            // labelIterCount
            // 
            this.labelIterCount.AutoSize = true;
            this.labelIterCount.Location = new System.Drawing.Point(170, 54);
            this.labelIterCount.Name = "labelIterCount";
            this.labelIterCount.Size = new System.Drawing.Size(154, 16);
            this.labelIterCount.TabIndex = 3;
            this.labelIterCount.Text = "Количество итераций:";
            // 
            // labelMutChance
            // 
            this.labelMutChance.AutoSize = true;
            this.labelMutChance.Location = new System.Drawing.Point(29, 98);
            this.labelMutChance.Name = "labelMutChance";
            this.labelMutChance.Size = new System.Drawing.Size(103, 16);
            this.labelMutChance.TabIndex = 4;
            this.labelMutChance.Text = "Шанс мутаций:";
            // 
            // labelCoupChance
            // 
            this.labelCoupChance.AutoSize = true;
            this.labelCoupChance.Location = new System.Drawing.Point(14, 53);
            this.labelCoupChance.Name = "labelCoupChance";
            this.labelCoupChance.Size = new System.Drawing.Size(133, 16);
            this.labelCoupChance.TabIndex = 5;
            this.labelCoupChance.Text = "Шанс скрещивания:";
            // 
            // numericUpDownPopSize
            // 
            this.numericUpDownPopSize.Location = new System.Drawing.Point(182, 118);
            this.numericUpDownPopSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPopSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPopSize.Name = "numericUpDownPopSize";
            this.numericUpDownPopSize.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownPopSize.TabIndex = 6;
            this.numericUpDownPopSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownIterCount
            // 
            this.numericUpDownIterCount.Location = new System.Drawing.Point(182, 73);
            this.numericUpDownIterCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIterCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterCount.Name = "numericUpDownIterCount";
            this.numericUpDownIterCount.Size = new System.Drawing.Size(131, 22);
            this.numericUpDownIterCount.TabIndex = 7;
            this.numericUpDownIterCount.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(9, 282);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(316, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Запуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Результат:";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(95, 308);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(16, 16);
            this.labelRes.TabIndex = 12;
            this.labelRes.Text = "...";
            // 
            // listViewRes
            // 
            this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIter,
            this.columnHeaderX,
            this.columnHeaderY,
            this.answer1});
            this.listViewRes.HideSelection = false;
            this.listViewRes.Location = new System.Drawing.Point(12, 327);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(313, 264);
            this.listViewRes.TabIndex = 13;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            this.listViewRes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderIter
            // 
            this.columnHeaderIter.Text = "Итерация";
            // 
            // columnHeaderX
            // 
            this.columnHeaderX.Text = "X";
            // 
            // columnHeaderY
            // 
            this.columnHeaderY.Text = "Y";
            // 
            // answer1
            // 
            this.answer1.Text = "Значение";
            // 
            // textBoxPopChance
            // 
            this.textBoxPopChance.Location = new System.Drawing.Point(15, 73);
            this.textBoxPopChance.Name = "textBoxPopChance";
            this.textBoxPopChance.Size = new System.Drawing.Size(130, 22);
            this.textBoxPopChance.TabIndex = 14;
            this.textBoxPopChance.Text = "0,65";
            // 
            // textBoxMutChance
            // 
            this.textBoxMutChance.Location = new System.Drawing.Point(15, 117);
            this.textBoxMutChance.Name = "textBoxMutChance";
            this.textBoxMutChance.Size = new System.Drawing.Size(130, 22);
            this.textBoxMutChance.TabIndex = 15;
            this.textBoxMutChance.Text = "0,1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Десятичный";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(200, 146);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Двоичный";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "100";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "-10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "X min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "X max";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "100";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 22);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "-10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Y min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Y max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 603);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBoxMutChance);
            this.Controls.Add(this.textBoxPopChance);
            this.Controls.Add(this.listViewRes);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownIterCount);
            this.Controls.Add(this.numericUpDownPopSize);
            this.Controls.Add(this.labelCoupChance);
            this.Controls.Add(this.labelMutChance);
            this.Controls.Add(this.labelIterCount);
            this.Controls.Add(this.labelSizePop);
            this.Controls.Add(this.labelTextFunc);
            this.Controls.Add(this.TextFunc);
            this.Name = "Form1";
            this.Text = "Скрещивайтес";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextFunc;
        private System.Windows.Forms.Label labelTextFunc;
        private System.Windows.Forms.Label labelSizePop;
        private System.Windows.Forms.Label labelIterCount;
        private System.Windows.Forms.Label labelMutChance;
        private System.Windows.Forms.Label labelCoupChance;
        private System.Windows.Forms.NumericUpDown numericUpDownPopSize;
        private System.Windows.Forms.NumericUpDown numericUpDownIterCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeaderIter;
        private System.Windows.Forms.ColumnHeader columnHeaderX;
        private System.Windows.Forms.ColumnHeader columnHeaderY;
        private System.Windows.Forms.TextBox textBoxPopChance;
        private System.Windows.Forms.TextBox textBoxMutChance;
        private System.Windows.Forms.ColumnHeader answer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

