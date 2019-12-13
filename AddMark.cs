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
    public partial class AddMark : Form
    {
        DataView view = new DataView();
        DataView viewStud = new DataView();

        public AddMark(string name, DataView view, DataView viewStud)
        {
            InitializeComponent();

            this.viewStud = viewStud;

            StudName.Text = name;
            cBSubject.DataSource = view;
            cBSubject.DisplayMember = "SubjectName";
            cBSubject.ValueMember = "IDSubject";

            this.view = view;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string commandStr = "INSERT INTO Tables ([Mark], [IDSubject], [IDStudent]) VALUES (@mark, @sub, @stud)";
            OleDbCommand command = new OleDbCommand(commandStr, DataBase.connection);

            command.Parameters.AddWithValue("mark",tBMark.Text);
            var idSub = "";
            foreach (DataRow row in view.Table.Rows)
                if (row["SubjectName"].ToString() == cBSubject.Text)
                {
                    idSub = row["IDSubject"].ToString();
                }
            command.Parameters.AddWithValue("sub", idSub);

            var id = "";
            foreach (DataRow row in viewStud.Table.Rows)
                if (StudName.Text == row["Family"].ToString())
                {
                    id = row["IDStudent"].ToString();
                }
            command.Parameters.AddWithValue("stud", id);

            DataBase.DBCommand(command);
            MessageBox.Show("Оценка добавлена.","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
    }
}
