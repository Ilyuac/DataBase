using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDApp
{
    public partial class TableMark : Form
    {
        DataTable table = new DataTable();
        BindingSource source = new BindingSource();

        public TableMark()
        {
            InitializeComponent();

            LoadForm();
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

            cBFamaly.DataSource = table1;
            cBFamaly.DisplayMember = "Family";

            dGV.DataSource = table;
            dGV.Columns["Фамилия"].Visible = false;
            source.DataSource = dGV.DataSource;
        }

        private void cBFamaly_SelectedIndexChanged(object sender, EventArgs e)
        {
            source.Filter = "Фамилия='" + cBFamaly.Text + "'";
        }

        private void UpdateData()
        {
            string command = "";
            OleDbCommand commandUp = new OleDbCommand(command);
        }
    }
}
