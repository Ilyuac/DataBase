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
        public TablesForm()
        {
            int i=0;
            table1.Clear();
            table1 = DataBase.SelectCommand("SELECT Students.Family, Students.Name, Students.MiddleName, Students.[Group], Specialty.Specialty " +
                "FROM Students, Specialty WHERE Students.IDSpecial = Specialty.IDSpecial");
            InitializeComponent();
            dGV.Rows.Clear();
            //dGV.ColumnCount = 5;
            lBFilters.Items.Add(dGV.Columns.Add("Family", "Фамилия" ));
            lBFilters.Items.Add(dGV.Columns.Add("Name", "Имя"));
            lBFilters.Items.Add(dGV.Columns.Add("middle", "Отчество"));
            lBFilters.Items.Add(dGV.Columns.Add("Group", "Группа"));
            lBFilters.Items.Add(dGV.Columns.Add("Special", "Специальность"));

            
                    foreach (DataRow row in table1.Rows)
                    {
                        dGV.Rows.Add(row);
                        dGV.Rows[i].Cells[0].Value = row[0];
                        dGV.Rows[i].Cells[1].Value = row[1];
                        dGV.Rows[i].Cells[2].Value = row[2];
                        dGV.Rows[i].Cells[3].Value = row[3];
                        dGV.Rows[i].Cells[4].Value = row[4];
                        i++;
                    }

            radioButton1.Checked = true;
        }

        public void Search()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("",
            DataBase.connection);
        }

        private void butSort_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.DataGridViewColumn Col = dGV.Columns[lBFilters.SelectedIndex];
            switch (lBFilters.SelectedIndex)
            {
                case 0:
                    Col = dGV.Columns[lBFilters.SelectedIndex];
                    break;
                case 1:
                    ;
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
            if (radioButton1.Checked)
                dGV.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                dGV.Sort(Col, System.ComponentModel.ListSortDirection.Descending);

            
        }
    }
}
