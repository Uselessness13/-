namespace Базы_даных_лабораторная_2
{
    partial class Dvapolya
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxShifr = new System.Windows.Forms.TextBox();
            this.textBoxNazvanie = new System.Windows.Forms.TextBox();
            this.textBoxSrok_obucheniya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Shifr = new System.Windows.Forms.Label();
            this.Nazvanie = new System.Windows.Forms.Label();
            this.Srok_obucheniya = new System.Windows.Forms.Label();
            this.Zapisat = new System.Windows.Forms.Button();
            this.Zkrit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.saver = new System.Windows.Forms.Button();
            this.deleter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxShifr
            // 
            this.textBoxShifr.Location = new System.Drawing.Point(99, 12);
            this.textBoxShifr.Name = "textBoxShifr";
            this.textBoxShifr.Size = new System.Drawing.Size(173, 20);
            this.textBoxShifr.TabIndex = 0;
            // 
            // textBoxNazvanie
            // 
            this.textBoxNazvanie.Location = new System.Drawing.Point(99, 51);
            this.textBoxNazvanie.Name = "textBoxNazvanie";
            this.textBoxNazvanie.Size = new System.Drawing.Size(173, 20);
            this.textBoxNazvanie.TabIndex = 1;
            // 
            // textBoxSrok_obucheniya
            // 
            this.textBoxSrok_obucheniya.Location = new System.Drawing.Point(99, 94);
            this.textBoxSrok_obucheniya.Name = "textBoxSrok_obucheniya";
            this.textBoxSrok_obucheniya.Size = new System.Drawing.Size(173, 20);
            this.textBoxSrok_obucheniya.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Shifr
            // 
            this.Shifr.AutoSize = true;
            this.Shifr.Location = new System.Drawing.Point(12, 15);
            this.Shifr.Name = "Shifr";
            this.Shifr.Size = new System.Drawing.Size(36, 13);
            this.Shifr.TabIndex = 4;
            this.Shifr.Text = "Шифр";
            // 
            // Nazvanie
            // 
            this.Nazvanie.AutoSize = true;
            this.Nazvanie.Location = new System.Drawing.Point(12, 54);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(57, 13);
            this.Nazvanie.TabIndex = 5;
            this.Nazvanie.Text = "Название";
            // 
            // Srok_obucheniya
            // 
            this.Srok_obucheniya.AutoSize = true;
            this.Srok_obucheniya.Location = new System.Drawing.Point(12, 97);
            this.Srok_obucheniya.Name = "Srok_obucheniya";
            this.Srok_obucheniya.Size = new System.Drawing.Size(84, 13);
            this.Srok_obucheniya.TabIndex = 6;
            this.Srok_obucheniya.Text = "Срок_обучения";
            // 
            // Zapisat
            // 
            this.Zapisat.Location = new System.Drawing.Point(8, 120);
            this.Zapisat.Name = "Zapisat";
            this.Zapisat.Size = new System.Drawing.Size(264, 33);
            this.Zapisat.TabIndex = 7;
            this.Zapisat.Text = "Записать";
            this.Zapisat.UseVisualStyleBackColor = true;
            this.Zapisat.Click += new System.EventHandler(this.Zapisat_Click);
            // 
            // Zkrit
            // 
            this.Zkrit.Location = new System.Drawing.Point(8, 159);
            this.Zkrit.Name = "Zkrit";
            this.Zkrit.Size = new System.Drawing.Size(75, 40);
            this.Zkrit.TabIndex = 8;
            this.Zkrit.Text = "Закрыть";
            this.Zkrit.UseVisualStyleBackColor = true;
            this.Zkrit.Click += new System.EventHandler(this.Zkrit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 187);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saver
            // 
            this.saver.Location = new System.Drawing.Point(90, 159);
            this.saver.Name = "saver";
            this.saver.Size = new System.Drawing.Size(101, 40);
            this.saver.TabIndex = 11;
            this.saver.Text = "Сохранить изменения";
            this.saver.UseVisualStyleBackColor = true;
            this.saver.Click += new System.EventHandler(this.saver_Click);
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(676, 8);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(39, 193);
            this.deleter.TabIndex = 12;
            this.deleter.Text = "УдАЛиТь ВыБрАнУю ЗаПиСь";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // Dvapolya
            // 
            this.ClientSize = new System.Drawing.Size(727, 213);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.saver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zkrit);
            this.Controls.Add(this.Zapisat);
            this.Controls.Add(this.Srok_obucheniya);
            this.Controls.Add(this.Nazvanie);
            this.Controls.Add(this.Shifr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSrok_obucheniya);
            this.Controls.Add(this.textBoxNazvanie);
            this.Controls.Add(this.textBoxShifr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dvapolya";
            this.Text = "Специальности";
            this.Load += new System.EventHandler(this.Specialnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShifr;
        private System.Windows.Forms.TextBox textBoxNazvanie;
        private System.Windows.Forms.TextBox textBoxSrok_obucheniya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Shifr;
        private System.Windows.Forms.Label Nazvanie;
        private System.Windows.Forms.Label Srok_obucheniya;
        private System.Windows.Forms.Button Zapisat;
        private System.Windows.Forms.Button Zkrit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saver;
        private System.Windows.Forms.Button deleter;
    }
}

