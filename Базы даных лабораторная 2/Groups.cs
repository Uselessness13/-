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
    public partial class Groups : Form
    {
        private string nameoftable = "Группы";

        dabse.OleDbConnection Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
        dabse.OleDbCommand command;
        dabse.OleDbDataAdapter adapter;
        DataSet setOfData;

        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            Date_baseone.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var Command1 = new dabse.OleDbCommand("INSERT INTO Группы (Название) VALUES (?)");

            Command1.Parameters.Add("Название", dabse.OleDbType.VarWChar).Value = NameOfGroup.Text;
           
            Command1.Connection = Date_baseone;
            Command1.ExecuteNonQuery();

            MessageBox.Show("Добавлена запись");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
            var deletecommand = new dabse.OleDbCommand("Delete from Группы where Номер = ?");
            int gn = (int)dataGridView1.CurrentRow.Cells[0].Value;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = gn;
            deletecommand.Connection = Date_baseone;
            int deletedrows = deletecommand.ExecuteNonQuery();
            MessageBox.Show("Удалена " + deletedrows + " запись");
        }

        private void saver_Click(object sender, EventArgs e)
        {
            command = new dabse.OleDbCommand();
            command.CommandText = "UPDATE Группы WHERE Номер = ?";
            command.Parameters.Add(new dabse.OleDbParameter("Original_Номер", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Номер", System.Data.DataRowVersion.Original, null));

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
