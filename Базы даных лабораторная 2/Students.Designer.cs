namespace Базы_даных_лабораторная_2
{
    partial class Students
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
            this.label1 = new System.Windows.Forms.Label();
            this.Familiya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Grazhdanstvo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DobavitZapis = new System.Windows.Forms.Button();
            this.Zakrit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.specialnost = new System.Windows.Forms.ComboBox();
            this.studyform = new System.Windows.Forms.ComboBox();
            this.priznakotchis = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleter = new System.Windows.Forms.Button();
            this.saver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.shifrStudenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shifrSpecialnosti = new System.Windows.Forms.TextBox();
            this.bbatonishe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // Familiya
            // 
            this.Familiya.Location = new System.Drawing.Point(76, 13);
            this.Familiya.Name = "Familiya";
            this.Familiya.Size = new System.Drawing.Size(196, 20);
            this.Familiya.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(77, 65);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(195, 20);
            this.Otchestvo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Специальность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Гражданство";
            // 
            // Grazhdanstvo
            // 
            this.Grazhdanstvo.Location = new System.Drawing.Point(93, 117);
            this.Grazhdanstvo.Name = "Grazhdanstvo";
            this.Grazhdanstvo.Size = new System.Drawing.Size(135, 20);
            this.Grazhdanstvo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Форма обучения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Признак отчисления";
            // 
            // DobavitZapis
            // 
            this.DobavitZapis.Location = new System.Drawing.Point(4, 241);
            this.DobavitZapis.Name = "DobavitZapis";
            this.DobavitZapis.Size = new System.Drawing.Size(122, 23);
            this.DobavitZapis.TabIndex = 14;
            this.DobavitZapis.Text = "Добавить запись";
            this.DobavitZapis.UseVisualStyleBackColor = true;
            this.DobavitZapis.Click += new System.EventHandler(this.DobavitZapis_Click);
            // 
            // Zakrit
            // 
            this.Zakrit.Location = new System.Drawing.Point(132, 241);
            this.Zakrit.Name = "Zakrit";
            this.Zakrit.Size = new System.Drawing.Size(127, 23);
            this.Zakrit.TabIndex = 15;
            this.Zakrit.Text = "Закрыть";
            this.Zakrit.UseVisualStyleBackColor = true;
            this.Zakrit.Click += new System.EventHandler(this.Zakrit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 269);
            this.dataGridView1.TabIndex = 16;
            // 
            // specialnost
            // 
            this.specialnost.FormattingEnabled = true;
            this.specialnost.Location = new System.Drawing.Point(103, 91);
            this.specialnost.Name = "specialnost";
            this.specialnost.Size = new System.Drawing.Size(125, 21);
            this.specialnost.TabIndex = 17;
            // 
            // studyform
            // 
            this.studyform.FormattingEnabled = true;
            this.studyform.Items.AddRange(new object[] {
            "очная",
            "заочная"});
            this.studyform.Location = new System.Drawing.Point(111, 143);
            this.studyform.Name = "studyform";
            this.studyform.Size = new System.Drawing.Size(117, 21);
            this.studyform.TabIndex = 18;
            // 
            // priznakotchis
            // 
            this.priznakotchis.FormattingEnabled = true;
            this.priznakotchis.Location = new System.Drawing.Point(132, 169);
            this.priznakotchis.Name = "priznakotchis";
            this.priznakotchis.Size = new System.Drawing.Size(96, 21);
            this.priznakotchis.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 97);
            this.button1.TabIndex = 20;
            this.button1.Text = "ЗАГРУЗИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(132, 270);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(127, 23);
            this.deleter.TabIndex = 22;
            this.deleter.Text = "Удалить";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // saver
            // 
            this.saver.Location = new System.Drawing.Point(4, 270);
            this.saver.Name = "saver";
            this.saver.Size = new System.Drawing.Size(122, 23);
            this.saver.TabIndex = 21;
            this.saver.Text = "Сохранить";
            this.saver.UseVisualStyleBackColor = true;
            this.saver.Click += new System.EventHandler(this.saver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Шифр студента";
            // 
            // shifrStudenta
            // 
            this.shifrStudenta.Location = new System.Drawing.Point(103, 197);
            this.shifrStudenta.Name = "shifrStudenta";
            this.shifrStudenta.Size = new System.Drawing.Size(56, 20);
            this.shifrStudenta.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Шифр спец";
            // 
            // shifrSpecialnosti
            // 
            this.shifrSpecialnosti.Location = new System.Drawing.Point(234, 197);
            this.shifrSpecialnosti.Name = "shifrSpecialnosti";
            this.shifrSpecialnosti.Size = new System.Drawing.Size(33, 20);
            this.shifrSpecialnosti.TabIndex = 26;
            // 
            // bbatonishe
            // 
            this.bbatonishe.Location = new System.Drawing.Point(103, 216);
            this.bbatonishe.Name = "bbatonishe";
            this.bbatonishe.Size = new System.Drawing.Size(164, 23);
            this.bbatonishe.TabIndex = 27;
            this.bbatonishe.Text = "Сделать всё хорошо";
            this.bbatonishe.UseVisualStyleBackColor = true;
            this.bbatonishe.Click += new System.EventHandler(this.bbatonishe_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 294);
            this.Controls.Add(this.bbatonishe);
            this.Controls.Add(this.shifrSpecialnosti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shifrStudenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.saver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priznakotchis);
            this.Controls.Add(this.studyform);
            this.Controls.Add(this.specialnost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zakrit);
            this.Controls.Add(this.DobavitZapis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Grazhdanstvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Familiya);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Familiya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Grazhdanstvo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DobavitZapis;
        private System.Windows.Forms.Button Zakrit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox specialnost;
        private System.Windows.Forms.ComboBox studyform;
        private System.Windows.Forms.ComboBox priznakotchis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleter;
        private System.Windows.Forms.Button saver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox shifrStudenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox shifrSpecialnosti;
        private System.Windows.Forms.Button bbatonishe;
    }
}