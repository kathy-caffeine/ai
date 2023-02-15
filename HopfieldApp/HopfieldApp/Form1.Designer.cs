
namespace HopfieldApp
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.known1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRes = new System.Windows.Forms.PictureBox();
            this.known2 = new System.Windows.Forms.PictureBox();
            this.known3 = new System.Windows.Forms.PictureBox();
            this.known4 = new System.Windows.Forms.PictureBox();
            this.recognise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.known1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.known2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.known3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.known4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(200, 247);
            this.pictureBoxInput.TabIndex = 16;
            this.pictureBoxInput.TabStop = false;
            this.pictureBoxInput.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // known1
            // 
            this.known1.Location = new System.Drawing.Point(19, 302);
            this.known1.Name = "known1";
            this.known1.Size = new System.Drawing.Size(107, 146);
            this.known1.TabIndex = 17;
            this.known1.TabStop = false;
            // 
            // pictureBoxRes
            // 
            this.pictureBoxRes.Location = new System.Drawing.Point(367, 12);
            this.pictureBoxRes.Name = "pictureBoxRes";
            this.pictureBoxRes.Size = new System.Drawing.Size(200, 247);
            this.pictureBoxRes.TabIndex = 21;
            this.pictureBoxRes.TabStop = false;
            // 
            // known2
            // 
            this.known2.Location = new System.Drawing.Point(163, 302);
            this.known2.Name = "known2";
            this.known2.Size = new System.Drawing.Size(107, 146);
            this.known2.TabIndex = 22;
            this.known2.TabStop = false;
            // 
            // known3
            // 
            this.known3.Location = new System.Drawing.Point(307, 302);
            this.known3.Name = "known3";
            this.known3.Size = new System.Drawing.Size(107, 146);
            this.known3.TabIndex = 23;
            this.known3.TabStop = false;
            // 
            // known4
            // 
            this.known4.Location = new System.Drawing.Point(451, 302);
            this.known4.Name = "known4";
            this.known4.Size = new System.Drawing.Size(107, 146);
            this.known4.TabIndex = 24;
            this.known4.TabStop = false;
            // 
            // recognise
            // 
            this.recognise.Location = new System.Drawing.Point(218, 104);
            this.recognise.Name = "recognise";
            this.recognise.Size = new System.Drawing.Size(143, 50);
            this.recognise.TabIndex = 25;
            this.recognise.Text = "Распознать";
            this.recognise.UseVisualStyleBackColor = true;
            this.recognise.Click += new System.EventHandler(this.recognise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(196, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Известные образы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recognise);
            this.Controls.Add(this.known4);
            this.Controls.Add(this.known3);
            this.Controls.Add(this.known2);
            this.Controls.Add(this.pictureBoxRes);
            this.Controls.Add(this.known1);
            this.Controls.Add(this.pictureBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.known1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.known2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.known3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.known4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox known1;
        private System.Windows.Forms.PictureBox pictureBoxRes;
        private System.Windows.Forms.PictureBox known2;
        private System.Windows.Forms.PictureBox known3;
        private System.Windows.Forms.PictureBox known4;
        private System.Windows.Forms.Button recognise;
        private System.Windows.Forms.Label label1;
    }
}

