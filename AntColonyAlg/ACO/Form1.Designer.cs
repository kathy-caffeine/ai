namespace AntColony
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.labelPherStart = new System.Windows.Forms.Label();
            this.labelACount = new System.Windows.Forms.Label();
            this.labelICount = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownACount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownICount = new System.Windows.Forms.NumericUpDown();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxPherStart = new System.Windows.Forms.TextBox();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.columnHeaderFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTextRes = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownACount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownICount)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(12, 191);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(353, 29);
            this.inputFileButton.TabIndex = 0;
            this.inputFileButton.Text = "Выбрать исходный файл";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // labelPherStart
            // 
            this.labelPherStart.AutoSize = true;
            this.labelPherStart.Location = new System.Drawing.Point(18, 153);
            this.labelPherStart.Name = "labelPherStart";
            this.labelPherStart.Size = new System.Drawing.Size(219, 17);
            this.labelPherStart.TabIndex = 1;
            this.labelPherStart.Text = "Начальный уровень феромонов";
            // 
            // labelACount
            // 
            this.labelACount.AutoSize = true;
            this.labelACount.Location = new System.Drawing.Point(18, 12);
            this.labelACount.Name = "labelACount";
            this.labelACount.Size = new System.Drawing.Size(151, 17);
            this.labelACount.TabIndex = 2;
            this.labelACount.Text = "Количество муравьев";
            // 
            // labelICount
            // 
            this.labelICount.AutoSize = true;
            this.labelICount.Location = new System.Drawing.Point(18, 40);
            this.labelICount.Name = "labelICount";
            this.labelICount.Size = new System.Drawing.Size(153, 17);
            this.labelICount.TabIndex = 3;
            this.labelICount.Text = "Количество итераций";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(18, 68);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(51, 17);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "Aльфа";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(18, 96);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(40, 17);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "Бета";
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(245, 94);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownB.TabIndex = 6;
            this.numericUpDownB.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(245, 66);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownA.TabIndex = 7;
            this.numericUpDownA.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(18, 125);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(144, 17);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Скорость испарения";
            // 
            // numericUpDownACount
            // 
            this.numericUpDownACount.Location = new System.Drawing.Point(245, 10);
            this.numericUpDownACount.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numericUpDownACount.Name = "numericUpDownACount";
            this.numericUpDownACount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownACount.TabIndex = 10;
            this.numericUpDownACount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownICount
            // 
            this.numericUpDownICount.Location = new System.Drawing.Point(245, 38);
            this.numericUpDownICount.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.numericUpDownICount.Name = "numericUpDownICount";
            this.numericUpDownICount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownICount.TabIndex = 9;
            this.numericUpDownICount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(245, 122);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(120, 22);
            this.textBoxSpeed.TabIndex = 11;
            this.textBoxSpeed.Text = "0,1";
            // 
            // textBoxPherStart
            // 
            this.textBoxPherStart.Location = new System.Drawing.Point(245, 150);
            this.textBoxPherStart.Name = "textBoxPherStart";
            this.textBoxPherStart.Size = new System.Drawing.Size(120, 22);
            this.textBoxPherStart.TabIndex = 12;
            this.textBoxPherStart.Text = "0,01";
            // 
            // listViewRes
            // 
            this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFrom,
            this.columnHeaderTo,
            this.columnHeaderLength});
            this.listViewRes.HideSelection = false;
            this.listViewRes.Location = new System.Drawing.Point(406, 72);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(329, 366);
            this.listViewRes.TabIndex = 13;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            this.listViewRes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFrom
            // 
            this.columnHeaderFrom.Text = "Ребро из";
            this.columnHeaderFrom.Width = 80;
            // 
            // columnHeaderTo
            // 
            this.columnHeaderTo.Text = "Ребро в";
            this.columnHeaderTo.Width = 80;
            // 
            // columnHeaderLength
            // 
            this.columnHeaderLength.Text = "Длина";
            this.columnHeaderLength.Width = 80;
            // 
            // labelTextRes
            // 
            this.labelTextRes.AutoSize = true;
            this.labelTextRes.Location = new System.Drawing.Point(403, 40);
            this.labelTextRes.Name = "labelTextRes";
            this.labelTextRes.Size = new System.Drawing.Size(179, 17);
            this.labelTextRes.TabIndex = 14;
            this.labelTextRes.Text = "Длина кратчайшего пути:";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(620, 40);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(24, 17);
            this.labelRes.TabIndex = 15;
            this.labelRes.Text = "<>";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 409);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(353, 29);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelTextRes);
            this.Controls.Add(this.listViewRes);
            this.Controls.Add(this.textBoxPherStart);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.numericUpDownACount);
            this.Controls.Add(this.numericUpDownICount);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelICount);
            this.Controls.Add(this.labelACount);
            this.Controls.Add(this.labelPherStart);
            this.Controls.Add(this.inputFileButton);
            this.Name = "Form1";
            this.Text = "Муравьишки";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownACount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownICount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Label labelPherStart;
        private System.Windows.Forms.Label labelACount;
        private System.Windows.Forms.Label labelICount;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownACount;
        private System.Windows.Forms.NumericUpDown numericUpDownICount;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxPherStart;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeaderFrom;
        private System.Windows.Forms.ColumnHeader columnHeaderTo;
        private System.Windows.Forms.ColumnHeader columnHeaderLength;
        private System.Windows.Forms.Label labelTextRes;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button startButton;
    }
}

