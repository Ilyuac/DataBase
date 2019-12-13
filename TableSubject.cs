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

            load();
        }

        private void load()
        {
            DataBase.UPdate();
            foreach (DataTable table in DataBase.Tables)
            {
                if (table.TableName == "Subjects")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        rows.Add(row);
                        CBSpetial.Items.Add(row["SubjectName"].ToString());
                    }
                }
            }
        }

        private void Add()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("INSERT INTO [Subjects] ([SubjectName]) VALUES (@Sbj)",
            DataBase.connection);
            command.Parameters.AddWithValue("Sbj", CBSpetial.Text);

            DataBase.DBCommand(command);

        }

        private void Delete()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("DELETE FROM [Subjects] WHERE [IDSubject]=@Sp",
            DataBase.connection);
            foreach (DataRow row in rows)
                if (row["SubjectName"].ToString() == CBSpetial.Text)
                    command.Parameters.AddWithValue("Sp", row["IDSubject"].ToString());

            DataBase.DBCommand(command);

        }

        private void UPdate()
        {
            System.Data.OleDb.OleDbCommand command =
            new System.Data.OleDb.OleDbCommand("UPDATE [Subjects] SET  SubjectName =@sp WHERE IDSubject =@idSp",
            DataBase.connection);
            foreach (DataRow row in rows)
                if (row["SubjectName"].ToString() == CBSpetial.Text)
                    command.Parameters.AddWithValue("idSp", row["IDSpecial"].ToString());
            command.Parameters.AddWithValue("sp", CBSpetial.Text);

            DataBase.DBCommand(command);

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Add();
            MessageBox.Show("Оценка добавлена.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            UPdate();
            MessageBox.Show("Сохранение прошло успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
        }

        private void butDelet_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("Запись удалена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();
        }
    }
}
