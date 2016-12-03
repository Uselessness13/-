namespace Базы_даных_лабораторная_2
{
    partial class MainForm
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
            this.SwichToSpec = new System.Windows.Forms.Button();
            this.SwichToGroups = new System.Windows.Forms.Button();
            this.SwichToDisciplines = new System.Windows.Forms.Button();
            this.SwichToGroupsStud = new System.Windows.Forms.Button();
            this.SwichToStudents = new System.Windows.Forms.Button();
            this.swichToZapros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите, в какую таблицу хотите внести изменения";
            // 
            // SwichToSpec
            // 
            this.SwichToSpec.Location = new System.Drawing.Point(12, 35);
            this.SwichToSpec.Name = "SwichToSpec";
            this.SwichToSpec.Size = new System.Drawing.Size(110, 23);
            this.SwichToSpec.TabIndex = 1;
            this.SwichToSpec.Text = "Специальности";
            this.SwichToSpec.UseVisualStyleBackColor = true;
            this.SwichToSpec.Click += new System.EventHandler(this.SwichToSpec_Click);
            // 
            // SwichToGroups
            // 
            this.SwichToGroups.Location = new System.Drawing.Point(143, 35);
            this.SwichToGroups.Name = "SwichToGroups";
            this.SwichToGroups.Size = new System.Drawing.Size(129, 23);
            this.SwichToGroups.TabIndex = 2;
            this.SwichToGroups.Text = "Группы";
            this.SwichToGroups.UseVisualStyleBackColor = true;
            this.SwichToGroups.Click += new System.EventHandler(this.SwichToGroups_Click);
            // 
            // SwichToDisciplines
            // 
            this.SwichToDisciplines.Location = new System.Drawing.Point(12, 64);
            this.SwichToDisciplines.Name = "SwichToDisciplines";
            this.SwichToDisciplines.Size = new System.Drawing.Size(110, 24);
            this.SwichToDisciplines.TabIndex = 3;
            this.SwichToDisciplines.Text = "Дисциплины";
            this.SwichToDisciplines.UseVisualStyleBackColor = true;
            this.SwichToDisciplines.Click += new System.EventHandler(this.SwichToDisciplines_Click);
            // 
            // SwichToGroupsStud
            // 
            this.SwichToGroupsStud.Location = new System.Drawing.Point(143, 64);
            this.SwichToGroupsStud.Name = "SwichToGroupsStud";
            this.SwichToGroupsStud.Size = new System.Drawing.Size(129, 23);
            this.SwichToGroupsStud.TabIndex = 4;
            this.SwichToGroupsStud.Text = "Группы обучение";
            this.SwichToGroupsStud.UseVisualStyleBackColor = true;
            this.SwichToGroupsStud.Click += new System.EventHandler(this.SwichToGroupsStud_Click);
            // 
            // SwichToStudents
            // 
            this.SwichToStudents.Location = new System.Drawing.Point(13, 93);
            this.SwichToStudents.Name = "SwichToStudents";
            this.SwichToStudents.Size = new System.Drawing.Size(109, 23);
            this.SwichToStudents.TabIndex = 5;
            this.SwichToStudents.Text = "Студенты";
            this.SwichToStudents.UseVisualStyleBackColor = true;
            this.SwichToStudents.Click += new System.EventHandler(this.SwichToStudents_Click);
            // 
            // swichToZapros
            // 
            this.swichToZapros.Location = new System.Drawing.Point(143, 93);
            this.swichToZapros.Name = "swichToZapros";
            this.swichToZapros.Size = new System.Drawing.Size(129, 23);
            this.swichToZapros.TabIndex = 6;
            this.swichToZapros.Text = "Сделать запрос";
            this.swichToZapros.UseVisualStyleBackColor = true;
            this.swichToZapros.Click += new System.EventHandler(this.swichToZapros_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Оценки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swichToZapros);
            this.Controls.Add(this.SwichToStudents);
            this.Controls.Add(this.SwichToGroupsStud);
            this.Controls.Add(this.SwichToDisciplines);
            this.Controls.Add(this.SwichToGroups);
            this.Controls.Add(this.SwichToSpec);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SwichToSpec;
        private System.Windows.Forms.Button SwichToGroups;
        private System.Windows.Forms.Button SwichToDisciplines;
        private System.Windows.Forms.Button SwichToGroupsStud;
        private System.Windows.Forms.Button SwichToStudents;
        private System.Windows.Forms.Button swichToZapros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}