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
    public partial class Disciplines : Form
    {
        dabse.OleDbCommand command = new dabse.OleDbCommand();
        private string nameoftable = "Дисциплины";
        dabse.OleDbDataAdapter adapter;
        DataSet setOfData;
        dabse.OleDbConnection Date_baseone;
        public Disciplines()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var Command = new dabse.OleDbCommand("INSERT INTO Дисциплины (Название, Шифр_специальности, Форма_контроля, Семестр) VALUES (?, ?, ?, ?)");

            Command.Parameters.Add("Название", dabse.OleDbType.VarWChar).Value = NameOfDiscipline.Text;
            Command.Parameters.Add("Шифр_специальности", dabse.OleDbType.Integer).Value = int.Parse(comboBox1.SelectedValue.ToString());
            Command.Parameters.Add("Форма_контроля", dabse.OleDbType.VarWChar).Value = FormaControla.Text;
            Command.Parameters.Add("Семестр", dabse.OleDbType.Integer).Value = int.Parse(Semestr.Text);

            Command.Connection = Date_baseone;
            Command.ExecuteNonQuery();

            MessageBox.Show("Запись добавлена");
        }

        private void Disciplines_Load(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = MainForm.FunctionOfAdding(nameoftable);

            var data1 = new List<Dvapolya>();
            Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Date_baseone.Open();
            dabse.OleDbCommand com1 = new dabse.OleDbCommand("Select Название, Шифр FROM Специальности", Date_baseone);
            dabse.OleDbDataReader resulter1 = com1.ExecuteReader();

            while (resulter1.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter1[0].ToString().Trim(),
                    firstpole = resulter1[1].ToString().Trim()
                };
                data1.Add(mc);
            }

            comboBox1.DataSource = data1;
            comboBox1.DisplayMember = "secondpole";
            comboBox1.ValueMember = "firstpole";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone);
            adapter.Fill(setOfData, nameoftable);

            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;

            MessageBox.Show("Загружено!");
        }

        private void saver_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATE Группы_обучение SET Название = ?, Шифр_специальности = ?, Форма_контроля = ?, Семестр = ? WHERE Код = ?";
            command.Parameters.Add("Название", dabse.OleDbType.VarWChar, 50, "Название");
            command.Parameters.Add("Шифр_специальности", dabse.OleDbType.Integer, 50, "Шифр_специальности");
            command.Parameters.Add("Форма_контроля", dabse.OleDbType.VarWChar, 50, "Форма_контроля");
            command.Parameters.Add("Семестр", dabse.OleDbType.Integer, 50, "Семестр");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Код", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Код", System.Data.DataRowVersion.Original, null));

            command.Connection = Date_baseone;
            adapter.UpdateCommand = command;

            try
            {
                int kol = adapter.Update(setOfData, nameoftable);
                MessageBox.Show("Обновлено " + kol + " записей");
                Date_baseone.Close();
            }
            catch (Exception Ситуация_однако)
            { MessageBox.Show(Ситуация_однако.Message, "Недоразумение"); }
        }

        private void deleter_Click(object sender, EventArgs e)
        {
            var deletecommand = new dabse.OleDbCommand("Delete from "+nameoftable+" where Код = ?");
            int gn = (int)dataGridView1.CurrentRow.Cells[0].Value;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = gn;
            deletecommand.Connection = Date_baseone;
            int deletedrows = deletecommand.ExecuteNonQuery();
            MessageBox.Show("Удалена " + deletedrows + " запись");

        }
    }
}
