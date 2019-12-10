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
    public partial class TableSpetial : Form
    {
        List<DataRow> rows = new List<DataRow>();
        public TableSpetial()
        {
            InitializeComponent();

            foreach (DataTable table in DataBase.Tables)
            {
                if (table.TableName == "Specialty")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        rows.Add(row);
                        CBSpetial.Items.Add(row["Specialty"].ToString());
                    }
                }
            }

            CBSpetial.SelectedValueChanged += new EventHandler(LoadInfo);
        }

        private void LoadInfo(object s, EventArgs e)
        {
            foreach(DataRow row in rows)
            {
                if(row["Specialty"].ToString()==CBSpetial.Text)
                {
                    TBInfo.Text = row["Info"].ToString();
                }
            }
        }

        private void Add(object s, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand command = 
            new System.Data.OleDb.OleDbCommand("INSERT INTO [Specialty] ([Specialty], [Info]) VALUES (@Sp, @Inf)", 
            DataBase.connection);
            command.Parameters.AddWithValue("Sp",CBSpetial.Text);
            command.Parameters.AddWithValue("Inf", TBInfo.Text);

            DataBase.DBCommand(command);

        }

        private void Delete(object s, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("DELTE FROM [Specialty] WHERE [Specialty]=@Sp",
            DataBase.connection);
            command.Parameters.AddWithValue("Sp", CBSpetial.Text);

            DataBase.DBCommand(command);

        }


    }
}
