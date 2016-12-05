using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dabse = System.Data.OleDb;
using wooord = Microsoft.Office.Interop.Word;

namespace Базы_даных_лабораторная_2
{
    public partial class Wordec : Form
    {
        dabse.OleDbConnection Date_baseone;
        dabse.OleDbCommand command;

        public Wordec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name;
            String mark;
            List<String> one = new List<String>();
            List<String> two = new List<String>();

            command = new dabse.OleDbCommand("Select Дисциплины.Название, Дисциплины_обучение.Балл From Дисциплины, Дисциплины_обучение, Студенты Where Дисциплины.Код = Дисциплины_обучение.Код_дисциплины and Студенты.Шифр = Дисциплины_обучение.Шифр_студента and Студенты.Шифр = " + firststudensshifr.Text, Date_baseone);
            dabse.OleDbDataReader result = command.ExecuteReader();
            wooord.Application app = new wooord.Application();
            Object missing = Type.Missing;
            app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            wooord.Document docec = app.ActiveDocument;
            wooord.Range range = docec.Paragraphs[docec.Paragraphs.Count].Range;

            while (result.Read())
            {
                name = result[1].ToString();
                mark = result[0].ToString();

                one.Add(name);
                two.Add(mark);
            }

            int len = two.Count;



        }

        private void Wordec_Load(object sender, EventArgs e)
        {
            Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Date_baseone.Open();
        }
    }
}
