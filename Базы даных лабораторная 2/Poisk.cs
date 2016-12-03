using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OleDiBi = System.Data.OleDb;

namespace Базы_даных_лабораторная_2
{
    public partial class Poisk : Form
    {
        public Poisk()
        {
            InitializeComponent();
        }

        DataSet RecordKit;
        OleDiBi.OleDbConnection Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
        OleDiBi.OleDbCommand Command = new OleDiBi.OleDbCommand();
        OleDiBi.OleDbDataAdapter Adapter;

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            RecordKit = new DataSet();
            Adapter = new OleDiBi.OleDbDataAdapter("SELECT * FROM Студенты", Connection);
            Adapter.Fill(RecordKit, "Студенты");
            dataGridView1.DataSource = RecordKit;
            dataGridView1.DataMember = "Студенты";

            try
            {

                string selectString = "Фамилия LIKE '%" + textBox1.Text.Trim() + "%'";
                DataRowCollection allRows = ((DataSet)dataGridView1.DataSource).Tables[0].Rows;
                DataRow[] searchedRows = ((DataSet)dataGridView1.DataSource).Tables[0].Select(selectString);
                for (int i = 0; i < searchedRows.Count(); i++)
                {
                    int rowIndex = allRows.IndexOf(searchedRows[i]);
                    dataGridView1.Rows[rowIndex].Cells[1].Selected = true;
                }
            }
            catch (Exception WrongSituation)
            {
                MessageBox.Show(WrongSituation.Message, "Недоразумение, упс...");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            RecordKit = new DataSet();

            Adapter = new OleDiBi.OleDbDataAdapter("SELECT * FROM Специальности", Connection);
            Adapter.Fill(RecordKit, "Специальности");
            dataGridView1.DataSource = RecordKit;
            dataGridView1.DataMember = "Специальности";

            try
            {

                string selectString = "Шифр = " + textBox1.Text.Trim();
                DataRowCollection allRows = ((DataSet)dataGridView1.DataSource).Tables[0].Rows;
                DataRow[] searchedRows = ((DataSet)dataGridView1.DataSource).Tables[0].Select(selectString);
                for (int i = 0; i < searchedRows.Count(); i++)
                {
                    int rowIndex = allRows.IndexOf(searchedRows[i]);
                    dataGridView1.Rows[rowIndex].Cells[1].Selected = true;
                }
            }
            catch (Exception WrongSituation)
            {
                MessageBox.Show(WrongSituation.Message, "Недоразумение, упс...");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            RecordKit = new DataSet();
            Adapter = new OleDiBi.OleDbDataAdapter("SELECT * FROM Специальности", Connection);
            Adapter.Fill(RecordKit, "Специальности");
            dataGridView1.DataSource = RecordKit;
            dataGridView1.DataMember = "Специальности";

            try
            {
                string selectString = "Шифр = " + textBox1.Text.Trim();
                DataRowCollection allRows = ((DataSet)dataGridView1.DataSource).Tables[0].Rows;
                DataRow[] searchedRows = ((DataSet)dataGridView1.DataSource).Tables[0].Select(selectString);
                for (int i = 0; i < searchedRows.Count(); i++)
                {
                    int rowIndex = allRows.IndexOf(searchedRows[i]);
                    dataGridView1.Rows[rowIndex].Cells[1].Selected = true;
                }
            }
            catch (Exception WrongSituation)
            {
                MessageBox.Show(WrongSituation.Message, "Недоразумение, упс...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            RecordKit = new DataSet();
            
            Adapter = new OleDiBi.OleDbDataAdapter("SELECT * FROM Студенты", Connection);
            Adapter.Fill(RecordKit, "Студенты");
            dataGridView1.DataSource = RecordKit;
            dataGridView1.DataMember = "Студенты";

            try
            {

                string selectString = "Фамилия LIKE '%" + textBox1.Text.Trim() + "%'";
                DataRowCollection allRows = ((DataSet)dataGridView1.DataSource).Tables[0].Rows;
                DataRow[] searchedRows = ((DataSet)dataGridView1.DataSource).Tables[0].Select(selectString);
                for (int i = 0; i < searchedRows.Count(); i++)
                {
                    int rowIndex = allRows.IndexOf(searchedRows[i]);
                    dataGridView1.Rows[rowIndex].Cells[1].Selected = true;
                }
            }
            catch (Exception WrongSituation)
            {
                MessageBox.Show(WrongSituation.Message, "Недоразумение, упс...");
            }
        }

        private void Poisk_Load(object sender, EventArgs e)
        {
            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();
        }
    }
}
