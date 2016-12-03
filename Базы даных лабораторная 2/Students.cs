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
    public partial class Students : Form
    {
        dabse.OleDbDataAdapter adapter;
        dabse.OleDbConnection Date_baseone;
        private string nameoftable = "Студенты";
        dabse.OleDbCommand сommand = new dabse.OleDbCommand();
        DataSet setOfData;

        public Students()
        {
            InitializeComponent();
        }

        private void DobavitZapis_Click(object sender, EventArgs e)
        {
            var Command1 = new dabse.OleDbCommand("INSERT INTO Студенты (Фамилия, Имя, Отчество, Специальность, Гражданство, Форма_обучения, Признак_отчисления) VALUES (?, ?, ?, ?, ?, ?, ?)");

            Command1.Parameters.Add("Фамилия", dabse.OleDbType.VarWChar).Value = Familiya.Text;
            Command1.Parameters.Add("Имя", dabse.OleDbType.VarWChar).Value = textBox1.Text;
            Command1.Parameters.Add("Отчество", dabse.OleDbType.VarWChar).Value = Otchestvo.Text;
            Command1.Parameters.Add("Специальность", dabse.OleDbType.Integer).Value = int.Parse(specialnost.SelectedValue.ToString());
            Command1.Parameters.Add("Гражданство", dabse.OleDbType.VarWChar).Value = Grazhdanstvo.Text;
            Command1.Parameters.Add("Форма_обучения", dabse.OleDbType.VarWChar).Value = studyform.Text;
            Command1.Parameters.Add("Признак_отчисления", dabse.OleDbType.Integer).Value = int.Parse(priznakotchis.SelectedValue.ToString());

            Command1.Connection = Date_baseone;
            Command1.ExecuteNonQuery();

            MessageBox.Show("Запись добавлена");

            dataGridView1.DataSource = MainForm.FunctionOfAdding(nameoftable);
        }

        private void Zakrit_Click(object sender, EventArgs e)
        {
            Date_baseone.Close();
            this.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            var data1 = new List<Dvapolya>();

            Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Date_baseone.Open();
            dabse.OleDbCommand com1 = new dabse.OleDbCommand("Select Название, Шифр FROM Специальности", Date_baseone);
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

            specialnost.DataSource = data1;
            specialnost.DisplayMember = "secondpole";
            specialnost.ValueMember = "firstpole";

            var data2 = new List<Dvapolya>();
            var nc = new Dvapolya
            {
                secondpole = "обучается",
                firstpole = "1"
            };
            data2.Add(nc);
            var nc1 = new Dvapolya
            {
                secondpole = "отчислен",
                firstpole = "2"
            };
            data2.Add(nc1);

            priznakotchis.DataSource = data2;
            priznakotchis.DisplayMember = "secondpole";
            priznakotchis.ValueMember = "firstpole";
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
            сommand.CommandText = "UPDATE Студенты SET Фамлия=?, Имя=?, Отчество=?, Специальность=?, Гражданство=?, Форма_обучения=?, Признак_отчисления=? WHERE Шифр=?";
            сommand.Parameters.Add("Фамилия", dabse.OleDbType.VarWChar, 50, "Фамилия");
            сommand.Parameters.Add("Имя", dabse.OleDbType.VarWChar, 50, "Имя");
            сommand.Parameters.Add("Специальность", dabse.OleDbType.Integer, 50, "Специальность");
            сommand.Parameters.Add("Гражданство", dabse.OleDbType.VarWChar, 50, "Гражданство");
            сommand.Parameters.Add("Форма_обучения", dabse.OleDbType.VarWChar, 50, "Форма_обучения");
            сommand.Parameters.Add("Признак_отчисления", dabse.OleDbType.Integer, 50, "Признак_отчисления");
            сommand.Parameters.Add(new dabse.OleDbParameter("Original_Шифр", dabse.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, (byte)0, (byte)0, "Шифр", System.Data.DataRowVersion.Original, null));

            сommand.Connection = Date_baseone;
            adapter.UpdateCommand = сommand;

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
            var deletecommand = new dabse.OleDbCommand("Delete from Студенты where Шифр = ?");
            int gn = (int)dataGridView1.CurrentRow.Cells[0].Value;
            deletecommand.Parameters.Add("id", dabse.OleDbType.Integer, 50).Value = gn;
            deletecommand.Connection = Date_baseone;
            int deletedrows = deletecommand.ExecuteNonQuery();
            MessageBox.Show("Удалена " + deletedrows + " запись");
        }

        private void bbatonishe_Click(object sender, EventArgs e)
        {
            dabse.OleDbCommand newCom = new dabse.OleDbCommand();
            var comand = new dabse.OleDbCommand("SELECT Код, Название FROM Дисциплины   WHERE Шифр_специальности=?", Date_baseone);
            comand.Parameters.Add("Шфр_спц", dabse.OleDbType.Integer, 255).Value = int.Parse(shifrSpecialnosti.Text);
            comand.Connection = Date_baseone;
            dabse.OleDbDataReader Result = comand.ExecuteReader();

            int x = Result.FieldCount;
            String Name_disc, index_disk;

            while (Result.Read() == true)
            {
                index_disk = Result.GetValue(0).ToString();
                Name_disc = Result.GetValue(1).ToString();
                dabse.OleDbCommand spisok = new dabse.OleDbCommand("insert into Дисциплины_обучение (Шифр_студента, Код_дисциплины) values (?, ?)", Date_baseone);
                spisok.Parameters.Add("Шифр_студента", dabse.OleDbType.Integer, 255).Value = int.Parse(shifrStudenta.Text);
                spisok.Parameters.Add("Код_дисциплины", dabse.OleDbType.Integer, 255).Value = int.Parse(index_disk);
                spisok.Connection = Date_baseone;
                //MessageBox.Show(spisok.CommandText);
                spisok.ExecuteReader();
                //spisok.Close();
            }
            
            MessageBox.Show("Всё хорошо!!!");
        }
    }

    partial class Dvapolya
    {
        public string firstpole { get; set; }
        public string secondpole { get; set; }
    }
}
