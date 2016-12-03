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
    public partial class GroupsStudy : Form
    {
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
        DataSet setOfData;
        private string nameoftable = "Группы_обучение";
        dabse.OleDbCommand command;
        public GroupsStudy()
        {
            InitializeComponent();
        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();
        }



        private void InsertZapis_Click(object sender, EventArgs e)
        {            
            var Command1 = new dabse.OleDbCommand("INSERT INTO "+nameoftable+" (Номер_группы, Шифр_студента, Год) VALUES (?, ?, ?)");

            Command1.Parameters.Add("Номер_группы", dabse.OleDbType.Integer).Value = int.Parse(comboBox1.SelectedValue.ToString());
            Command1.Parameters.Add("Шифр_студента", dabse.OleDbType.Integer).Value = int.Parse(comboBox2.SelectedValue.ToString());
            Command1.Parameters.Add("Год", dabse.OleDbType.Integer).Value = int.Parse(comboBox3.SelectedValue.ToString());

            Command1.Connection = Date_baseone;
            Command1.ExecuteNonQuery();

            MessageBox.Show("Запись добавлена");
        }

        private void GroupsStudy_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
            var data1 = new List<Dvapolya>();
            var data2 = new List<Dvapolya>();
            var data3 = new List<string>();
            
            dabse.OleDbCommand com1 = new dabse.OleDbCommand("Select Название, Номер FROM Группы", Date_baseone);
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
            dabse.OleDbCommand com2 = new dabse.OleDbCommand("Select Фамилия, Имя, Отчество, Шифр FROM Студенты", Date_baseone);
            dabse.OleDbDataReader resulter2 = com2.ExecuteReader();

            while (resulter2.Read() == true)
            {
                var mc = new Dvapolya
                {
                    secondpole = resulter2[0].ToString().Trim()+" " +  resulter2[1].ToString().Trim()+" " +resulter2[2].ToString().Trim(),
                    firstpole = resulter2[3].ToString().Trim()
                };
                data2.Add(mc);
            }

            dabse.OleDbCommand com3 = new dabse.OleDbCommand("SELECT DISTINCT (Группы_обучение.Год) FROM Группы_обучение", Date_baseone);
            dabse.OleDbDataReader resulter3 = com3.ExecuteReader();

            while (resulter3.Read() == true)
            {
                var mc = resulter3[0].ToString().Trim();
                data3.Add(mc);
            }
            
            comboBox1.DataSource = data1;
            comboBox1.DisplayMember = "secondpole";
            comboBox1.ValueMember = "firstpole";

            comboBox2.DataSource = data2;
            comboBox2.DisplayMember = "secondpole";
            comboBox2.ValueMember = "firstpole";

            comboBox3.DataSource = data3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            
            dabse.OleDbCommand command = new dabse.OleDbCommand();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            
            adapter.Fill(setOfData, nameoftable);
            

            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;

            MessageBox.Show("Загружено!");
        }

        private void deleter_Click(object sender, EventArgs e)
        {
            var deletecommand = new dabse.OleDbCommand("Delete from Группы_обучение where Номер_группы = ? and Шифр_студента = ?");
            int gn = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int ss = (int)dataGridView1.CurrentRow.Cells[1].Value;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = gn;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = ss;
            deletecommand.Connection = Date_baseone;
            int deletedrows = deletecommand.ExecuteNonQuery();
            MessageBox.Show("Удалена " + deletedrows + " запись");
        }

        private void saver_Click(object sender, EventArgs e)
        {
            command = new dabse.OleDbCommand();
            command.CommandText = "UPDATE Группы_обучение SET Год = ? WHERE (Номер_группы = ? and Шифр_студента = ?)";
            command.Parameters.Add("Год", dabse.OleDbType.Integer, 50, "Год");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Номер_группы", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Номер_группы", System.Data.DataRowVersion.Original, null));
            command.Parameters.Add(new dabse.OleDbParameter("Original_Шифр_студента", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Шифр_студента", System.Data.DataRowVersion.Original, null));

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
    }
}
