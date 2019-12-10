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
    public partial class LINQStudent : Form
    {
        public LINQStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            Get_student get_Student = new Get_student();
            get_Student.get_table(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jadeo\source\repos\DataBase\Database.mdb");
            var otlichkic = from s in get_Student.students where s.bull == 5 select s;
            dataGridView1.RowCount = (int)otlichkic.Count();
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Бал";
            int i = 0;
            foreach(Student student in otlichkic)
            {
                dataGridView1.Rows[i].Cells[0].Value = student.name;
                dataGridView1.Rows[i].Cells[1].Value = student.fam;
                dataGridView1.Rows[i].Cells[2].Value = student.bull;
                i++;
            }

        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {
            Get_student get_Student = new Get_student();
            get_Student.get_table(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jadeo\source\repos\DataBase\Database.mdb");
            var otlichkic =get_Student.students.Average(p => p.bull);
            dataGridView1.RowCount = (int)otlichkic.Count();
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Средний балл";
            int i = 0;
            foreach (Student student in otlichkic)
            {
                dataGridView1.Rows[i].Cells[0].Value = student.name;
                dataGridView1.Rows[i].Cells[1].Value = student.fam;
                dataGridView1.Rows[i].Cells[2].Value = student.bull;
                i++;
            }
        }*/
    }
}
