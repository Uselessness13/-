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
    public partial class Dvapolya : Form
    {
        DataSet setOfData;
        dabse.OleDbCommand command=new dabse.OleDbCommand();
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Data Source=Медведев.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
        private string nameoftable = "Специальности";
        public Dvapolya()
        {
            InitializeComponent();
        }

        private void Zapisat_Click(object sender, EventArgs e)
        {
        
            var Command1 = new dabse.OleDbCommand("INSERT INTO Специальности (Шифр, Название, Срок_обучения) VALUES (?, ?, ?)");

            Command1.Parameters.Add("Шифр", dabse.OleDbType.Integer).Value = int.Parse(textBoxShifr.Text);
            Command1.Parameters.Add("Название", dabse.OleDbType.VarWChar).Value = textBoxNazvanie.Text;
            Command1.Parameters.Add("Срок_обучения", dabse.OleDbType.Integer).Value = int.Parse(textBoxSrok_obucheniya.Text);

            Command1.Connection = Date_baseone;
            Command1.ExecuteNonQuery();

            MessageBox.Show("Добавлена запись");
        }

        

        private void Zkrit_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();

        }

        private void Specialnosti_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();
            adapter = new dabse.OleDbDataAdapter("Select * From " + nameoftable, Date_baseone); ;
            adapter.Fill(setOfData, nameoftable);
            
            dataGridView1.DataSource = setOfData;
            dataGridView1.DataMember = nameoftable;

            MessageBox.Show("Загружено!");
        }
        
        private void saver_Click(object sender, EventArgs e)
        {
            command.CommandText = "UPDATE Специальности SET Название = ?, Срок_обучения = ? WHERE (Шифр = ?)";
            command.Parameters.Add("Название", dabse.OleDbType.VarWChar, 50, "Название");
            command.Parameters.Add("Срок_обучения", dabse.OleDbType.VarWChar, 50, "Срок_обучения");
            command.Parameters.Add(new dabse.OleDbParameter("Original_Шифр", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Шифр", System.Data.DataRowVersion.Original, null));
            command.Connection = Date_baseone;
            adapter.UpdateCommand = command;

            try
            {
                int kol = adapter.Update(setOfData, nameoftable);
                MessageBox.Show("Обновлено " + kol + " записей");
                //Date_baseone.Close();
            }
            catch (Exception Ситуация_однако)
            { MessageBox.Show(Ситуация_однако.Message, "Недоразумение"); }

        }

        private void deleter_Click(object sender, EventArgs e)
        {
            var deletecommand = new dabse.OleDbCommand("Delete from " + nameoftable + " where Шифр = ?", Date_baseone);
            int shifrec = (int)dataGridView1.CurrentRow.Cells[0].Value;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = shifrec;
            int deletedrows = deletecommand.ExecuteNonQuery();
            MessageBox.Show("Удалено " + deletedrows + " ззаписей");
        }
    }
}