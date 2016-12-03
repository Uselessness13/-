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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static DataTable FunctionOfAdding(String stringsione)
        {
            var Database = new dabse.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Медведев.mdb");
            Database.Open();
            dabse.OleDbCommand loadingOfTable = new dabse.OleDbCommand("Select * From " + stringsione, Database);
            dabse.OleDbDataReader result = loadingOfTable.ExecuteReader();
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
            return table;
        }

        public static DataSet anotherFunctionOfAdding(string nameOfTable)
        {
            DataSet setOfData = new DataSet();
            var Database = new dabse.OleDbConnection("Data Source=Медведев.mdb;User ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
            dabse.OleDbCommand command = new dabse.OleDbCommand();
            dabse.OleDbDataAdapter adapter = new dabse.OleDbDataAdapter("Select * From " + nameOfTable, Database); ;
            Database.Open();
            adapter.Fill(setOfData, nameOfTable);
            Database.Close();
            return setOfData;
        }




        private void SwichToSpec_Click(object sender, EventArgs e)
        {
            Dvapolya specs = new Dvapolya();
            specs.Show();
        }

        private void SwichToGroups_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.Show();
        }

        private void SwichToDisciplines_Click(object sender, EventArgs e)
        {
            Disciplines disc = new Disciplines();
            disc.Show();
        }

        private void SwichToGroupsStud_Click(object sender, EventArgs e)
        {
            GroupsStudy groupst = new GroupsStudy();
            groupst.Show();
        }

        private void SwichToStudents_Click(object sender, EventArgs e)
        {
            Students st = new Students();
            st.Show();
        }

        private void swichToZapros_Click(object sender, EventArgs e)
        {
            Zapros zp = new Zapros();
            zp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ocenochki oc = new Ocenochki();
            oc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poisk po = new Базы_даных_лабораторная_2.Poisk();
            po.Show();
        }
    }
}
