﻿using System;
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

            //DataBase.Connection("SELECT Students.FIO, Students.[Group], Subjects.SubjectName, Tables.Mark FROM((Subjects INNER JOIN Tables ON Subjects.IDSubject = Tables.IDSubject) INNER JOIN Students ON Tables.IDStudent = Students.IDStudent)");

            ///Test Work Connection
            //foreach (DataRow row in DataBase.GetTable().Rows)
            //{
            //    MessageBox.Show(row["FIO"].ToString() + " " + row["Group"].ToString() + " " + row["SubjectName"].ToString() + " " + row["Mark"].ToString());
            //}

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataBase.Connection("SELECT * FROM Specialty");
            DataBase.Connection("SELECT * FROM Students");
            DataBase.Connection("SELECT * FROM Subjects");
            DataBase.Connection("SELECT * FROM Tables");
        }

        private void butSpetial_Click(object sender, EventArgs e)
        {
            TableSpetial spetial = new TableSpetial();
            spetial.Show();
        }

        private void butSubject_Click(object sender, EventArgs e)
        {
            TableSubject subject = new TableSubject();
            subject.Show();
        }

        private void butStud_Click(object sender, EventArgs e)
        {

        }

        private void butMark_Click(object sender, EventArgs e)
        {

        }
    }
}
