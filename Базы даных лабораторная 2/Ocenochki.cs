using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dabse = System.Data.OleDb;

namespace Базы_даных_лабораторная_2
{
    public partial class Ocenochki : Form
    {
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone;
        private string nameoftable = "Студенты";
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        DataSet setOfData;
        public Ocenochki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("SELECT Дисциплины_обучение.Код, Название, Балл FROM Дисциплины_обучение, Дисциплины WHERE Шифр_студента=" + familiya.SelectedValue + " AND Код_дисциплины=Дисциплины.Код", Date_baseone);
            adapter.Fill(setOfData, "Дисциплины_обучение");
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = "Дисциплины_обучение";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns.Add("Оценка", "Оценка");

            Console.WriteLine(dataGridView1.Rows.Count);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int a = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (a >= 90 && a <= 100)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "5";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Green;
                }
                if (a >= 70 && a <= 89)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "4";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Blue;
                }
                if (a >= 60 && a <= 69)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "3";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                }
                if (a >= 50 && a <= 59)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "2";
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                if (a >= 0 && a <= 49)
                {
                    dataGridView1.Rows[i].Cells[3].Value = "very bad";
                    dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Black;
                }
            }
        }

        private void Ocenochki_Load(object sender, EventArgs e)
        {
            var data1 = new List<Dvapolya>();

            Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Date_baseone.Open();
            dabse.OleDbCommand com1 = new dabse.OleDbCommand("Select Фамилия, Шифр FROM Студенты", Date_baseone);
            dabse.OleDbDataReader resulter = com1.ExecuteReader();

            while (resulter.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter[0].ToString().Trim(),
                    firstpole = resulter[1].ToString().Trim()
                };
                data1.Add(mc);
            }

            familiya.DataSource = data1;
            familiya.DisplayMember = "secondpole";
            familiya.ValueMember = "firstpole";
        }

        private void closer_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();
        }

        private void updater_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATE Дисциплины_обучение SET Балл = ? WHERE (Код = ?)";
            command.Parameters.Add("Балл", dabse.OleDbType.Integer, 50, "Балл");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Код", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Код", System.Data.DataRowVersion.Original, null));
            adapter.UpdateCommand = command;
            command.Connection = Date_baseone;

            try
            {
                int amount = adapter.Update(setOfData, "Дисциплины_обучение");
                MessageBox.Show("Обновлено " + amount + " записей");
            }
            catch (Exception WrongSituation)
            { MessageBox.Show(WrongSituation.Message, "Недоразумение, упс..."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double avg = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                avg = avg + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }

            avg = (double) (avg / dataGridView1.Rows.Count - 1);
            textBox1.Text = ("" + avg);
            if (avg >= 90 && avg <= 100) textBox2.Text = ("5");
            if (avg >= 70 && avg <= 89) textBox2.Text = ("4");
            if (avg >= 60 && avg <= 69) textBox2.Text = ("3");
            if (avg < 60) textBox2.Text = ("2");

        }
    }
}