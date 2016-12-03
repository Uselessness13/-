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
    public partial class Zapros : Form
    {
        public Zapros()
        {
            InitializeComponent();
        }

        private static List<string> comboboxFiller(string String1)
        {
            var Connect = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connect.Open();

            var data = new List<string>();

            OleDiBi.OleDbCommand COM = new OleDiBi.OleDbCommand(String1, Connect);

            OleDiBi.OleDbDataReader RESULT = COM.ExecuteReader();

            while (RESULT.Read() == true)
            {
                var map = RESULT[0].ToString();
                data.Add(map);
            }
            RESULT.Close();
            Connect.Close();

            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Database = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Database.Open();
            OleDiBi.OleDbCommand loadingOfTable = new OleDiBi.OleDbCommand(richTextBox1.Text, Database);
            OleDiBi.OleDbDataReader result = loadingOfTable.ExecuteReader();
            DataTable table = new DataTable();

            for (int i = 0; i < result.FieldCount; i++)
            {
                table.Columns.Add(result.GetName(i));
            }

            while (result.Read() == true)
            {
                object[] yacheiki = new object[result.FieldCount];
                for (int i = 0; i < result.FieldCount; i++)
                {
                    yacheiki[i] = result.GetValue(i);
                }
                table.Rows.Add(yacheiki);
            }
            result.Close();
            Database.Close();

            dataGridView1.DataSource = table;
        }
        private void Zapros_Load(object sender, EventArgs e)
        {
            oneSemestr.DataSource = comboboxFiller("SELECT DISTINCT (Дисциплины.Семестр) FROM Дисциплины");
            threeYear.DataSource = comboboxFiller("SELECT DISTINCT (Группы_обучение.Год) FROM Группы_обучение");
            fiveonesemestr.DataSource = comboboxFiller("SELECT DISTINCT (Дисциплины.Семестр) FROM Дисциплины");
            fivetwosemestr.DataSource = comboboxFiller("SELECT DISTINCT (Дисциплины.Семестр) FROM Дисциплины");
            fivetwonazvanie.DataSource = comboboxFiller("SELECT DISTINCT (Специальности.Название) FROM Специальности");
        }

        DataSet setOfData;
        OleDiBi.OleDbConnection Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медвдев.mdb");
        OleDiBi.OleDbCommand Command = new OleDiBi.OleDbCommand();
        OleDiBi.OleDbDataAdapter odaptor;

        private void button2_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, Стипендии.Сумма  FROM Студенты, Стипендии WHERE Студенты.Шифр = Стипендии.Шифр_студента AND Стипендии.Семестр = " +oneSemestr.Text, Connection);
            odaptor.Fill(setOfData, "Студенты");
            dataGridView2.DataSource = setOfData;
            dataGridView2.DataMember = "Студенты";
            Connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT DISTINCT Специальности.Название, ( SELECT COUNT(Студенты.Фамилия) FROM Студенты WHERE Студенты.Специальность = Специальности.Шифр AND Студенты.Признак_отчисления = 1 ) AS [Количество студентов] FROM Специальности", Connection);

            odaptor.Fill(setOfData, "Студенты");
            dataGridView5.DataSource = setOfData;
            dataGridView5.DataMember = "Студенты";
            Connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Группы.Название, COUNT(*) AS [Количествово студентов] FROM Группы, Группы_обучение, Студенты WHERE Студенты.Признак_отчисления = 1 AND Группы_обучение.Шифр_студента = Студенты.Шифр AND Группы.Номер = Группы_обучение.Номер_группы AND Группы_обучение.Год = " + threeYear.Text + " GROUP BY Группы.Название", Connection);

            odaptor.Fill(setOfData, "Группы");
            dataGridView3.DataSource = setOfData;
            dataGridView3.DataMember = "Группы";
            Connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Студенты.Гражданство, COUNT(*) AS [Количество студентов] FROM Студенты WHERE Студенты.Признак_отчисления = 1 GROUP BY Студенты.Гражданство", Connection);
            odaptor.Fill(setOfData, "Студенты");
            dataGridView6.DataSource = setOfData;
            dataGridView6.DataMember = "Студенты";
            Connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Студенты.Форма_обучения, COUNT(*) AS [Количество студентов] FROM Студенты WHERE Студенты.Признак_отчисления = 1 GROUP BY Студенты.Форма_обучения", Connection);
            odaptor.Fill(setOfData, "Студенты");
            dataGridView7.DataSource = setOfData;
            dataGridView7.DataMember = "Студенты";
            Connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Дисциплины.Форма_контроля, COUNT(*) AS [Количество дисциплин] FROM Дисциплины, Специальности WHERE Дисциплины.Шифр_специальности = Специальности.Шифр AND Специальности.Шифр =" + fiveonesemestr.Text + " GROUP BY Дисциплины.Форма_контроля", Connection);
            odaptor.Fill(setOfData, "Дисциплины");
            dataGridView4.DataSource = setOfData;
            dataGridView4.DataMember = "Дисциплины";
            Connection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setOfData = new DataSet();

            var Connection = new OleDiBi.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Connection.Open();

            odaptor = new OleDiBi.OleDbDataAdapter("SELECT Дисциплины.Форма_контроля, COUNT(*) AS[Количество дисциплин] FROM Дисциплины, Специальности WHERE Дисциплины.Шифр_специальности = Специальности.Шифр AND Специальности.Название = " + "\"" + fivetwonazvanie.Text + "\" AND Дисциплины.Семестр =" + fivetwosemestr.Text + " GROUP BY Дисциплины.Форма_контроля", Connection);
            odaptor.Fill(setOfData, "Дисциплины");
            dataGridView8.DataSource = setOfData;
            dataGridView8.DataMember = "Дисциплины";
            Connection.Close();
        }

    }
}
