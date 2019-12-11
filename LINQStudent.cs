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
        Get_student get_Student = new Get_student();
        Get_student get_predmet = new Get_student();
        string stringConnect = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\jadeo\source\repos\DataBase\Database.mdb";
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();


            
            
            var otlichkic = from s in get_Student.students where s.bull == 5 select s;
            dataGridView1.RowCount = (int)otlichkic.Count();
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Бал";
            dataGridView1.Columns[3].HeaderText = "Предмет";
            int i = 0;
            foreach(Student student in otlichkic)
            {
                dataGridView1.Rows[i].Cells[0].Value = student.name;
                dataGridView1.Rows[i].Cells[1].Value = student.fam;
                dataGridView1.Rows[i].Cells[2].Value = student.bull;
                dataGridView1.Rows[i].Cells[3].Value = student.name_subject;
                i++;
            }

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            
            //Уникальные ФИО
            var stedentDistinct = get_Student.students.Select(m => new { m.name, m.fam }).Distinct();

            dataGridView1.RowCount = (int)stedentDistinct.Count();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Средний балл";
            
            int i = 0;
            //Средние значения баллов
            foreach (var FIO in stedentDistinct)
            {
                double otlichkic = Math.Round( get_Student.students.Where(s => s.name ==FIO.name && s.fam == FIO.fam).Average(p => p.bull),1);
                dataGridView1.Rows[i].Cells[0].Value = FIO.name;
                dataGridView1.Rows[i].Cells[1].Value = FIO.fam;
                dataGridView1.Rows[i].Cells[2].Value = otlichkic;
                
                i++;

            }
        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            
            //Уникальные ФИО
            var stedentDistinct = get_Student.students.Select(m => new { m.name, m.fam }).Distinct();

            int i = 0, otl = 0, dvoeshnic = 0;
            //Средние значения баллов
            foreach (var FIO in stedentDistinct)
            {
                double otlichkic = get_Student.students.Where(s => s.name == FIO.name && s.fam == FIO.fam).Average(p => p.bull);
                if(otlichkic>=4.4) otl++;
                if(otlichkic <= 2.4) dvoeshnic++;
            }
            if(otl> dvoeshnic)
            {
                MessageBox.Show("Больше отличников");
            }
            else if (otl < dvoeshnic)
            {
                MessageBox.Show("Больше двоечников");
            }
            else
                MessageBox.Show("Одинаково");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            //Уникальные ФИО
            var stedentDistinct = get_Student.students.Select(m => new { m.name, m.fam }).Distinct();
            var studGroups = from s in stedentDistinct group s by s.name.Substring(0,1);
            dataGridView1.RowCount = stedentDistinct.Count();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Ключ";
            int i = 0;
            //Средние значения баллов
            foreach (var group_name in studGroups)
            {
                
                foreach (var ort in group_name)
                {   dataGridView1.Rows[i].Cells[2].Value = group_name.Key;
                    dataGridView1.Rows[i].Cells[0].Value = ort.name;
                    dataGridView1.Rows[i].Cells[1].Value = ort.fam;
                    
                    i++;
                }

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            
            //
            var studGroups = from s in get_Student.students group s by s.name;
            double[] delta = new double[studGroups.Count()];
            int i = 0;
            //
            foreach (var group_name in studGroups)
            {
                delta[i] = 0;
                foreach (var ort in group_name)
                {
                    delta[i] += ort.bull;
                }
                i++;
            }
            MessageBox.Show("Разница = "+Convert.ToString(delta.Max() - delta.Min()));
        }

        private void LINQStudent_Load(object sender, EventArgs e)
        {
            get_Student.get_table();
            get_predmet.get_predmet();
            dataGridView1.Rows.Clear();
         
            for (int i = 0; i < get_predmet.subjects.Count(); i++)
                comboBox1.Items.Add(get_predmet.subjects[i]);
         
            var stedentDistinct = get_Student.students.Select(m => new { m.name, m.fam }).Distinct();
           foreach(var name in stedentDistinct)
                comboBox2.Items.Add(name.fam);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            
            get_Student.students.Add(new Student
            { name= (from s in get_Student.students where s.fam == comboBox2.Text select s.name).ElementAt(0),
                fam = Convert.ToString(comboBox2.Text),

                bull = Convert.ToInt32(textBox1.Text),
                name_subject = Convert.ToString(comboBox1.Text)
            });

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = get_Student.students.Count();
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Бал";
            dataGridView1.Columns[3].HeaderText = "Предмет";
            int i = 0;
            foreach (Student student in get_Student.students)
            {
                dataGridView1.Rows[i].Cells[0].Value = student.name;
                dataGridView1.Rows[i].Cells[1].Value = student.fam;
                dataGridView1.Rows[i].Cells[2].Value = student.bull;
                dataGridView1.Rows[i].Cells[3].Value = student.name_subject;
                i++;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            

            //

        }
    }
}
