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
        DataView viewStudents = new DataView();
        DataView viewSudjects = new DataView();
        int nom = 0;

        public TableMark()
        {
            InitializeComponent();

            LoadForm(0);
        }

        private void LoadForm(int nom)//загрузка данных в форму
        {
            dGV.Rows.Clear();
            dGV.Columns.Clear();
            DataBase.UPdate();


            string command = "SELECT Students.Family, Subjects.SubjectName, Tables.Mark " +
                "FROM((Students INNER JOIN Tables ON Students.IDStudent = Tables.IDStudent)" +
                " INNER JOIN Subjects ON Tables.IDSubject = Subjects.IDSubject)";
            table = DataBase.SelectCommand(command);

            table.Columns[0].ColumnName = "Фамилия";
            table.Columns[1].ColumnName = "Предмет";
            table.Columns[2].ColumnName = "Оценка";

            viewStudents = DataBase.SelectCommand("SELECT * FROM Students").DefaultView;
            cBFamily.DataSource = viewStudents;
            cBFamily.DisplayMember = "Family";
            cBFamily.ValueMember = "IDStudent";

            dGV.Columns.Add("Фамилия", "Фамилия");
            dGV.Columns[0].Visible = false;
            comboBoxColumn.Name = "Предмет";
            viewSudjects= DataBase.SelectCommand("SELECT * FROM Subjects").DefaultView;
            comboBoxColumn.DataSource = viewSudjects;
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



            cBFamily.SelectedIndex = 1;
            cBFamily.SelectedIndex = nom;
        }

        private void Error(object s,DataGridViewDataErrorEventArgs e) { }

        private void cBFamaly_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                dGV.Rows[i].Visible = dGV[0, i].Value.ToString() == cBFamily.Text;
            }

            for (int i = 0; i < viewStudents.Table.Rows.Count; i++)
                if (viewStudents.Table.Rows[i]["Family"].ToString() == cBFamily.Text)
                    nom = i;

        }

        private void UpdateData(int index)//обновление данных
        {
            if (dGV.Rows[index].Cells["Фамилия"].Value != null)
            {
                string commandStr = "UPDATE Tables SET Mark=@mark WHERE IDSubject=@sub and IDStudent=@stud";
                OleDbCommand command = new OleDbCommand(commandStr,DataBase.connection);

                command.Parameters.AddWithValue("mark", dGV.Rows[index].Cells["Оценка"].Value.ToString());

                var id = "";
                foreach (DataRow row in viewStudents.Table.Rows)
                    if (cBFamily.Text == row["Family"].ToString())
                    {
                        id = row["IDStudent"].ToString();
                    }
                var idSub = "";
                foreach (DataRow row in viewSudjects.Table.Rows)
                    if (row["SubjectName"].ToString() == dGV.Rows[dGV.CurrentRow.Index].Cells["Предмет"].Value.ToString())
                    {
                        idSub = row["IDSubject"].ToString();
                    }
                command.Parameters.AddWithValue("sub", idSub);
                command.Parameters.AddWithValue("stud", id);

                DataBase.DBCommand(command);
            }
        }

        private void butSave_Click(object sender, EventArgs e)//Сохранение 
        {
            for (int i = 0; i < dGV.Rows.Count; i++)
                if(dGV.Rows[i].Cells["Оценка"].Value !=null)
                    UpdateData(i);
            MessageBox.Show("Сохранение прошло успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadForm(nom);
        }

        private void butAdd_Click(object sender, EventArgs e)//Добавление данных
        {
            AddMark addMark = new AddMark(cBFamily.Text, viewSudjects, viewStudents);
            addMark.Show();
            addMark.FormClosed += new FormClosedEventHandler(reload);
        }

        private void reload(object s, FormClosedEventArgs e)
        {
            LoadForm(nom);
        }

        private void butDelet_Click(object sender, EventArgs e)//Удаление
        {
            if(dGV.SelectedRows.Count==1)
            {
                string commandDel = "DELETE FROM Tables WHERE IDSubject=@sub and IDStudent=@stud";
                OleDbCommand command = new OleDbCommand(commandDel, DataBase.connection);
                var id = "";
                foreach(DataRow row in viewStudents.Table.Rows)
                    if(cBFamily.Text==row["Family"].ToString())
                    {
                        id = row["IDStudent"].ToString();
                    }
                var idSub="";
                foreach(DataRow row in viewSudjects.Table.Rows)
                if(row["SubjectName"].ToString()==dGV.Rows[dGV.CurrentRow.Index].Cells["Предмет"].Value.ToString())
                    {
                        idSub = row["IDSubject"].ToString();
                    }
                command.Parameters.AddWithValue("sub", idSub);
                command.Parameters.AddWithValue("stud", id);

                DataBase.DBCommand(command);
                MessageBox.Show("Запись удалена!","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadForm(nom);
            }
            else
            {
                MessageBox.Show("Выберете только одну строку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
