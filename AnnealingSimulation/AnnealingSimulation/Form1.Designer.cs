namespace AnnealingSimulation
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
            this.listViewRes = new System.Windows.Forms.ListView();
            this.columnHeaderFrom = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTo = new System.Windows.Forms.ColumnHeader();
            this.labelTextRes = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.abs_temp = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(12, 13);
            this.inputFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(353, 36);
            this.inputFileButton.TabIndex = 0;
            this.inputFileButton.Text = "Выбрать исходный файл";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // listViewRes
            // 
            this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFrom,
            this.columnHeaderTo});
            this.listViewRes.Location = new System.Drawing.Point(12, 200);
            this.listViewRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(353, 309);
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
            // labelTextRes
            // 
            this.labelTextRes.AutoSize = true;
            this.labelTextRes.Location = new System.Drawing.Point(12, 160);
            this.labelTextRes.Name = "labelTextRes";
            this.labelTextRes.Size = new System.Drawing.Size(185, 20);
            this.labelTextRes.TabIndex = 14;
            this.labelTextRes.Text = "Длина кратчайшего пути:";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(226, 160);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(29, 20);
            this.labelRes.TabIndex = 15;
            this.labelRes.Text = "<>";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 113);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(353, 36);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // abs_temp
            // 
            this.abs_temp.Location = new System.Drawing.Point(12, 79);
            this.abs_temp.Name = "abs_temp";
            this.abs_temp.Size = new System.Drawing.Size(176, 27);
            this.abs_temp.TabIndex = 17;
            this.abs_temp.Text = "0,00001";
            this.abs_temp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(189, 79);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(176, 27);
            this.temp.TabIndex = 18;
            this.temp.Text = "10000,0";
            this.temp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "min t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "max t";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.abs_temp);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelTextRes);
            this.Controls.Add(this.listViewRes);
            this.Controls.Add(this.inputFileButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Отжиг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeaderFrom;
        private System.Windows.Forms.ColumnHeader columnHeaderTo;
        private System.Windows.Forms.Label labelTextRes;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button startButton;
        private TextBox abs_temp;
        private TextBox temp;
        private Label label1;
        private Label label2;
    }
}