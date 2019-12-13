using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BDApp
{
    public partial class TableMark : Form
    {
        DataTable table = new DataTable();
        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();

        public TableMark()
        {
            InitializeComponent();

            LoadForm();

            cBFamily.SelectedIndex = 1;
            cBFamily.SelectedIndex = 0;
        }

        private void LoadForm()
        {
            string command = "SELECT Students.Family, Subjects.SubjectName, Tables.Mark " +
                "FROM((Students INNER JOIN Tables ON Students.IDStudent = Tables.IDStudent)" +
                " INNER JOIN Subjects ON Tables.IDSubject = Subjects.IDSubject)";
            table = DataBase.SelectCommand(command);

            table.Columns[0].ColumnName = "Фамилия";
            table.Columns[1].ColumnName = "Предмет";
            table.Columns[2].ColumnName = "Оценка";

            DataTable table1 = DataBase.SelectCommand("SELECT * FROM Students");

            cBFamily.DataSource = table1;
            cBFamily.DisplayMember = "Family";
            cBFamily.ValueMember = "IDStudent";

            dGV.Columns.Add("Фамилия", "Фамилия");
            dGV.Columns[0].Visible = false;
            comboBoxColumn.Name = "Предмет";
            comboBoxColumn.DataSource = DataBase.SelectCommand("SELECT * FROM Subjects");
            comboBoxColumn.DisplayMember = "SubjectName";
            comboBoxColumn.ValueMember = "IDSubject";
            dGV.Columns.Add(comboBoxColumn);
            dGV.Columns.Add("Оценка", "Оценка");
            dGV.ShowCellErrors = false;
            dGV.DataError += new DataGridViewDataErrorEventHandler(Error);

                foreach (DataRow row in table.Rows)
                {
                    dGV.Rows.Add(row.ItemArray);
                }
        }

        private void Error(object s,DataGridViewDataErrorEventArgs e) { }

        private void cBFamaly_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.Rows.Count - 1; i++)
                dGV.Rows[i].Visible = dGV[0, i].Value.ToString() == cBFamily.Text;

        }

        private void UpdateData(int index)
        {
            if (dGV.Rows[index].Cells["Фамилия"].Value != null)
            {
                string commandStr = "UPDATE Tables SET Mark='@mark', IDSubject='@sub', IDStudent='@stud'";
                OleDbCommand command = new OleDbCommand(commandStr,DataBase.connection);

                command.Parameters.AddWithValue("mark", dGV.Rows[index].Cells["Оценка"].Value.ToString());
                int n = ((DataGridViewComboBoxCell)dGV.Rows[index].Cells["Предмет"]).Items.IndexOf(
                            ((DataGridViewComboBoxCell)dGV.Rows[index].Cells["Предмет"]).Value.ToString())+2;
                command.Parameters.AddWithValue("sub", n);
                command.Parameters.AddWithValue("stud", cBFamily.SelectedItem.ToString()) ;

                DataBase.DBCommand(command);
            }
            //else
            //{
            //    if (dGV.Rows[index].Cells["Оценка"].Value != null && dGV.Rows[index].Cells["Предмет"].Value!= null)
            //    {
            //        string commandStr = "INSERT INTO Tables ([Mark], [IDSubject], [IDStudent])" +
            //        "VALUES (@mark,(SELECT IDSubject FROM Subjects WHERE SubjectName=@name), " +
            //        "(SELECT IDStudent FROM Students WHERE Family=@stname))";
            //        OleDbCommand command = new OleDbCommand(commandStr, DataBase.connection);

            //        command.Parameters.AddWithValue("mark", dGV.Rows[index].Cells["Оценка"].Value.ToString());
            //        command.Parameters.AddWithValue("name", dGV.Rows[index].Cells["Предмет"].Value.ToString());
            //        command.Parameters.AddWithValue("stname", cBFamily.Text);


            //        DataBase.DBCommand(command);
            //    }
            //}


        }

        private void butSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.Rows.Count; i++)
                if(dGV.Rows[i].Cells["Оценка"].Value !=null)
                    UpdateData(i);
        }
    }
}
