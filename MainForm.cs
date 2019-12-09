using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataBase.Connection("SELECT Students.FIO, Students.[Group], Subjects.SubjectName, Tables.Mark FROM((Subjects INNER JOIN Tables ON Subjects.IDSubject = Tables.IDSubject) INNER JOIN Students ON Tables.IDStudent = Students.IDStudent)");

            ///Test Work Connection
            //foreach (DataRow row in DataBase.GetTable().Rows)
            //{
            //    MessageBox.Show(row["FIO"].ToString() + " " + row["Group"].ToString() + " " + row["SubjectName"].ToString() + " " + row["Mark"].ToString());
            //}

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DataBase.Connection("")
        }
    }
}
