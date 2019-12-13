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

        private void Add()
        {
            System.Data.OleDb.OleDbCommand command = 
            new System.Data.OleDb.OleDbCommand("INSERT INTO [Specialty] ([Specialty], [Info]) VALUES (@Sp, @Inf)", 
            DataBase.connection);
            command.Parameters.AddWithValue("Sp",CBSpetial.Text);
            command.Parameters.AddWithValue("Inf", TBInfo.Text);

            DataBase.DBCommand(command);

        }

        private void Delete()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("DELETE FROM [Specialty] WHERE [IDSpecial]=@Sp",
            DataBase.connection);
            foreach(DataRow row in rows)
                if(row["Specialty"].ToString()== CBSpetial.Text)
                    command.Parameters.AddWithValue("Sp", row["IDSpecial"].ToString());

            DataBase.DBCommand(command);

        }

        private void UPdate()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("UPDATE Specialty SET Specialty.Specialty = @sp, Specialty.Info = @Inf " +
            "WHERE(((Specialty.IDSpecial) = @id))",
            DataBase.connection);
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i]["Specialty"].ToString() == CBSpetial.Text)
                {
                    command.Parameters.AddWithValue("id", rows[i]["Specialty"].ToString());
                }
            }

            command.Parameters.AddWithValue("sp", CBSpetial.Text);
            command.Parameters.AddWithValue("Inf", TBInfo.Text);

            DataBase.DBCommand(command);

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            UPdate();
            MessageBox.Show("Сохранение прошло успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInfo(sender,e);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Add();
            MessageBox.Show("Оценка добавлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInfo(sender, e);
        }

        private void butDelet_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("Запись удалена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInfo(sender, e);
        }
    }
}
