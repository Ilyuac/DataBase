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
    public partial class TablesForm : Form
    {
        DataTable table1 = new DataTable();
        BindingSource source = new BindingSource();

        public TablesForm()
        {
            table1.Clear();
            table1 = DataBase.SelectCommand("SELECT Students.Family, Students.Name, Students.MiddleName, Students.[Group], Specialty.Specialty " +
                "FROM Students, Specialty WHERE Students.IDSpecial = Specialty.IDSpecial");
            InitializeComponent();
            dGV.Rows.Clear();

            table1.Columns[0].ColumnName = "Фамилия";
            table1.Columns[1].ColumnName = "Имя";
            table1.Columns[2].ColumnName = "Отчество";
            table1.Columns[3].ColumnName = "Группа";
            table1.Columns[4].ColumnName= "Специальность";

            dGV.DataSource = table1;
            source.DataSource = table1;

            foreach(DataGridViewColumn column in dGV.Columns)
            {
                lBFilters.Items.Add(column.Name);
            }

            cBFamily.DataSource = dGV.DataSource;
            cBFamily.DisplayMember = "Фамилия";

            radioButton1.Checked = true;
        }

        private void butSort_Click(object sender, EventArgs e)//сортировка датагридвью
        {
            DataGridViewColumn Col = ReturnColumn();

            if (radioButton1.Checked)
                dGV.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dGV.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private DataGridViewColumn ReturnColumn()//выбор поля сортировки
        {
            System.Windows.Forms.DataGridViewColumn Col = dGV.Columns[0];
            switch (lBFilters.SelectedIndex)
            {
                case 0:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
                case 1:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
                case 2:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
                case 3:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
                case 4:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
            }

            return Col;
        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butFiltr_Click(object sender, EventArgs e)
        {
            source.Filter = "Фамилия='" + cBFamily.Text + "'";
        }//Фильтрация строк

        private void lBFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            butSort.Enabled = true;
        }

        private void butShowAll_Click(object sender, EventArgs e)
        {
            source.Filter = "";
        }//Сброс фильтра

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }//зкрыть форму

        private void butSeartch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dGV.ColumnCount; i++)
                for (int j = 0; j < dGV.RowCount; j++)
                {
                    dGV[i, j].Style.BackColor = Color.White;
                    dGV[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < dGV.ColumnCount; i++)
                for (int j = 0; j < dGV.RowCount - 1; j++)
                    if (dGV[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        dGV[i, j].Style.BackColor = Color.AliceBlue;
                        dGV[i, j].Style.ForeColor = Color.Blue;
                    }
        }//поиск
    }
}
