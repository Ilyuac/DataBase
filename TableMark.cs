using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BDApp
{
    public partial class TableMark : Form
    {
        DataTable table = new DataTable();

        public TableMark()
        {
            InitializeComponent();

            LoadForm();

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

            DataTable table1 = DataBase.SelectCommand("SELECT Family FROM Students");

            cBFamily.DataSource = table1;
            cBFamily.DisplayMember = "Family";

            dGV.Columns.Add("Фамилия", "Фамилия");
            dGV.Columns[0].Visible = false;
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
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
            string command = "UPDATE Tables SET Mark=@mark WHERE (IDSubject=(SELECT IDSubject FROM Subjects WHERE SubjectName=@name) and " +
                "IDStudent=(SELECT IDStudent FROM Students WHERE Family=@stname))";
            OleDbCommand commandUp = new OleDbCommand(command);

            commandUp.Parameters.AddWithValue("mark", dGV.Rows[index].Cells["Оценка"].Value);
            commandUp.Parameters.AddWithValue("name", dGV.Rows[index].Cells["Предмет"].Value);
            commandUp.Parameters.AddWithValue("stname", dGV.Rows[index].Cells["Фамилия"].Value);

            DataBase.DBCommand(commandUp);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.Rows.Count; i++)
                UpdateData(i);
        }
    }
}
