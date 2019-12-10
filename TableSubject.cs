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
    public partial class TableSubject : Form
    {
        List<DataRow> rows = new List<DataRow>();
        public TableSubject()
        {
            InitializeComponent();

            foreach (DataTable table in DataBase.Tables)
            {
                if (table.TableName == "Subjects")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        rows.Add(row);
                        CBSpetial.Items.Add(row["Subjects"].ToString());
                    }
                }
            }
        }

        private void Add(object s, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("INSERT INTO [Subjects] ([SubjectsName]) VALUES (@Sbj)",
            DataBase.connection);
            command.Parameters.AddWithValue("Sbj", CBSpetial.Text);

            DataBase.DBCommand(command);

        }

        private void Delete(object s, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("DELTE FROM [Subjects] WHERE [SubjectsName]=@Sp",
            DataBase.connection);
            command.Parameters.AddWithValue("Sp", CBSpetial.Text);

            DataBase.DBCommand(command);

        }
    }
}
