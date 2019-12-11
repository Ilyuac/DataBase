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
        public TablesForm()
        {
            InitializeComponent();
            dGV.Rows.Clear();
            dGV.Columns[0].HeaderText = "Фамилия";
            dGV.Columns[1].HeaderText = "Имя";
            dGV.Columns[2].HeaderText = "Отчество";
            dGV.Columns[3].HeaderText = "Группа";
            dGV.Columns[4].HeaderText = "айди";
            foreach (DataTable table in DataBase.Tables)
            {
                if (table.TableName == "Students")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        dGV.Rows.Add(row);
                    }
                }

            }
        }
    }
}
