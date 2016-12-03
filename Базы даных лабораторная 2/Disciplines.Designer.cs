namespace Базы_даных_лабораторная_2
{
    partial class Disciplines
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
            this.NazvanieDisciplinelabel = new System.Windows.Forms.Label();
            this.NameOfDiscipline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dobavit = new System.Windows.Forms.Button();
            this.Zakrit = new System.Windows.Forms.Button();
            this.FormaControla = new System.Windows.Forms.ComboBox();
            this.Semestr = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deleter = new System.Windows.Forms.Button();
            this.saver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NazvanieDisciplinelabel
            // 
            this.NazvanieDisciplinelabel.AutoSize = true;
            this.NazvanieDisciplinelabel.Location = new System.Drawing.Point(12, 16);
            this.NazvanieDisciplinelabel.Name = "NazvanieDisciplinelabel";
            this.NazvanieDisciplinelabel.Size = new System.Drawing.Size(122, 13);
            this.NazvanieDisciplinelabel.TabIndex = 0;
            this.NazvanieDisciplinelabel.Text = "Название дисциплины";
            // 
            // NameOfDiscipline
            // 
            this.NameOfDiscipline.Location = new System.Drawing.Point(140, 13);
            this.NameOfDiscipline.Name = "NameOfDiscipline";
            this.NameOfDiscipline.Size = new System.Drawing.Size(215, 20);
            this.NameOfDiscipline.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cпециальность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Форма контроля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Семестр (число)";
            // 
            // Dobavit
            // 
            this.Dobavit.Location = new System.Drawing.Point(15, 128);
            this.Dobavit.Name = "Dobavit";
            this.Dobavit.Size = new System.Drawing.Size(339, 48);
            this.Dobavit.TabIndex = 8;
            this.Dobavit.Text = "Добавить запись";
            this.Dobavit.UseVisualStyleBackColor = true;
            this.Dobavit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zakrit
            // 
            this.Zakrit.Location = new System.Drawing.Point(15, 182);
            this.Zakrit.Name = "Zakrit";
            this.Zakrit.Size = new System.Drawing.Size(171, 39);
            this.Zakrit.TabIndex = 9;
            this.Zakrit.Text = "Закрыть";
            this.Zakrit.UseVisualStyleBackColor = true;
            this.Zakrit.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormaControla
            // 
            this.FormaControla.FormattingEnabled = true;
            this.FormaControla.Items.AddRange(new object[] {
            "экзамен",
            "зачет"});
            this.FormaControla.Location = new System.Drawing.Point(112, 65);
            this.FormaControla.Name = "FormaControla";
            this.FormaControla.Size = new System.Drawing.Size(243, 21);
            this.FormaControla.TabIndex = 10;
            // 
            // Semestr
            // 
            this.Semestr.FormattingEnabled = true;
            this.Semestr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Semestr.Location = new System.Drawing.Point(111, 92);
            this.Semestr.Name = "Semestr";
            this.Semestr.Size = new System.Drawing.Size(243, 21);
            this.Semestr.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 165);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(194, 398);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(161, 39);
            this.deleter.TabIndex = 16;
            this.deleter.Text = "Удалить";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // saver
            // 
            this.saver.Location = new System.Drawing.Point(16, 398);
            this.saver.Name = "saver";
            this.saver.Size = new System.Drawing.Size(171, 39);
            this.saver.TabIndex = 15;
            this.saver.Text = "Сохрaнить";
            this.saver.UseVisualStyleBackColor = true;
            this.saver.Click += new System.EventHandler(this.saver_Click);
            // 
            // Disciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 449);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.saver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Semestr);
            this.Controls.Add(this.FormaControla);
            this.Controls.Add(this.Zakrit);
            this.Controls.Add(this.Dobavit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfDiscipline);
            this.Controls.Add(this.NazvanieDisciplinelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Disciplines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Disciplines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazvanieDisciplinelabel;
        private System.Windows.Forms.TextBox NameOfDiscipline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dobavit;
        private System.Windows.Forms.Button Zakrit;
        private System.Windows.Forms.ComboBox FormaControla;
        private System.Windows.Forms.ComboBox Semestr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleter;
        private System.Windows.Forms.Button saver;
    }
}