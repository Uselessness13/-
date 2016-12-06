using System;
using System.Collections.Generic;
using System.Data;
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

            command = new dabse.OleDbCommand("Select Дисциплины.Название, Дисциплины_обучение.Балл From Дисциплины, Дисциплины_обучение, Студенты Where Дисциплины.Код = Дисциплины_обучение.Код_дисциплины and Студенты.Шифр = Дисциплины_обучение.Шифр_студента and Студенты.Шифр = " + firststudensshifr.Text + " order by Дисциплины_обучение.Балл, Дисциплины.Название", Date_baseone);
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

            docec.Tables.Add(range, len + 1, 2, ref missing, ref missing);
            docec.Tables[1].Cell(1, 1).Range.Text = "Название дисциплины";
            docec.Tables[1].Cell(1, 2).Range.Text = "Балл";

            for (int i = 0; i < len; i++)
            {
                docec.Tables[1].Cell(i + 2, 1).Range.Text = two[i];
                docec.Tables[1].Cell(i + 2, 2).Range.Text = one[i];
            }

            wooord.Border[] bords = new wooord.Border[6];

            wooord.Table table = docec.Tables[docec.Tables.Count];

            bords[0] = table.Borders[wooord.WdBorderType.wdBorderLeft];
            bords[1] = table.Borders[wooord.WdBorderType.wdBorderRight];
            bords[2] = table.Borders[wooord.WdBorderType.wdBorderTop];
            bords[3] = table.Borders[wooord.WdBorderType.wdBorderBottom];
            bords[4] = table.Borders[wooord.WdBorderType.wdBorderVertical];
            bords[5] = table.Borders[wooord.WdBorderType.wdBorderHorizontal];

            foreach (wooord.Border border in bords)
            {
                border.LineStyle = wooord.WdLineStyle.wdLineStyleSingle;
                border.Color = wooord.WdColor.wdColorBlack;
            }
            app.Visible = true;
        }

        private void Wordec_Load(object sender, EventArgs e)
        {
            Date_baseone = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Date_baseone.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String surname;
            String name;
            String middlename;
            String mark;
            List<String> surnameMas = new List<String>();
            List<String> nameMas = new List<String>();
            List<String> middlenameMas = new List<String>();
            List<String> markMas = new List<String>();

            var Command = new dabse.OleDbCommand("SELECT DISTINCT Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, Дисциплины_обучение.Балл FROM ((Дисциплины_обучение INNER JOIN Дисциплины ON Дисциплины_обучение.Код_дисциплины = Дисциплины.Код) INNER JOIN Студенты ON Дисциплины_обучение.Шифр_студента = Студенты.Шифр), Группы_обучение WHERE Дисциплины.Название = " + "\"" + secondnameofsubject.Text + "\" AND Группы_обучение.Номер_группы = " + secondnumberofgroup.Text, Date_baseone);

            dabse.OleDbDataReader Ask2 = Command.ExecuteReader();

            wooord.Application application = new wooord.Application();
            Object missing = Type.Missing;
            application.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            wooord.Document doc = application.ActiveDocument;
            wooord.Range range = doc.Paragraphs[doc.Paragraphs.Count].Range;

            while (Ask2.Read() == true)
            {
                surname = Ask2[0].ToString();
                name = Ask2[1].ToString();
                middlename = Ask2[2].ToString();
                mark = Ask2[3].ToString();

                surnameMas.Add(surname);
                nameMas.Add(name);
                middlenameMas.Add(middlename);
                markMas.Add(mark);
            }

            int length = markMas.Count;

            doc.Tables.Add(range, length + 1, 6, ref missing, ref missing);
            doc.Tables[1].Cell(1, 1).Range.Text = "Фамилия";
            doc.Tables[1].Cell(1, 2).Range.Text = "Имя";
            doc.Tables[1].Cell(1, 3).Range.Text = "Отчество";
            doc.Tables[1].Cell(1, 4).Range.Text = "Балл";
            doc.Tables[1].Cell(1, 5).Range.Text = "Оценка";
            doc.Tables[1].Cell(1, 6).Range.Text = "Подпись экзаменатора";

            for (int i = 0; i < length; i++)
            {
                doc.Tables[1].Cell(i + 2, 1).Range.Text = surnameMas[i];
                doc.Tables[1].Cell(i + 2, 2).Range.Text = nameMas[i];
                doc.Tables[1].Cell(i + 2, 3).Range.Text = middlenameMas[i];
                doc.Tables[1].Cell(i + 2, 4).Range.Text = markMas[i];

                if (int.Parse(markMas[i]) >= 90 && int.Parse(markMas[i]) <= 100)
                {
                    doc.Tables[1].Cell(i + 2, 5).Range.Text = "5";
                }
                if (int.Parse(markMas[i]) >= 70 && int.Parse(markMas[i]) <= 89)
                {
                    doc.Tables[1].Cell(i + 2, 5).Range.Text = "4";
                }
                if (int.Parse(markMas[i]) >= 60 && int.Parse(markMas[i]) <= 69)
                {
                    doc.Tables[1].Cell(i + 2, 5).Range.Text = "3";
                }
                if (int.Parse(markMas[i]) >= 50 && int.Parse(markMas[i]) <= 59)
                {
                    doc.Tables[1].Cell(i + 2, 5).Range.Text = "2";
                }

            }

            wooord.Border[] borders = new wooord.Border[6];
            wooord.Table tbl = doc.Tables[doc.Tables.Count];
            borders[0] = tbl.Borders[wooord.WdBorderType.wdBorderLeft];
            borders[1] = tbl.Borders[wooord.WdBorderType.wdBorderRight];
            borders[2] = tbl.Borders[wooord.WdBorderType.wdBorderTop];
            borders[3] = tbl.Borders[wooord.WdBorderType.wdBorderBottom];
            borders[4] = tbl.Borders[wooord.WdBorderType.wdBorderHorizontal];
            borders[5] = tbl.Borders[wooord.WdBorderType.wdBorderVertical];
            foreach (wooord.Border border in borders)
            {
                border.LineStyle = wooord.WdLineStyle.wdLineStyleSingle;
                border.Color = wooord.WdColor.wdColorBlack;
            }
            application.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String surname;
            String groupName;
            String specialityName;
            String formOfEducation;
            String yearsofEducation;

            List<String> surnameMas = new List<String>();
            List<String> groupNameMas = new List<String>();
            List<String> specialityNameMas = new List<String>();
            List<String> formOfEducationMas = new List<String>();
            List<String> yearsofEducationMas = new List<String>();

            var Command = new dabse.OleDbCommand("SELECT Студенты.Фамилия, Группы.Название, Специальности.Название, Студенты.Форма_обучения, Специальности.Срок_обучения FROM  Группы, Группы_обучение, Студенты, Специальности WHERE Группы.Номер = Группы_обучение.Номер_группы AND Группы_обучение.Шифр_студента = Студенты.Шифр AND Студенты.Специальность = Специальности.Шифр AND Студенты.Шифр = " + thirdshifrsudenta.Text + "AND Группы_обучение.Год = " + thirdnameofsubject.Text, Date_baseone);

            dabse.OleDbDataReader Ask3 = Command.ExecuteReader();

            while (Ask3.Read() == true)
            {
                surname = Ask3[0].ToString();
                groupName = Ask3[1].ToString();
                specialityName = Ask3[2].ToString();
                formOfEducation = Ask3[3].ToString();
                yearsofEducation = Ask3[4].ToString();

                surnameMas.Add(surname);
                groupNameMas.Add(groupName);
                specialityNameMas.Add(specialityName);
                formOfEducationMas.Add(formOfEducation);
                yearsofEducationMas.Add(yearsofEducation);
            }

            wooord.Application wordApp = new wooord.Application();
            wordApp.Visible = true;
            object oMissing = Type.Missing;
            wooord.Document wordDoc;
            wooord.Paragraph wordPar;
            wooord.Range wordRan;
            wordDoc = wordApp.Documents.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //задаём форматирование для первого абзаца, которое будет так же и для всего документа, но 
            //это не страшно. Последующие абзацы будут иметь другое форматирование

            Object begin = Type.Missing;
            Object end = Type.Missing;
            wordRan = wordDoc.Range(ref begin, ref end);
            wordRan.ParagraphFormat.Alignment = wooord.WdParagraphAlignment.wdAlignParagraphCenter;
            wordRan.Text = "Справка";

            //теперь задаём форматирование следующего абзаца

            wordPar = wordDoc.Paragraphs.Add(ref oMissing);
            wordDoc.Paragraphs[2].Range.ParagraphFormat.Alignment = wooord.WdParagraphAlignment.wdAlignParagraphLeft;
            wordDoc.Paragraphs[2].Range.Font.Size = 10;
            wordDoc.Paragraphs[2].Range.Text = "Студент " + surnameMas[0] + " обучается в группе " + groupNameMas[0] + " по специальности " + specialityNameMas[0] + ". Форма обучения – " + formOfEducationMas[0] + ". Срок обучения – " + yearsofEducationMas[0] + ".";
        }
    }
}
